using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Aluno: Pessoa
    {
        public Curso Curso { get; set; }
        public int Matricula { get; set; }

        public Aluno(string Nome, int Matricula) : base(Nome)
        {
            this.Matricula = Matricula;
        }
        public Aluno(string Nome, int Matricula, Curso curso) : this(Nome, Matricula)
        {
            this.Curso = curso;
        }
        public override string LerPessoa()
        {
            return $"{base.LerPessoa()}\nCurso: {Curso.LerCurso()}\n" +
                $"Matrícula: {Matricula}";
        }
    }
}
