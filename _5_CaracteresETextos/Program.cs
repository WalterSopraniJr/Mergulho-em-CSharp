using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 - Caracteres e textos");
            Console.WriteLine("-----------------------------------");

            char primeiraLetra = 'a';
            Console.WriteLine("A letra > " + primeiraLetra + " < foi declarada como 'char' que por sua vez tem apenas 1 byte de memória.");

            primeiraLetra = (char)65;
            Console.WriteLine("A letra > " + primeiraLetra + " < é o endereço de memória 65.");

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("A letra > " + primeiraLetra + " < é o endereço de memória 66.");

            String texto = "String é o tipo usado para representação de texto.";
            Console.WriteLine(texto);

            String lista = @"String
             com o @
             na frente
             mantém a formatação.";
            Console.WriteLine(lista);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
