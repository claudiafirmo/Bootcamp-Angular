using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_Estruturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Variaveis do C# X Variaveis do Framework
             * 
             * Os tipos do C# possuem tipos análogos no Framework
             * No processo de compilação, os tipos considerados primitivos
             * são convertidos nos tipos do framework.
             */
            int x1 = 100;
            Int32 x2 = 100;

            double d1 = 1.5;
            Double d2 = 1.5;

            string s1 = "texto";
            String s2 = "texto";

            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
