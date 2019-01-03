using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace ExportaDados
{
    public class CidadesS1
    {
        public string CodCidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CodMunicipio { get; set; }
        public string CodSiafi { get; set; }
    }
}
