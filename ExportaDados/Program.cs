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
            Timer t = new Timer(TimerCallback, null, 0, 180000);
            #region teste
            //var handle = GetConsoleWindow();

            //// Hide
            //ShowWindow(handle, SW_HIDE);

            // Show
            //ShowWindow(handle, SW_SHOW);
            // Create a Timer object that knows to call our TimerCallback
            // method once every 2000 milliseconds.
            // Wait for the user to hit <Enter>
            //Console.ReadLine();
            //CidadeRespository cidadeRespository = new CidadeRespository();
            //cidadeRespository.InsertCidade();
            //ClienteRepository clienteRepository = new ClienteRepository();
            //clienteRepository.InsertCliente();
            //ProdutoRepository produtoRepository = new ProdutoRepository();
            //produtoRepository.InsertProduto();
            #endregion


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
        //[DllImport("kernel32.dll")]
        //static extern IntPtr GetConsoleWindow();
        //[DllImport("user32.dll")]
        //static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        //const int SW_HIDE = 0;
        //const int SW_SHOW = 5;
    }
}
