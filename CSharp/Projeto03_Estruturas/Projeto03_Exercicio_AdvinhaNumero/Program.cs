using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Exercicio_AdvinhaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste exercicio, o programa gera um numero aleatorio entre 1 e 100.
             * Depois disso, iterativamente, o programa pede para o usuário fornecer um valor.
             * O programa ajusta os limites minimo e máximo, até que o usuario acerte o numero.
             */
            Random random = new Random();
            int min = 1; int max = 100;
            int numero = random.Next(min, max);
            int tentativas = 0;

            while (true)
            {
                tentativas++;

                string mensagem = min == max ? $"Informe o valor {min}: " : $"Informe um valor entre {min} e {max}: ";

                Console.Write(mensagem);
                int palpite = int.Parse(Console.ReadLine());

                if(palpite > max || palpite < min)
                {
                    continue;
                }

                if(palpite > numero)
                {
                    max = palpite - 1;
                } else if(palpite < numero)
                {
                    min = palpite + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Você acertou em {tentativas} tentativas!");
            Console.ReadKey();
        }
    }
}
