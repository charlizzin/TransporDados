using System;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
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
            CidadeRespository cidadeRespository = new CidadeRespository();
            cidadeRespository.UpdateCidade();
            Timer t = new Timer(TimerCallback, null, 0, 180000);
            Console.ReadKey();
        }
        private static void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Executado as : " + DateTime.Now);
            CidadeRespository cidadeRespository = new CidadeRespository();
            cidadeRespository.InsertCidade();
            ClienteRepository clienteRepository = new ClienteRepository();
            clienteRepository.InsertCliente();
            ProdutoRepository produtoRepository = new ProdutoRepository();
            produtoRepository.InsertProduto();
            Console.WriteLine();
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }
    }
}
