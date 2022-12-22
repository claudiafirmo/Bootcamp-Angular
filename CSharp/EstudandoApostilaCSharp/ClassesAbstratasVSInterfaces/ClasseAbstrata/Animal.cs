using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasVSInterfaces.ClasseAbstrata
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if(_idade < 0)
                {
                    throw new InvalidOperationException("Idade inválida! Deve ser um valor maior ou igual a 0");
                }
                _idade = value;
            }
        }

        public virtual string EmitirSom(){ return ""; } 
    }
}
