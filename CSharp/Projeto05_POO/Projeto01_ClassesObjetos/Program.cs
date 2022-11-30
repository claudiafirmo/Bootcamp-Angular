using ClassesObjetos.Classes;
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciando a classe pessoa e fazendo com que a variável p1 referencie essa instancia
            Pessoa p1 = new Pessoa();
            p1.Nome = "Amanda";
            p1.Idade = 19;
            p1.Sexo = Sexos.Feminino; // p1.Sexo = (Sexos) 11; -> Typecast: atribuimos a enumeracao Sexos cuja posição é 11.
            
            Endereco endereco = new Endereco();
            endereco.Logradouro = "Av.Paulista";
            endereco.Numero = 1009;
            endereco.Cidade = "São Paulo";
            endereco.Cep = "01311-100";

            p1.EnderecoInfo = endereco;


            // Atribuindo referencias: A variavel p2 referencia o mesmo objeto referenciado pela variavel p1
            /*Pessoa p2 = p1;
            p2.Idade = 31;
            Console.WriteLine(p2.Equals(p1));*/

            // Criando nova pessoa usando atribuição implicita
            Pessoa p2 = new Pessoa()
            {
                Nome = "Agatha Silva", Idade = 20, Sexo = Sexos.Feminino, EnderecoInfo = endereco
            };

            Console.WriteLine(p1.LerPessoa());
            Console.WriteLine();
            Console.WriteLine(p2.LerPessoa());
            Console.ReadKey();
        }
    }
}
