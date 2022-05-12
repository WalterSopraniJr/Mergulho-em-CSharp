using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variáveis");

            string nome = "Walter"; 
            string sobrenome = "Soprani Júnior";
            int idade = 26;
            string celular = "(11) 93232-3232";
            string profissao = "Programador";

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Olá, " + nome + ". Seja bem vindo!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Dados do cadastro:");
            Console.WriteLine("Nome: " + nome + sobrenome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Profissao: " + profissao);
            Console.WriteLine("Celular: " + celular);




            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine(); 
        }
    }
}
