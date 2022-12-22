using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste projeto definiremos uma quantidade de elementos para um array de nomes.
             * A quantidade  será informada pelo usuário. Em seguida, o programa:
             * 
             * - solicita o valor para cada um dos nomes
             * - os nomes armazenados serão exibidos em maiusculo
             */

            Console.Write("Informe a quantidade de nomes: ");
            int qtd = int.Parse(Console.ReadLine());

            string[] nomes = new string[qtd];

            for(int i= 0; i < nomes.Length; i++)
            {
                Console.Write($"{i + 1}° nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Lista de nomes informados: ");
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome.ToUpper());
            }

            // Definindo dias da semana
            string[] diasSemana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            foreach(string dia in diasSemana)
            {
                Console.WriteLine(dia);
            }
            Console.ReadKey();
        }
    }
}
