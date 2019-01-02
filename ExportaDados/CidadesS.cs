using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace ExportaDados
{
    public class CidadesS
    {
        public string CodCidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CodMunicipio { get; set; }
        public string CodSiafi { get; set; }

        public IEnumerable<CidadesP> CidadesPs { get; set; }
        //public List<dynamic> Result()
        //{
        //    Conexao conexao = new Conexao();

        //    FbConnection fbConnection1 = new FbConnection(conexao.conexao1);
        //    FbConnection fbConnection2 = new FbConnection(conexao.conexao2);
        //    List<dynamic> result1 = fbConnection1.Query("Select * from cidades order by codcidade").ToList();
        //    List<dynamic> result2 = fbConnection2.Query("Select * from cidades order by codcidade").ToList();
        //    List<dynamic> result3 = fbConnection1.Query("Select * from cidades order by codcidade").ToList();

        //    for (int i = 0; i < result1.Count; i++)
        //    {
        //        dynamic item1 = (dynamic)result1[i];
        //        for (int j = 0; j < result2.Count; j++)
        //        {
        //            dynamic item2 = (dynamic)result2[j];
        //            if (System.Convert.ToInt32(item1.CODCIDADE) < System.Convert.ToInt32(item2.CODCIDADE))
        //                break;
        //            if (System.Convert.ToInt32(item1.CODCIDADE) == System.Convert.ToInt32(item2.CODCIDADE))
        //            {
        //                result3.Remove(item1);
        //                break;
        //            }
        //        }
        //    }
        //    return result3;
        //}
    }
}
