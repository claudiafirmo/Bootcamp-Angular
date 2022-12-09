using ClassesObjetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Classes
{
    public class Funcionario : Pessoa
    {
        public IDocumento Documento{ get; set; }

        public string Cargo { get; set; }
        // 3° tipo de propriedade: Property Expression
        private double _salario;
        public double Salario
        {
            get => _salario;
            set => _salario = value > 0 ? value: throw new ArgumentException("Salário inválido");
        }

        // suponha que o imposto de renda seja equivalente a 10% do que receber do salario de R$ 1500,00.
        // Escreveremos uma propriedade somente-leitura.
        
        // a propriedade so pode retornar isso, nao precisa definir set.
        public double Irpf => this.Salario > 1500 ? (this.Salario - 1500) * 0.1 : 0;

        // analogamente, definiremos a propriedade SalarioLiquido como sendo somente-leitura
        public double SalarioLiquido => this.Salario - this.Irpf;

        public Funcionario(IDocumento documento, string nome, string cargo) : base(nome)
        {
            this.Documento = documento;
            this.Cargo = cargo;
        }

        public Funcionario(IDocumento documento, string nome, string cargo, double salario): this(documento, nome, cargo)
        {
            this.Salario = salario;
        }

        public override string LerPessoa()
        {
            string resposta = $"{base.LerPessoa()}\nDocumento: {Documento.GetDocumento()}\nCargo: {Cargo}\nSalário Bruto: {Salario:c}\n" +
                $"IRPF: {Irpf:c}\nSalário Líquido: {SalarioLiquido:c}";
            return resposta;
        }

        public override string ToString()
        {
            return $"{this.Documento.Numero} - {this.Nome}";
        }

        public override string MostrarMensagem()
        {
            return "Mensagem da classe abstrata Pessoa";
        }
    }
}
