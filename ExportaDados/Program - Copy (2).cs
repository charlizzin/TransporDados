//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FirebirdSql.Data.FirebirdClient;
//using Dapper;
//using System.Data;
//using System.Configuration;

//namespace ExportaDados
//{
//    class Program
//    {
//        static readonly string Insert = "INSERT INTO CIDADES (CODCIDADE, CIDADE, ESTADO, CODMUNICIPIO, CODSIAFI)VALUES (@CODCIDADE, @CIDADE, @ESTADO, @CODMUNICIPIO, @CODSIAFI)";
//        static readonly string conexao = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ConnectionString;
//        static void Main(string[] args)
//        {
//            using (FbConnection conn = new FbConnection(conexao))
//            {
//                conn.Open();
//                var resulCidade = conn.Query("Select * from cidades").ToList();
//                CidadesP cidade = new CidadesP();
//                foreach (dynamic item in resulCidade)
//                {
//                    try
//                    {
//                        cidade = new CidadesP
//                        {
//                            CodCidade = item.CODCIDADE,
//                            Cidade = item.CIDADE,
//                            Estado = item.ESTADO,
//                            CodMunicipio = item.CODMUNICIPIO,
//                            CodSiafi = item.CODSIAFI
//                        };
//                        conn.Execute(Insert, cidade);
//                    }
//                    catch (Exception)
//                    {
//                    }
//                }
//                conn.Close();
//            }
//            Console.ReadKey();
//        }
//    }
//}
