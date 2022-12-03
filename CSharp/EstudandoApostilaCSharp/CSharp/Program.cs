using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // com ? é possivel atribuir null para variaveis tipo valor
            // <variavel> ?? <valor> => Operador de coalência nula
            int? idade = null;
            Console.WriteLine($"Idade: {idade ?? 0}");

            // <variavel> ??= <valor> => atribuição de união nula (disponivel no C# 8.0) 
            string curso = null;
            curso ??= "Curso não informado";
            Console.ReadKey();
        }
    }
}
