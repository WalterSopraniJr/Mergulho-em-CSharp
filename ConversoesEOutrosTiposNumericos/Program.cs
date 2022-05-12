using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4 - Conversão e outros tipos numéricos");
            Console.WriteLine("-----------------------------------");


            double salario = 1200.50;

            int salarioEmInteiro; //32 bits de memoria
            salarioEmInteiro = (int)salario; //casting de variavel

            Console.WriteLine(salario);
            Console.WriteLine(salarioEmInteiro);


            long valorGigante = 1000000000000000; // 64 bits de memória
            Console.WriteLine(valorGigante);

            short quantidadeProdutos = 150; //16 bits de memoria
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.76f; //baixa precisão, é necessário colocar o 'f'. Não é usual utilizar o float.
            Console.WriteLine(altura);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
