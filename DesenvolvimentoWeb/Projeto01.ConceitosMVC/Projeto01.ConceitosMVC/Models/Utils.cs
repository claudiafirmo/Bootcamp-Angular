using System.Collections;
using System.Collections.Generic;

namespace Projeto01.ConceitosMVC.Models
{
    public class Utils
    {
        public static IEnumerable<Pessoa> ListarPessoas()
        {
            return new List<Pessoa>()
            {
                new Fornecedor()
                {
                    Cpf = "12345685210",
                    Nome = "Joseph",
                    Email = "jojo@mail.com",
                    Telefone = "1234-5678"
                },
                new Cliente()
                {
                    Cpf = "98765412320",
                    Nome = "Jotaro",
                    Email = "kujo@mail.com",
                    Telefone = "8434-5548"
                }
            };
        }
    }
}
