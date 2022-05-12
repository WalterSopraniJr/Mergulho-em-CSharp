using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");
            Console.WriteLine("-----------------------------------");

            int idadeJoao = 16;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade.");
            } else
            {
                Console.WriteLine("João ainda é menor de idade");
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
