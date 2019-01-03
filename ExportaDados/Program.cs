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
            ProdutoRepository produtoRepository = new ProdutoRepository();
            produtoRepository.InsertProduto();
            Console.ReadKey();
        }
    }
}
