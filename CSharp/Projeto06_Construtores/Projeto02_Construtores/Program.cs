using ClassesObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("Pedagogia", 100);

            Console.WriteLine(curso.LerCurso());
            Console.ReadKey();
        }
    }
}
