using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodos.ApresentarVariaveis();
            //MostrarCurso();
            //Metodos.LerVariaveis();
            
            Console.Write("Informe o peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe altura: ");
            double altura = double.Parse(Console.ReadLine());

            //double imc = Metodos.CalcularImc(peso, altura);
            Console.WriteLine($"Altura: {altura}, peso {peso}. Seu IMC é {Metodos.CalcularImc(peso, altura):0.00}");

            Console.WriteLine($"Número gerado: {Metodos.CalcularValorAleatorio()}");
            Console.WriteLine($"Número gerado: {Metodos.CalcularValorAleatorio()}");
            Console.WriteLine($"Número gerado: {Metodos.CalcularValorAleatorio()}");
            Console.WriteLine($"Número gerado: {Metodos.CalcularValorAleatorio()}");

            Console.ReadKey();
        }
        static void MostrarCurso()
        {
            Console.WriteLine("Cursos da semana:");
            Console.WriteLine("Linguagem C#");
            Console.WriteLine("Python");
        }
    }
}
