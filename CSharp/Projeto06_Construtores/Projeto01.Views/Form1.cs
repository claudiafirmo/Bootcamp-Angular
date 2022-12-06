using ClassesObjetos.Classes;
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01.Views
{
    public partial class FormCadastro : Form
    {
        public FormCadastro() // Construtor
        {
            InitializeComponent();
            HabilitarEndereco(enderecoCheckBox.Checked);
            sexoComboBox.Items.Add(Sexos.Masculino);
            sexoComboBox.Items.Add(Sexos.Feminino);
            sexoComboBox.Items.Add(Sexos.Outros);
        }

        private void HabilitarEndereco(bool opcao)
        {
            logradouroLabel.Enabled = opcao;
            logradouroTextBox.Enabled = opcao;
            numeroLabel.Enabled = opcao;    
            numeroTextBox.Enabled = opcao;
            cidadeLabel.Enabled = opcao;
            cidadeTextBox.Enabled = opcao;
            cepLabel.Enabled = opcao;
            cepTextBox.Enabled = opcao;
        }

        private void enderecoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarEndereco(enderecoCheckBox.Checked);
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            // Obtendo os dados da classe Funcionario
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = nomeTextBox.Text;
            funcionario.Idade = int.Parse(idadeTextBox.Text);
            funcionario.Sexo = (Sexos)sexoComboBox.SelectedItem;

            if (enderecoCheckBox.Checked)
            {
                Endereco endereco = new Endereco()
                {
                    Logradouro = logradouroTextBox.Text,
                    Numero = int.Parse(numeroTextBox.Text),
                    Cidade = cidadeTextBox.Text,
                    Cep = cepTextBox.Text,
                };
                funcionario.EnderecoInfo = endereco;
            }
            funcionario.Cargo = cargoTextBox.Text;
            funcionario.Salario = double.Parse(salarioTextBox.Text);

            MessageBox.Show(funcionario.ToString());
        }
    }
}
