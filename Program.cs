using System;

namespace olausuario
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;

            //<---Inicio(Digite--->//
            Console.Write("Digite Seu Nome: ");
            nome = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine($"Olá, {nome}!");
            Console.WriteLine("PRESSIONE ENTER PARA SAIR");
            Console.ReadKey();
        }

    }
}
