using ClassesObjetos.Classes;
using ClassesObjetos.Enumeracoes;
using ClassesObjetos.Estruturas;
using ClassesObjetos.Interfaces;
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
            try
            {
                string doc = documentoTextBox.Text;
                IDocumento documento;
                if (doc.Length == 11)
                {
                    documento = new DocumentoCpf(doc);
                }
                else if (doc.Length == 14)
                {
                    documento = new DocumentoCnpj(doc);
                }
                else
                {
                    throw new InvalidOperationException("O documento informado é inválido");
                }

                // Obtendo os dados da classe Funcionario
                Funcionario funcionario = new Funcionario(documento, nomeTextBox.Text, cargoTextBox.Text, double.Parse(salarioTextBox.Text));
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

                MessageBox.Show(funcionario.ToString(), "Dados do Funcionário",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
        }
    }
}
