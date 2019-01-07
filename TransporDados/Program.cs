using System;
using TransporDados.BussinessLogicLayer;

namespace TransporDados
{
    class Program
    {
        static void Main(string[] args)
        {
            new ClienteBLL().InserirCliente();
            Console.ReadKey();
        }
    }
}
