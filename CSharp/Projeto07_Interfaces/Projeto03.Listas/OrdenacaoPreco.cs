using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Listas
{
    internal class OrdenacaoPreco : IComparer<Produto>
    {
        public int Compare(Produto x, Produto y)
        {
            return x.Preco.CompareTo(y.Preco);
        }
    }
}
