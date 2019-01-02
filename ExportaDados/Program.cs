using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using Dapper;
using System.Data;
using System.Configuration;
using System.Collections;

namespace ExportaDados
{
    class Program
    {
        static readonly string Insert = "INSERT INTO CIDADES (CODCIDADE, CIDADE, ESTADO, CODMUNICIPIO, CODSIAFI)VALUES (@CODCIDADE, @CIDADE, @ESTADO, @CODMUNICIPIO, @CODSIAFI)";
        static readonly string conexao1 = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ConnectionString;
        static readonly string conexao2 = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ConnectionString;
        static void Main(string[] args)
        {
            FbConnection fbConnectionP = new FbConnection(conexao1);
            FbConnection fbConnectionS = new FbConnection(conexao2);
            IEnumerable cidadesP1 = fbConnectionP.Query<CidadesP>("Select * from cidades order by codcidade");
            IEnumerable cidadesP2 = fbConnectionS.Query<CidadesS>("Select * from cidades order by codcidade");
            IEnumerable cidadesP3 = fbConnectionP.Query<CidadesP>("Select * from cidades order by codcidade");

            List<CidadesP> cidadesPs = new List<CidadesP>();
            foreach (CidadesP item in cidadesP1)
            {
                cidadesPs.Add(item);
            }


            Console.ReadKey();
        }
    }
}
