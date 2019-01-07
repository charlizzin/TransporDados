using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporDados.UserInterface;
using TransporDados.DataTransferObject;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections;
using FirebirdSql.Data.FirebirdClient;

namespace TransporDados.BussinessLogicLayer
{
    public class ProdutoBLL : IProdutoUI<Produto>
    {
        private readonly string sqlProdutoP = "Select * from produto where produto.dt_cadastro = @data order by codprod";
        private readonly string sqlProdutoS = "Select * from produto where produto.dt_cadastro >= @data order by codprod";
        private readonly string sqlProdutoU = "Select * from produto where produto.data_ult_alteracao = @data order by codprod";
        private readonly string dataHoje = DateTime.Today.Date.ToString("dd/MM/yyyy").Replace("/", ".");
        public List<Produto> BuscaProduto(string conexao, bool bancoPesquisa, string sqlProduto)
        {
            List<Produto> listaProduto = new List<Produto>();
            try
            {
                DefaultTypeMap.MatchNamesWithUnderscores = true;
                if (bancoPesquisa == true)
                {
                    IEnumerable produto = new FbConnection(conexao)
                        .Query<Produto>(sqlProduto, new { data = dataHoje });
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
                    IEnumerable produto = new FbConnection(conexao).Query<Produto>(sqlProduto, new { data = dataAlvo });
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
            var listaProduto = ComparaBusca(
                    new ProdutoBLL().BuscaProduto(new Conexao().conexao1, true, sqlProdutoP),
                    new ProdutoBLL().BuscaProduto(new Conexao().conexao2, false, sqlProdutoS));
            if (listaProduto.Count != 0)
            {
                try
                {
                    Console.WriteLine("Inserindo os registros: ");
                    foreach (var item in listaProduto)
                    {
                        Console.WriteLine("         " + item.Codprod + " - " + item.Descricao);
                    }
                    new FbConnection(
                        new Conexao().conexao2)
                        .Insert(listaProduto);
                    Console.WriteLine("Registros inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MsgErro(ex);
                }
            }
            else
            {
                Console.WriteLine("Nao existe novos PRODUTOS!!");
            }
        }

        public void UpdateProduto()
        {
            string sqlUpdate = "UPDATE PRODUTO SET DESCRICAOPRECO = @DESCRICAOPRECO, PRECO = @PRECO, " +
                " DESCRICAOPRECO2 = @DESCRICAOPRECO2, PRECO2 = @PRECO2, DESCRICAOPRECO3 = @DESCRICAOPRECO3, PRECO3 = @PRECO3," +
                " DESCRICAOPRECO4 = @DESCRICAOPRECO4, PRECO4 = @PRECO4 WHERE (DATA_ULT_ALTERACAO = @DATA_ULT_ALTERACAO)";
            var listaAtual = BuscaProduto(
                new Conexao().conexao1, true,sqlProdutoU)
                .Cast<dynamic>().ToList();
            if (listaAtual.Count != 0)
            {
                try
                {
                    foreach (var item in listaAtual)
                    {
                        Console.WriteLine("Atualizando o produto: " + item.Codprod + " - " + item.Descricao);
                        new FbConnection(
                            new Conexao().conexao2)
                            .Execute(sqlUpdate, new Produto
                            {
                                Descricaopreco = item.Descricaopreco,
                                Preco = item.Preco,
                                Descricaopreco2 = item.Descricaopreco2,
                                Preco2 = item.Preco2,
                                Descricaopreco3 = item.Descricaopreco3,
                                Preco3 = item.Preco3,
                                Descricaopreco4 = item.Descricaopreco4,
                                Preco4 = item.Preco4,
                                Data_ult_alteracao = item.Data_ult_alteracao
                            });
                        Console.WriteLine("Produto atualizada!!");
                    }
                }
                catch (Exception ex)
                {
                    MsgErro(ex);
                }
            }
            else
            {
                Console.WriteLine("Nao possui registros para atualizacao!!");
            }
        }
        public static void MsgErro(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
        }

    }
}
