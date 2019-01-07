using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using FirebirdSql.Data.FirebirdClient;
using Dapper.Contrib.Extensions;

namespace TransporDados
{
    public class CidadeBLL : ICidadeUI<Cidades>
    {
        public List<Cidades> BuscaCidade(string conexao)
        {
            List<Cidades> listaCidade = new List<Cidades>();
            string sqlCidade = "Select * from cidades order by codcidade";
            try
            {
                IEnumerable cidade = 
                    new FbConnection(conexao)
                    .Query<Cidades>(sqlCidade);
                foreach (Cidades item in cidade)
                {
                    listaCidade.Add(item);
                }
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            return listaCidade;
        }
        public List<Cidades> ComparaBusca(List<Cidades> cidadeP, List<Cidades> CidadeS, bool ComparaDesc)
        {
            List<Cidades> listaResultadoCidade = new List<Cidades>();
            try
            {
                foreach (var item in cidadeP)
                {
                    listaResultadoCidade.Add(item);
                }
                if (ComparaDesc == true)
                {
                    foreach (var itemP in cidadeP)
                    {
                        foreach (var itemS in CidadeS)
                        {
                            if (itemP.CodCidade.Equals(itemS.CodCidade) && itemP.Cidade.Equals(itemS.Cidade))
                            {
                                listaResultadoCidade.Remove(itemP);
                                break;
                            }
                        }
                    }
                }
                if (ComparaDesc == false)
                {
                    foreach (var itemP in cidadeP)
                    {
                        foreach (var itemS in CidadeS)
                        {
                            if (itemP.CodCidade.Equals(itemS.CodCidade))
                            {
                                listaResultadoCidade.Remove(itemP);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            return listaResultadoCidade;
        }
        public void InserirCidade()
        {
            var listaCidade = ComparaBusca(
                                            new CidadeBLL().BuscaCidade(new Conexao().conexao1),
                                            new CidadeBLL().BuscaCidade(new Conexao().conexao2),
                                            false);
            if (listaCidade.Count != 0)
            {
                try
                {
                    Console.WriteLine("Inserindo os registros: ");
                    foreach (var item in listaCidade)
                    {
                        Console.WriteLine("         " + item.CodCidade + " - " + item.Cidade);
                    }
                    new FbConnection(
                        new Conexao().conexao2)
                        .Insert(listaCidade);
                    Console.WriteLine("Registros inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MsgErro(ex);
                }
            }
            else
            {
                Console.WriteLine("Nao existe novos CIDADES!!!!");
            }
        }
        public void UpdateCidade()
        {
            string sqlUpdate = "UPDATE CIDADES SET CIDADE = @CIDADE WHERE (CODCIDADE = @CODCIDADE);";
            var listaAtual = ComparaBusca(
                                BuscaCidade(new Conexao().conexao1),
                                BuscaCidade(new Conexao().conexao2), true)
                                .Cast<dynamic>().ToList();
            if (listaAtual.Count != 0)
            {
                try
                {
                    foreach (var item in listaAtual)
                    {
                        Console.WriteLine("Atualizando a cidade: " + item.CodCidade + " - " + item.Cidade);
                        new FbConnection(
                            new Conexao().conexao2)
                            .Execute(sqlUpdate, new Cidades
                            {
                                CodCidade = item.CodCidade,
                                Cidade = item.Cidade
                            });
                        Console.WriteLine("Cidade atualizada!!");
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
