using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_ComandoDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Neste exercício, o usuário fornece um valor para saque.
             * (Simulação de caixa eletrônico).
             * As cédulas disponíveis são: 
             * R$ 50,00
             * R$ 20,00
             * R$ 10,00
             * R$ 5,00
             * 
             * Com base nessas informações, o programa deve apresentar
             * a quantidade de cédulas de acordo com o valor do saque.
             */

            Console.Write("Informe o valor a ser sacado: ");
            double valor = double.Parse(Console.ReadLine());

            // Obtendo a parte inteira da variável 'valor': typecast (!= conversão)
            int valorSaque = (int)valor;

            // int q50 = 0, q20 = 0, q10 = 0, q5 = 0;
            int q50, q20, q10, q5;
            q50 = q20 = q10 = q5 = 0; // atribuição simultanea

            if (valorSaque % 5 != 0)
            {
                Console.WriteLine("Valor inválido para saque");
                //Console.ReadKey();
                //return; // é possivel no metodo main. Em todo void é possivel usar.
            }
            else { 

            q50 = valorSaque / 50;
            valorSaque %= 50;

            q20 = valorSaque / 20;
            valorSaque %= 20;

            q10 = valorSaque / 10;
            valorSaque %= 10;

            q5 = valorSaque / 5;
                                                // currency -> valor monetario
            string resposta = $"Valor do saque: {valor:c}\nNotas de 50: {q50}\n" + 
                $"Notas de 20: {q20}\nNotas de 10: {q10}\nNotas de 5: {q5}";
            Console.WriteLine(resposta);
            }
            Console.ReadKey();
        }
    }
}
