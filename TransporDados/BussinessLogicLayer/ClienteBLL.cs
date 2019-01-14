using System;
using System.Collections;
using System.Collections.Generic;
using Dapper;
using FirebirdSql.Data.FirebirdClient;
using Dapper.Contrib.Extensions;
using TransporDados.DataTransferObject;
using TransporDados.UserInterface;

namespace TransporDados.BussinessLogicLayer
{
    public class ClienteBLL : IClienteUI<Cliente>
    {
        private readonly string sqlClienteP = "Select * from cliente where cliente.dt_cadastro = @data order by codcliente";
        private readonly string sqlClienteS = "Select * from cliente where cliente.dt_cadastro >= @data order by codcliente";
        private readonly string dataHoje = DateTime.Today.Date.ToString("dd/MM/yyyy").Replace("/", ".");
        public List<Cliente> BuscaCliente(string conexao, bool bancoPesquisa)
        {
            List<Cliente> listaCliente = new List<Cliente>();
            try
            {
                DefaultTypeMap.MatchNamesWithUnderscores = true;
                if (bancoPesquisa == true)
                {
                    IEnumerable cliente = new FbConnection(conexao)
                        .Query<Cliente>(sqlClienteP, new { data = dataHoje });
                    foreach (Cliente item in cliente)
                    {
                        listaCliente.Add(item);
                    }
                }
                else
                {
                    #region dataAlvo
                    var dataHoje = DateTime.Now.Date;
                    var dataRetro = 7;
                    var dataAlvo = dataHoje.AddDays(-dataRetro).ToString("dd/MM/yyyy").Replace("/", ".");
                    #endregion
                    IEnumerable ClienteS = new FbConnection(conexao).Query<Cliente>(sqlClienteS, new { data = dataAlvo });
                    foreach (Cliente itemS in ClienteS)
                    {
                        listaCliente.Add(itemS);
                    }
                }

            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            return listaCliente;
        }

        public List<Cliente> ComparaBusca(List<Cliente> clienteP, List<Cliente> ClienteS)
        {
            List<Cliente> listaResultadoCliente = new List<Cliente>();
            try
            {
                foreach (var item in clienteP)
                {
                    listaResultadoCliente.Add(item);
                }
                foreach (var itemP in clienteP)
                {
                    foreach (var itemS in ClienteS)
                    {
                        if (itemP.Codcliente.Equals(itemS.Codcliente))
                        {
                            listaResultadoCliente.Remove(itemP);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgErro(ex);
            }
            return listaResultadoCliente;
        }

        public void InserirCliente()
        {
            var listaCliente = ComparaBusca(
                                new ClienteBLL().BuscaCliente(new Conexao().conexao1, true),
                                new ClienteBLL().BuscaCliente(new Conexao().conexao2, false));
            if (listaCliente.Count != 0)
            {
                try
                {
                    Console.WriteLine(" Inserindo os registros: ");
                    foreach (var item in listaCliente)
                    {
                        Console.WriteLine("         " + item.Codcliente + " - " + item.Nome);
                    }
                    new FbConnection(
                        new Conexao().conexao2)
                        .Insert(listaCliente);
                }
                catch (Exception ex)
                {
                    MsgErro(ex);
                }
            }
            else
            {
                Console.WriteLine(" Nao existe novos CLIENTES!!");
            }
        }

        public void UpdateCliente()
        {
            throw new NotImplementedException();
        }
        public static void MsgErro(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.Green;
        }

    }
}
