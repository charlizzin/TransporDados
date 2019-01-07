using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporDados.UserInterface;
using TransporDados.DataTransferObject;
using Dapper;
using System.Collections;
using FirebirdSql.Data.FirebirdClient;

namespace TransporDados.BussinessLogicLayer
{
    public class ProdutoBLL : IProdutoUI<Produto>
    {
        private readonly string sqlProdutoP = "Select * from produto where produto.dt_cadastro = @data order by codprod";
        private readonly string sqlProdutoS = "Select * from produto where produto.dt_cadastro >= @data order by codprod";
        private readonly string dataHoje = DateTime.Today.Date.ToString("dd/MM/yyyy").Replace("/", ".");
        public List<Produto> BuscaProduto(string conexao, bool bancoPesquisa)
        {
            List<Produto> listaProduto = new List<Produto>();
            try
            {
                DefaultTypeMap.MatchNamesWithUnderscores = true;
                if (bancoPesquisa == true)
                {
                    IEnumerable produto = new FbConnection(conexao)
                        .Query<Produto>(sqlProdutoP, new { data = dataHoje });
                    foreach (Produto item in produto)
                    {
                        listaProduto.Add(item);
                    }
                }
                else
                {
                    #region dataAlvo
                    var dataHoje = DateTime.Now.Date;
                    var dataRetro = 7;
                    var dataAlvo = dataHoje.AddDays(-dataRetro).ToString("dd/MM/yyyy").Replace("/", ".");
                    #endregion
                    IEnumerable produto = new FbConnection(conexao).Query<Cliente>(sqlProdutoS, new { data = dataAlvo });
                    foreach (Produto item in produto)
                    {
                        listaProduto.Add(item);
                    }
                }

            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            return listaProduto;
        }

        public List<Produto> ComparaBusca(List<Produto> ProdutoP, List<Produto> ProdutoS)
        {
            List<Produto> listaResultadoProduto = new List<Produto>();
            try
            {
                foreach (var item in ProdutoP)
                {
                    listaResultadoProduto.Add(item);
                }
                foreach (var itemP in ProdutoP)
                {
                    foreach (var itemS in ProdutoS)
                    {
                        if (itemP.Codprod.Equals(itemS.Codprod))
                        {
                            listaResultadoProduto.Remove(itemP);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            return listaResultadoProduto;
        }

        public void InserirProduto()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduto()
        {
            throw new NotImplementedException();
        }
        public static void MsgErro(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
        }

    }
}
