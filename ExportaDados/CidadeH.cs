using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportaDados
{
    public abstract class CidadeH
    {
        public string CodCidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CodMunicipio { get; set; }
        public string CodSiafi { get; set; }
    }

    public class CidadesP : CidadeH { }
    public class CidadesS : CidadeH { }

    public class CidadeRespository
    {
        private readonly string sqlCidade = "Select * from cidades order by codcidade";
        public List<CidadesP> GetListaCidadesP()
        {
            //Console.WriteLine("Buscando registros de cidades no banco primario: ");
            List<CidadesP> listaCidades = new List<CidadesP>();
            try
            {
                DefaultTypeMap.MatchNamesWithUnderscores = true;
                #region Comentario DefaultTypeMap
                //Com essa funcao ativada o DAPPER consegui identificar que DT_CADASTRO é a mesma coisa que DTCADASTRO
                //https://stackoverflow.com/questions/34533349/how-to-get-dapper-to-ignore-remove-underscores-in-field-names-when-mapping/34536829#34536829
                //https://stackoverflow.com/questions/8902674/manually-map-column-names-with-class-properties
                #endregion
                Conexao conexao = new Conexao();
                FbConnection fbConnection = new FbConnection(conexao.conexao1);
                IEnumerable CidadeP = fbConnection.Query<CidadeH>(sqlCidade);
                foreach (CidadesP itemP in CidadeP)
                {
                    listaCidades.Add(itemP);
                }
                //Console.WriteLine("OK!");
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            return listaCidades;
        }
        public List<CidadesS> GetListaCidadesS()
        {
            //Console.WriteLine("Buscando registros de cidades no banco secundario: ");
            List<CidadesS> listaCidades = new List<CidadesS>();
            try
            {
                IEnumerable CidadeS = new FbConnection(new Conexao().conexao2).Query<CidadesS>(sqlCidade);
                foreach (CidadesS itemS in CidadeS)
                {
                    listaCidades.Add(itemS);
                }
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            //Console.WriteLine("OK!");
            return listaCidades;
        }
        public List<dynamic> ResultCidade()
        {
            List<CidadesP> cidadesP = GetListaCidadesP();
            List<CidadesS> cidadesS = GetListaCidadesS();
            List<CidadesP> Resul = new List<CidadesP>();
            //Console.WriteLine("Removendo registros ja inclusos no banco secundario: ");
            try
            {
                foreach (var item in cidadesP)
                {
                    Resul.Add(item);
                }

                foreach (var itemP in cidadesP)
                {
                    foreach (var itemS in cidadesS)
                    {
                        if (itemP.CodCidade.Equals(itemS.CodCidade))
                        {
                            Resul.Remove(itemP);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            //Console.WriteLine("OK!");
            return Resul.Cast<dynamic>().ToList();
        }
        public void InsertCidade()
        {
            string InsertCliente = "INSERT INTO CIDADES (CODCIDADE, CIDADE, ESTADO, CODMUNICIPIO, CODSIAFI)VALUES (@CODCIDADE, @CIDADE, @ESTADO, @CODMUNICIPIO, @CODSIAFI)";
            var result = ResultCidade();

            if (result.Count != 0)
            {
                foreach (var item in result)
                {
                    try
                    {

                        CidadesS cidade = new CidadesS();
                        cidade = new CidadesS
                        {
                            CodCidade = item.CodCidade,
                            Cidade = item.Cidade,
                            Estado = item.Estado,
                            CodMunicipio = item.CodMunicipio,
                            CodSiafi = item.CodSiafi
                        };
                        Console.WriteLine("Tentando inserir o registro: " + cidade.CodCidade + " - " + cidade.Cidade);
                        FbConnection fbConnection = new FbConnection(new Conexao().conexao2);
                        fbConnection.Execute(InsertCliente, cidade);
                        Console.WriteLine("Registro inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MsgErro(ex);
                    }
                }
            }
            else
            {
                Console.WriteLine("Não a novas CIDADES a ser inserida!!");
            } 

        }
        public void UpdateCidade()
        {
            List<CidadesP> cidadesP = GetListaCidadesP();
            List<CidadesS> cidadesS = GetListaCidadesS();
            List<CidadesP> Resul = new List<CidadesP>();
            try
            {
                foreach (var item in cidadesP)
                {
                    Resul.Add(item);
                }

                foreach (var itemP in cidadesP)
                {
                    foreach (var itemS in cidadesS)
                    {
                        if (itemP.CodCidade.Equals(itemS.CodCidade) && itemP.Cidade.Equals(itemS.Cidade))
                        {
                            Resul.Remove(itemP);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
        }
        private static void MsgErro(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
        }

    }
}
