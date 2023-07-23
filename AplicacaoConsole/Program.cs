//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Primeiro;
using AplicacaoConsole.Entidade;
using AplicacaoConsole.Interface;
using AplicacaoConsole.Enum;

namespace AplicacaoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Amauri";
            pessoa.Idade = 39;
            pessoa.Estado = "SC";
            
            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Amauri 2";
            pessoa2.Idade = 40;
            pessoa2.Estado = "RS";

            Animal animal = new Animal();
            animal.Nome = "Loro";
            animal.NomeDono = "Amauri";
            animal.Especie = "Papagaio";

            var pessoaDoEnum1 = (Enum.Pessoas)0;
            var pessoaDoEnum2 = (Enum.Pessoas)1;

            Pessoas pessoas1 = Pessoas.Amauri;
            Pessoas pessoas2 = Pessoas.Maiara;


            var classe = new Classe();
            var classe2 = new Segundo.Classe();


            Console.WriteLine("Ola, Amauri");
        }
    }
}