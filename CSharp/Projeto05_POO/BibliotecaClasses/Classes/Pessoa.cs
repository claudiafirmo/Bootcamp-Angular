using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Pessoa
    {
        // propriedade Nome: Forma Completa - atributo + propriedade - Validações
        private string _nome;

        public string Nome 
        {
            get { return _nome; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new InvalidOperationException("O nome é inválido.");
                }
                _nome = value;  
            }
        }

        // propriedade Idade: Forma Completa
        private int _idade;

        public int Idade
        {
            get { return _idade; }
            set 
            { 
                if(value < 0)
                {
                    throw new InvalidOperationException("Idade inválida. Não pode ser negativa senhor usuário...");
                }
                _idade = value; 
            }
        }

        // Propriedade Sexo: Forma reduzida
        public Sexos Sexo { get; set; }

        // Propriedade Endereco: Forma reduzida
        public Endereco EnderecoInfo { get; set; }

        public virtual string LerPessoa()
        {
            string resposta = $"Nome: {this.Nome}\nIdade: {this.Idade}\nSexo: {this.Sexo}\n";
                // se endereço nao tiver logradouro, assumiremos que ele nao existe
                if (!string.IsNullOrEmpty(this.EnderecoInfo.Logradouro))
            {
                resposta += $"Dados do endereço:\n{this.EnderecoInfo.LerEndereco()}";
                //$"{this.EnderecoInfo.LerEndereco()}";
            }


            return resposta;
        }
    }
}
