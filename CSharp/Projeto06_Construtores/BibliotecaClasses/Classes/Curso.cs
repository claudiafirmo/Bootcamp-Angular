using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class Curso
    {

        public Curso(string Descricao, int CargaHoraria)
        {
            this.Descricao = Descricao;
            this.CargaHoraria = CargaHoraria;
        }

        private string _descricao;
        public string Descricao
        { 
            get => _descricao;
            set => _descricao = !string.IsNullOrEmpty(value) ? value :
                throw new Exception("Descrição Inválida");
        }
        
        private int _ch;
        public int CargaHoraria 
        {
            get => _ch; 
            set => _ch = value > 0 ? value : throw new Exception("A carga horária deve ser positiva"); 
        }

        public string LerCurso()
        {
            return $"Descrição : {Descricao}\nCarga Horária: {CargaHoraria}";
        }
    }
}
