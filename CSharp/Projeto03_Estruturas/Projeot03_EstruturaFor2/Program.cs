using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeot03_EstruturaFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste exercício, o usuário fornece 10 números inteiros. O programa apresenta a soma dos números
             * positivos.
             * 
             * Objetivo: Apresentar o comando CONTINUE.
             */

            int soma = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Informe o valor {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                
                if(numero <= 0)
                {
                    continue;
                }
                soma += numero;
            }
            Console.WriteLine($"A soma dos valores positivos é: {soma}");
            Console.ReadKey();
        }
    }
}
