namespace Projeto01.Views
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fecharButton = new System.Windows.Forms.Button();
            this.incluirButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.cepLabel = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.logradouroLabel = new System.Windows.Forms.Label();
            this.enderecoCheckBox = new System.Windows.Forms.CheckBox();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.funcionariosListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.funcionariosListBox);
            this.groupBox1.Controls.Add(this.documentoTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fecharButton);
            this.groupBox1.Controls.Add(this.incluirButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.enderecoCheckBox);
            this.groupBox1.Controls.Add(this.salarioTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cargoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sexoComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idadeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(876, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Funcionários";
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.Location = new System.Drawing.Point(266, 135);
            this.documentoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(177, 22);
            this.documentoTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Documento:";
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(121, 459);
            this.fecharButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 13;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(29, 459);
            this.incluirButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 12;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            this.incluirButton.Click += new System.EventHandler(this.incluirButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cidadeTextBox);
            this.groupBox2.Controls.Add(this.cidadeLabel);
            this.groupBox2.Controls.Add(this.cepTextBox);
            this.groupBox2.Controls.Add(this.cepLabel);
            this.groupBox2.Controls.Add(this.numeroTextBox);
            this.groupBox2.Controls.Add(this.numeroLabel);
            this.groupBox2.Controls.Add(this.logradouroTextBox);
            this.groupBox2.Controls.Add(this.logradouroLabel);
            this.groupBox2.Location = new System.Drawing.Point(35, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(437, 204);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(313, 79);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(113, 22);
            this.cidadeTextBox.TabIndex = 9;
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Location = new System.Drawing.Point(217, 85);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(54, 16);
            this.cidadeLabel.TabIndex = 8;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // cepTextBox
            // 
            this.cepTextBox.Location = new System.Drawing.Point(96, 121);
            this.cepTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(153, 22);
            this.cepTextBox.TabIndex = 7;
            // 
            // cepLabel
            // 
            this.cepLabel.AutoSize = true;
            this.cepLabel.Location = new System.Drawing.Point(11, 123);
            this.cepLabel.Name = "cepLabel";
            this.cepLabel.Size = new System.Drawing.Size(37, 16);
            this.cepLabel.TabIndex = 6;
            this.cepLabel.Text = "CEP:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(96, 79);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(113, 22);
            this.numeroTextBox.TabIndex = 5;
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(11, 82);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(58, 16);
            this.numeroLabel.TabIndex = 4;
            this.numeroLabel.Text = "Número:";
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.Location = new System.Drawing.Point(96, 41);
            this.logradouroTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(312, 22);
            this.logradouroTextBox.TabIndex = 3;
            // 
            // logradouroLabel
            // 
            this.logradouroLabel.AutoSize = true;
            this.logradouroLabel.Location = new System.Drawing.Point(11, 44);
            this.logradouroLabel.Name = "logradouroLabel";
            this.logradouroLabel.Size = new System.Drawing.Size(80, 16);
            this.logradouroLabel.TabIndex = 2;
            this.logradouroLabel.Text = "Logradouro:";
            // 
            // enderecoCheckBox
            // 
            this.enderecoCheckBox.AutoSize = true;
            this.enderecoCheckBox.Location = new System.Drawing.Point(11, 193);
            this.enderecoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enderecoCheckBox.Name = "enderecoCheckBox";
            this.enderecoCheckBox.Size = new System.Drawing.Size(149, 20);
            this.enderecoCheckBox.TabIndex = 10;
            this.enderecoCheckBox.Text = "Informar o endereço";
            this.enderecoCheckBox.UseVisualStyleBackColor = true;
            this.enderecoCheckBox.CheckedChanged += new System.EventHandler(this.enderecoCheckBox_CheckedChanged);
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.Location = new System.Drawing.Point(67, 135);
            this.salarioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(110, 22);
            this.salarioTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salário:";
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.Location = new System.Drawing.Point(67, 103);
            this.cargoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(376, 22);
            this.cargoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cargo:";
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(183, 70);
            this.sexoComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(167, 24);
            this.sexoComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.Location = new System.Drawing.Point(67, 73);
            this.idadeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(49, 22);
            this.idadeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(67, 37);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(376, 22);
            this.nomeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // funcionariosListBox
            // 
            this.funcionariosListBox.FormattingEnabled = true;
            this.funcionariosListBox.ItemHeight = 16;
            this.funcionariosListBox.Location = new System.Drawing.Point(504, 28);
            this.funcionariosListBox.Name = "funcionariosListBox";
            this.funcionariosListBox.Size = new System.Drawing.Size(353, 404);
            this.funcionariosListBox.TabIndex = 16;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 567);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastro";
            this.Text = "Gestão de pessoas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.Label cepLabel;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.Label logradouroLabel;
        private System.Windows.Forms.CheckBox enderecoCheckBox;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox funcionariosListBox;
    }
}

