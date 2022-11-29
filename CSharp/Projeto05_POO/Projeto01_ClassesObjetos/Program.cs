using ClassesObjetos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciando a classe pessoa e fazendo com que a variável p1 referencie essa instancia
            Pessoa p1 = new Pessoa();
            p1.Nome = "Amanda";
            p1.Idade = 19;

            // Atribuindo referencias: A variavel p2 referencia o mesmo objeto referenciado pela variavel p1
            Pessoa p2 = p1;
            p2.Idade = 20;

            Console.WriteLine(p2.Equals(p1));

            Console.WriteLine($"Nome informado: {p1.Nome}\nIdade informada: {p1.Idade}");
            Console.ReadKey();
        }
    }
}
