using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Variaveis
{
    internal class Metodos
    {
        public static void ApresentarVariaveis()
        {
            // Declaração de variáveis
            int idade;
            idade = 19;

            string nome = "Amanda Pagani";

            double peso = 95.0;

            float altura = 1.80f;

            Console.WriteLine($"{nome} possui {idade} anos e pesa {peso:0.00} Kg e tem {altura} m de altura");
        }
        public static void LerVariaveis()
        {
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual seu peso? ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Qual a sua altura? ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} possui {idade} anos, pesa {peso:0.00} Kg e o peso é {altura}");
        }
        public static double CalcularImc(double peso, double altura)
        {
            double imc = peso / Math.Pow(altura, 2);
            return imc;
        }

        public static double CalcularValorAleatorio()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }
    }
}
