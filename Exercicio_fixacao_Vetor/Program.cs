using System;

namespace Exercicio_fixacao_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("");

                quartos[quarto] = new Quarto { Nome = nome, Email = email };

            }
            Console.WriteLine("\nQuartos Ocupados:");
            for (int i = 0; i < 10; i++)
            {

                if (quartos[i] != null)
                {
                    
                    Console.WriteLine(i + ": " + quartos[i]);
                }
                else
                {
                   //Console.WriteLine(i);
                }
            }
        }
    }
}
