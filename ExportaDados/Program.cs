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
        static void Main(string[] args)
        {
            CidadesP cidades = new CidadesP();
            cidades.InsertCidade();

            #region
            //FbConnection fbConnectionP = new FbConnection(conexao1);
            //FbConnection fbConnectionS = new FbConnection(conexao2);
            //IEnumerable cidadesP1 = fbConnectionP.Query<CidadesP>("Select * from cidades order by codcidade");
            //IEnumerable cidadesP2 = fbConnectionS.Query<CidadesS>("Select * from cidades order by codcidade");

            //List<CidadesP> cidadesPs = new List<CidadesP>();
            //List<CidadesP> cidadesP3 = new List<CidadesP>();
            //foreach (CidadesP itemP in cidadesP1)
            //{
            //    cidadesPs.Add(itemP);
            //    cidadesP3.Add(itemP);
            //}

            //List<CidadesS> cidadesS = new List<CidadesS>();
            //foreach (CidadesS itemS in cidadesP2)
            //{
            //    cidadesS.Add(itemS);
            //}

            //foreach (var item1 in cidadesPs)
            //{
            //    foreach (var item2 in cidadesS)
            //    {
            //        if (item1.CodCidade.Equals(item2.CodCidade))
            //        {
            //            cidadesP3.Remove(item1);
            //            break;
            //        }
            //    }
            //}
            #endregion
            Console.ReadKey();
        }
    }
}
