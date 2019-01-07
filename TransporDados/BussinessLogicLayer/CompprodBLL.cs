using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporDados.UserInterface;
using TransporDados.DataTransferObject;
using System.Collections;
using FirebirdSql.Data.FirebirdClient;
using Dapper;

namespace TransporDados.BussinessLogicLayer
{
    public class CompprodBLL : ICompprodUI<CompProd>
    {
        private readonly string sqlCompProd = "Select * from compprod where datacustocalc = @datacustocalc and codempresa = '00' order by codprod";
        private readonly string dataHoje = DateTime.Today.Date.ToString("dd/MM/yyyy").Replace("/", ".");
        public List<CompProd> BuscaCompprod(string conexao)
        {
            List<CompProd> listaCompProd = new List<CompProd>();
            try
            {
                IEnumerable compprod =
                    new FbConnection(conexao)
                    .Query<CompProd>(sqlCompProd, new { datacustocalc = dataHoje });
                foreach (CompProd item in compprod)
                {
                    listaCompProd.Add(item);
                }
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            return listaCompProd;
        }

        public List<CompProd> ComparaBusca(List<CompProd> compprodP, List<CompProd> compprodS)
        {
            throw new NotImplementedException();
        }

        public void InserirCompprod()
        {
            throw new NotImplementedException();
        }

        public void UpdateCompprod()
        {
            string sqlUpdate = "UPDATE COMPPROD SET PRECOCUSTO = @PRECOCUSTO, DATACUSTOCALC = @DATACUSTOCALC WHERE (CODPROD = @CODPROD)";
            var listaAtual = BuscaCompprod(new Conexao().conexao1);

            if (listaAtual.Count != 0)
            {
                try
                {
                    foreach (var item in listaAtual)
                    {
                        new FbConnection(
                            new Conexao().conexao2)
                            .Execute(sqlUpdate, new CompProd
                            {
                                Precocusto = item.Precocusto,
                                Datacustocalc = item.Datacustocalc,
                                Codprod = item.Codprod
                            });
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static void MsgErro(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
        }
    }
}
