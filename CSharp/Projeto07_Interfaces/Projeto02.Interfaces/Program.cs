using ClassesObjetos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura figura = new Retangulo()
            {
                Altura = 10, Base = 5
            };

            Console.WriteLine($"Área: {figura.CalcularArea()}");

            figura = new Circulo()
            {
                Raio = 10
            };
            Console.WriteLine($"Área: {figura.CalcularArea():00.00}");
            Console.ReadKey();

        }
    }
}
