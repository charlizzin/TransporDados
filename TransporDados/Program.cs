using System;
using System.Threading;
using TransporDados.BussinessLogicLayer;

namespace TransporDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer insert = new Timer(TimerCallbackInsert, null, 0, 900000);
            Timer update = new Timer(TimerCallbackUpdate, null, 0, 1800000);
            Console.ReadKey();
        }
        private static void TimerCallbackInsert( Object obj)
        {
            // Display the date/time when this method got called.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Executado as : " + DateTime.Now);
            new CidadeBLL().InserirCidade();
            new ClienteBLL().InserirCliente();
            new ProdutoBLL().InserirProduto();
            Console.WriteLine();
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }
        private static void TimerCallbackUpdate(Object obj)
        {
            // Display the date/time when this method got called.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Executado as : " + DateTime.Now);
            new CidadeBLL().UpdateCidade();
            //new ClienteBLL().UpdateCliente();
            new ProdutoBLL().UpdateProduto();
            new CompprodBLL().UpdateCompprod();
            Console.WriteLine();
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }
    }
}
