//using ClassesAbstratasVSInterfaces.ClasseAbstrata;
using ClassesAbstratasVSInterfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasVSInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // classes abstratas ou interface
            Cachorro cachorro = new Cachorro();
            Gato gato = new Gato();
            Cavalo cavalo = new Cavalo();
            Veterinario veterinario = new Veterinario();

            Console.WriteLine(veterinario.Examinar(cachorro));
            Console.WriteLine(veterinario.Examinar(gato));
            Console.WriteLine(veterinario.Examinar(cavalo));
            Console.ReadKey();
        }
    }
}
