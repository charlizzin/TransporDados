using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using Dapper;
using System.Data;
using System.Configuration;

namespace ExportaDados
{
    //class Program
    //{
    //    static readonly string Insert = "INSERT INTO CIDADES (CODCIDADE, CIDADE, ESTADO, CODMUNICIPIO, CODSIAFI)VALUES (@CODCIDADE, @CIDADE, @ESTADO, @CODMUNICIPIO, @CODSIAFI)";
    //    static readonly string conexao = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ConnectionString;
    //    static void Main(string[] args)
    //    {
    //        using (FbConnection conn = new FbConnection(conexao))
    //        {
    //            conn.Open();
    //            var resulCidade = conn.Query("Select * from cidades").ToList();
    //            foreach (dynamic item in resulCidade)
    //            {
    //                Cidade cidade = new Cidade();
    //                cidade.CodCidade = item.CODCIDADE;
    //                cidade.NomeCidade = item.CIDADE;
    //                cidade.Estado = item.ESTADO;
    //                cidade.CodMunicipio = item.CodMunicipio;
    //                cidade.CodSiafi = item.CodSiafi;
    //            }
    //            var a = conn.Execute(Insert, new
    //            {
    //                @CodCidade = "09810",
    //                @Cidade = "TESTE",
    //                @Estado = "TT",
    //                @CodMunicipio = "99999",
    //                @CodSiafi = ""
    //            });
    //            conn.Close();
    //            var b = conn.Query<Cidade>("Select * from cidades where codcidade = '09810'").ToList();
    //            Console.WriteLine(b);
    //        }
    //        Console.ReadKey();
    //    }
    //}
}
