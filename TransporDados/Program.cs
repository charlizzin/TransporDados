using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace TransporDados
{
    class Program
    {
        static readonly string conexao = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ConnectionString;
        static void Main(string[] args)
        {
            using (FbConnection conn = new FbConnection(conexao))
            {
                conn.Open();
                using (FbCommand fbCmd = conn.CreateCommand())
                {
                    fbCmd.CommandText = "PGRAVACIDADE";
                    fbCmd.CommandType = CommandType.StoredProcedure;
                    fbCmd.Parameters.Add("@PCODCIDADE", FbDbType.VarChar).Value = "9805";
                    fbCmd.Parameters.Add("@PNOMECIDADE", FbDbType.VarChar).Value = "TESTE1";
                    fbCmd.Parameters.Add("@PUF", FbDbType.Char).Value = "TT";
                    fbCmd.Parameters.Add("@PCODMUNICIPIO", FbDbType.VarChar).Value = 99999;
                    fbCmd.ExecuteScalar();
                    //int result = Convert.ToInt32(fbCmd.ExecuteScalar());
                    //Console.WriteLine(result);
                }
            }
            Console.ReadKey();
        }
    }
}
