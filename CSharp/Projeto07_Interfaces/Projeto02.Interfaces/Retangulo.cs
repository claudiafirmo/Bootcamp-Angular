using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Interfaces
{
    internal class Retangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double CalcularArea()
        {
            return this.Base * this.Altura;
        }
    }
}
