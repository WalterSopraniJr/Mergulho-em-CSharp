using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6 - Atribuições de Variáveis");
            Console.WriteLine("-----------------------------------");

            int idade = 10;
            int minhaIdade = idade;

            idade = 26;

            Console.WriteLine(idade); 
            Console.WriteLine(minhaIdade);


            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
