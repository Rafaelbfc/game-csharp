using System;
using System.Runtime;

namespace MeuProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool tipo = true;
            Random rnd = new Random();

            int numero1 = rnd.Next(20);

            while (tipo)
            {
                Console.WriteLine("Adivinhe o número entre 0 e 20: ");
                int num = int.Parse(Console.ReadLine());

                if (num == numero1)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    tipo = false;
                }
                else
                {
                    if (num != numero1)
                    {
                        if (num < numero1)
                        {
                            Console.WriteLine("O número é maior.");
                        }
                        else if (num > numero1)
                        {
                            Console.WriteLine("O número é menor.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um número válido.");
                    }

                }
            }
        }
    }
}









