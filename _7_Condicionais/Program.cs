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

            int idade = 16;
            int quantidadePessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("voce nao tem 18, mas pode entrar, pois está acompanhado");

                }
                else
                {
                    Console.WriteLine("infelizmente voce nao pode entrar");
                }

            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
