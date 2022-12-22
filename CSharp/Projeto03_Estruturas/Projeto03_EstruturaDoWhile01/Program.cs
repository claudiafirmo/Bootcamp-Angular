using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_EstruturaDoWhile01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor entre 0 e 10: ");
            int numero = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"Número: {numero}");
                numero++;
            } while (numero < 5);

                Console.WriteLine("FIM DO PROGRAMA!");
            Console.ReadKey();
        }
    }
}
