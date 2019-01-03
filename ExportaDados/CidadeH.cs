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
            IEnumerable CidadeP = new FbConnection(new Conexao().conexao1).Query<CidadesP>(sqlCidade);
            List<CidadesP> listaCidades = new List<CidadesP>();
            foreach (CidadesP itemP in CidadeP)
            {
                listaCidades.Add(itemP);
            }
            return listaCidades;
        }

        public List<CidadesS> GetListaCidadesS()
        {
            IEnumerable CidadeS = new FbConnection(new Conexao().conexao2).Query<CidadesS>(sqlCidade);
            List<CidadesS> listaCidades = new List<CidadesS>();
            foreach (CidadesS itemS in CidadeS)
            {
                listaCidades.Add(itemS);
            }
            return listaCidades;
        }

        public List<dynamic> ResultCidade()
        {
            List<CidadesP> cidadesP = GetListaCidadesP();
            List<CidadesS> cidadesS = GetListaCidadesS();

            List<CidadesP> Resul = new List<CidadesP>();
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
            return Resul.Cast<dynamic>().ToList();
        }

        public void InsertCidade()
        {
            string Insert = "INSERT INTO CIDADES (CODCIDADE, CIDADE, ESTADO, CODMUNICIPIO, CODSIAFI)VALUES (@CODCIDADE, @CIDADE, @ESTADO, @CODMUNICIPIO, @CODSIAFI)";

            Conexao conexao = new Conexao();
            FbConnection fbConnection = new FbConnection(conexao.conexao2);
            CidadesS cidade = new CidadesS();
            var result = ResultCidade();

            foreach (var item in result)
            {
                if (result.Count != 0)
                {
                    try
                    {
                        cidade = new CidadesS
                        {
                            CodCidade = item.CodCidade,
                            Cidade = item.Cidade,
                            Estado = item.Estado,
                            CodMunicipio = item.CodMunicipio,
                            CodSiafi = item.CodSiafi
                        };
                        fbConnection.Execute(Insert, cidade);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
    }


}
