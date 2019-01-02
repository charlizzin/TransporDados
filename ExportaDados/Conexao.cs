using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;

namespace ExportaDados
{
    public class Conexao
    {
        public readonly string conexao1 = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ConnectionString;
        public readonly string conexao2 = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ConnectionString;

        public FbConnection GetFbConnection1()
        {
            FbConnection fbConnection = new FbConnection(conexao1);
            if (fbConnection.State == System.Data.ConnectionState.Closed)
            {
                fbConnection.Open();
            }
            return fbConnection;
        }

        public FbConnection GetFbConnection2()
        {
            FbConnection fbConnection = new FbConnection(conexao2);
            if (fbConnection.State == System.Data.ConnectionState.Closed)
            {
                fbConnection.Open();
            }
            return fbConnection;
        }
    }
}
