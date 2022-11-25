using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_EstruturaWhile02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * O usuário oferece uma certa quantidade de números.
             * Se o número informado for negativo, será ignorado.
             * Se o número informado for positivo, será somado.
             * Se o número informado for 0, o programa termina.
             */
            int soma = 0;
            while (true)
            {
                Console.Write("Informe um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());
                if(numero < 0)
                {
                    continue;
                }
                if(numero == 0)
                {
                    break;
                }
                soma += numero;
            }
            Console.WriteLine($"Soma dos valores positivos: {soma}");
            Console.ReadKey();
        }
    }
}
