using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_EstruturaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste exercício o usuário fornecerá uma quantidade de números. Em seguida ele digitará
             * alguns números inteiros (a quantidade de números digitados é a quantidade informada).
             * 
             * Ao final o programa apresenta a soma destes números.
             */
            
            Console.Write("Informe a quantidade de números (entre 1 e 10): ");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade < 1 || quantidade > 10)
            {
                Console.WriteLine("Quantidade inválida! Deve ser entre 1 e 10");
            }
            else
            {
                int soma = 0;
                for(int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Informe o {i + 1}° número: ");
                    soma += int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"A soma é {soma}");
            }
            Console.ReadKey();
        }
    }
}
