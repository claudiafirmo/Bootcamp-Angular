using ClassesObjetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class DocumentoCnpj : IDocumento
    {
        // Guia Regular Expressions: https://aurelio.net/regex/guia/
        private string _numero;
        public string Numero
        {
            get => _numero;
            set => _numero = Regex.IsMatch(value, "[0-9]{14}")
                ? value : throw new Exception("CNPJ Inválido, digite apenas os números");
        }

        public DocumentoCnpj(string numero)
        {
            this.Numero = numero;
        }

        public string GetDocumento()
        {
            return $"CNPJ: {Numero}";
        }
    }
}
