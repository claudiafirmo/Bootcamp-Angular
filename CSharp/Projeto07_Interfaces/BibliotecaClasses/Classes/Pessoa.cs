using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public abstract class Pessoa
    {
        public Pessoa(string Nome)
        {
            this.Nome = Nome;
        }

        public Pessoa(string Nome, int Idade) : this(Nome)
        {
            this._idade = Idade;
        }

        public Pessoa(string Nome, int Idade, Sexos Sexo) : this(Nome, Idade)
        {
            this.Sexo = Sexo;
        }
        public Pessoa(string Nome, int Idade, Sexos Sexo, Endereco EnderecoInfo)
            : this(Nome, Idade, Sexo)
        {
            this.EnderecoInfo = EnderecoInfo;
        }

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
            string cabecalho = "DADOS DA PESSOA:";

            string resposta = $"{cabecalho}\nNome: {this.Nome}\nIdade: {this.Idade}\nSexo: {this.Sexo}\n";
                // se endereço nao tiver logradouro, assumiremos que ele nao existe
                if (!string.IsNullOrEmpty(this.EnderecoInfo.Logradouro))
            {
                resposta += $"Dados do endereço:\n{this.EnderecoInfo.LerEndereco()}";
                //$"{this.EnderecoInfo.LerEndereco()}";
            }
            return resposta;
        }

        public virtual string LerPessoa(string cabecalho)
        {
            string resposta = $"{cabecalho}\nNome: {this.Nome}\nIdade: {this.Idade}\nSexo: {this.Sexo}\n";
            // se endereço nao tiver logradouro, assumiremos que ele nao existe
            if (!string.IsNullOrEmpty(this.EnderecoInfo.Logradouro))
            {
                resposta += $"Dados do endereço:\n{this.EnderecoInfo.LerEndereco()}";
                //$"{this.EnderecoInfo.LerEndereco()}";
            }
            return resposta;
        }

        // Sobrescrevendo o metodo ToString()
        public override string ToString()
        {
            return  $"USANDO O MÉTODO ToString()\n\n{this.LerPessoa()}";
        }

        public abstract string MostrarMensagem();   
    }
}
