using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Listas
{
    public class Produto : IComparable<Produto>
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, string descricao, double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco = preco;
        }
        public override string ToString()
        {
            return $"{Codigo} - {Descricao}";
        }

        public int CompareTo(Produto other)
        {
            return this.Descricao.CompareTo(other.Descricao);
        }
    }
}
