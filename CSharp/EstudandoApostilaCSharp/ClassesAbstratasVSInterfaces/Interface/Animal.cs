using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasVSInterfaces.Interface
{
    public interface Animal
    {
        string Nome { get; set; }
        int Idade { get; set; }

        string EmitirSom();
    }
}
