using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Interfaces
{
    public interface IDocumento
    {
        string Numero { get; set; }
        string GetDocumento();
        //{
        //    if (Numero.Length == 11)
        //    {
        //        return $"CPF: {Numero}";
        //    }
        //    else
        //    {
        //        return $"CNPJ: {Numero}";
        //    }
        //}
    }
}
