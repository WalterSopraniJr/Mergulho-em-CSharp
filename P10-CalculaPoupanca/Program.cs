using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");
            Console.WriteLine("-----------------------------------");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido -= valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

                contadorMes++;
            }


            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
