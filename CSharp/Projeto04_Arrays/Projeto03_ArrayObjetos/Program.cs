using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_ArrayObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // trabalhando com diferentes tipos
            string nome = "Gerson"; // Vários métodos de string disponiveis
            object obj = nome; // objeto da classe object pode receber valor de qualquer tipo
            // contudo, obj não tem metodos de string disponíveis.
            
            var v1 = 100;
            // v1 = 100.0; -> erro pois uma vez definido um tipo, ele deve ser respeitado

            var v2 = "123";
            var v3 = int.Parse(v2); // int v3 = 123

            // Array de tipos object
            object[] elementos = { "Futebol", 100, 100.1, true };

            foreach(var item in elementos)
            {
                Console.WriteLine($"{item} - {item.GetType()}");
            }
            Console.ReadKey();
        }
    }
}
