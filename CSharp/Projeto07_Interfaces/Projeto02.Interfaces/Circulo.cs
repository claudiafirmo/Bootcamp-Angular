using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Interfaces
{
    internal class Circulo : IFigura
    {
        public double Raio { get; set; }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(this.Raio, 2);
        }
    }
}
