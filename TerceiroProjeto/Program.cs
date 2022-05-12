using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 - Criando Variáveis Ponto Flutuante");
            Console.WriteLine("-----------------------------------");

            double salario = 1193.37;

            Console.WriteLine("O salário mínimo atual é de R$" + salario);
            Console.WriteLine("-----------------------------------");

            double valor;
            valor = 15.0 / 2;
            Console.WriteLine("Valor = " + valor);
            Console.WriteLine("-----------------------------------");


            valor = 5 / 3;
            Console.WriteLine("Valor de 5/3 = " + valor);
            Console.WriteLine("Pelo 5 estar sem o .0 as casas decimais são ignoradas");
            Console.WriteLine("-----------------------------------");

            valor = 5.0 / 3;
            Console.WriteLine("Valor de 5.0/3 = " + valor);
            Console.WriteLine("Casas decimais incluídas pelo 5 ter o .0");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
