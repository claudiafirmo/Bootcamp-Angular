using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasVSInterfaces.Interface
{
    public class Veterinario
    {
        public string Examinar(Animal animal)
        {
            return animal.EmitirSom();
        }
    }
}
