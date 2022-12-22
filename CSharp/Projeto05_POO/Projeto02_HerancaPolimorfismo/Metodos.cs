using ClassesObjetos.Classes;
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Windows.Forms;

namespace Projeto02_HerancaPolimorfismo
{
    public class Metodos
    {
        public static void LerDadosPessoa()
        {
            // obtendo endereço como dados de entrada
            Console.Write("Informe o Logradouro: ");
            string logradouro = Console.ReadLine();

            Console.Write("Informe o Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o CEP: ");
            string cep = Console.ReadLine();

            Console.Write("Informe o Cidade: ");
            string cidade = Console.ReadLine();

            // Definindo um endereco
            Endereco endereco = new Endereco()
            {
                Logradouro = logradouro,
                Cep = cep,
                Cidade = cidade,
                Numero = numero
            };
            Console.WriteLine();

            // obtendo dados da pessoa
            Pessoa pessoa = new Pessoa();
            Console.Write("Informe o seu nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Informe sua idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());
            Console.Write("Informe o seu sexo (10 - Masculino, 11 - Feminino e 12 - Outros): ");
            pessoa.Sexo = (Sexos)int.Parse(Console.ReadLine());
            pessoa.EnderecoInfo = endereco;

            MessageBox.Show(pessoa.LerPessoa());
        }

        // metodo usado para ler dados de funcionario
        public static void LerDadosFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Informe o seu nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            funcionario.Idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o seu sexo (10 - Masculino, 11 - Feminino e 12 - Outros): ");
            funcionario.Sexo = (Sexos)int.Parse(Console.ReadLine());

            Console.Write("Informe seu cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Informe seu salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            MessageBox.Show(funcionario.LerPessoa());
        }

        public static void LerDadosPessoaFuncionario()
        {
            Pessoa pessoa = new Funcionario()
            {
                Nome = "Joseph",
                Idade = 50,
                Sexo = Sexos.Masculino,
                Cargo = "Marinheiro",
                Salario = 5000.00
            };
            // apos o objeto ter sido criado, como podemos fazer para acessar as propriedades especificas do objeto (Cargo e Salario)
            if(pessoa is Funcionario) 
            {
                Funcionario func = (Funcionario)pessoa; 
                func.Cargo = "Cozinheiro";
            }

            /*
             * o método executado é o método polimorfico (sobrescrito) referente ao objeto.
             * Ou seja, quem executa o método é o objeto.
             */

            MessageBox.Show(pessoa.LerPessoa());

            pessoa = new Pessoa()
            {
                Nome = "Joseph",
                Idade = 50,
                Sexo = Sexos.Masculino
            };
            

            MessageBox.Show(pessoa.LerPessoa());

            pessoa = new Aluno()
            {
                Nome = "Joseph",
                Idade = 50,
                Sexo = Sexos.Masculino,
                Curso = "Curso Superior de Tecnologia em Análise e Desenvolvimento de Sistemas",
                Matricula = 124682
            };


            if (pessoa is Aluno)
            {
                Aluno aluno = pessoa as Aluno;
                aluno.Curso = "Pedagogia"; 
            }

            MessageBox.Show(pessoa.LerPessoa());

            object obj = pessoa;

            MessageBox.Show(obj.ToString(), "Objeto Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
