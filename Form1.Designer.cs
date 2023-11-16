namespace trabalhoPO2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            botao_fechar = new Button();
            botao_salvar = new Button();
            botao_limpar = new Button();
            tb_nome = new TextBox();
            tb_endereco = new TextBox();
            tb_email = new TextBox();
            tb_estadoCivil = new TextBox();
            tb_estado = new TextBox();
            tb_cidade = new TextBox();
            tb_funcao = new TextBox();
            tb_salario = new TextBox();
            mtb_cpf = new MaskedTextBox();
            tb_rg = new TextBox();
            tb_id = new TextBox();
            mtb_telefone = new MaskedTextBox();
            mtb_dataNascimento = new MaskedTextBox();
            SuspendLayout();
            // 
            // botao_fechar
            // 
            botao_fechar.Cursor = Cursors.Hand;
            botao_fechar.Location = new Point(682, 12);
            botao_fechar.Name = "botao_fechar";
            botao_fechar.Size = new Size(28, 23);
            botao_fechar.TabIndex = 0;
            botao_fechar.UseVisualStyleBackColor = true;
            botao_fechar.Click += botao_fechar_Click;
            // 
            // botao_salvar
            // 
            botao_salvar.Cursor = Cursors.Hand;
            botao_salvar.Location = new Point(590, 375);
            botao_salvar.Name = "botao_salvar";
            botao_salvar.Size = new Size(107, 30);
            botao_salvar.TabIndex = 2;
            botao_salvar.UseVisualStyleBackColor = true;
            botao_salvar.Click += botao_salvar_Click;
            // 
            // botao_limpar
            // 
            botao_limpar.Cursor = Cursors.Hand;
            botao_limpar.Location = new Point(25, 375);
            botao_limpar.Name = "botao_limpar";
            botao_limpar.Size = new Size(107, 30);
            botao_limpar.TabIndex = 3;
            botao_limpar.UseVisualStyleBackColor = true;
            botao_limpar.Click += botao_limpar_Click;
            // 
            // tb_nome
            // 
            tb_nome.BackColor = Color.White;
            tb_nome.BorderStyle = BorderStyle.None;
            tb_nome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nome.ForeColor = SystemColors.WindowText;
            tb_nome.Location = new Point(12, 93);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(355, 20);
            tb_nome.TabIndex = 4;
            // 
            // tb_endereco
            // 
            tb_endereco.BackColor = Color.White;
            tb_endereco.BorderStyle = BorderStyle.None;
            tb_endereco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_endereco.ForeColor = SystemColors.WindowText;
            tb_endereco.Location = new Point(391, 93);
            tb_endereco.Name = "tb_endereco";
            tb_endereco.Size = new Size(319, 20);
            tb_endereco.TabIndex = 5;
            // 
            // tb_email
            // 
            tb_email.BackColor = Color.White;
            tb_email.BorderStyle = BorderStyle.None;
            tb_email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_email.ForeColor = SystemColors.WindowText;
            tb_email.Location = new Point(12, 138);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(355, 20);
            tb_email.TabIndex = 6;
            // 
            // tb_estadoCivil
            // 
            tb_estadoCivil.BackColor = Color.White;
            tb_estadoCivil.BorderStyle = BorderStyle.None;
            tb_estadoCivil.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_estadoCivil.ForeColor = SystemColors.WindowText;
            tb_estadoCivil.Location = new Point(12, 287);
            tb_estadoCivil.Name = "tb_estadoCivil";
            tb_estadoCivil.Size = new Size(162, 20);
            tb_estadoCivil.TabIndex = 7;
            // 
            // tb_estado
            // 
            tb_estado.BackColor = Color.White;
            tb_estado.BorderStyle = BorderStyle.None;
            tb_estado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_estado.ForeColor = SystemColors.WindowText;
            tb_estado.Location = new Point(391, 138);
            tb_estado.Name = "tb_estado";
            tb_estado.Size = new Size(145, 20);
            tb_estado.TabIndex = 8;
            // 
            // tb_cidade
            // 
            tb_cidade.BackColor = Color.White;
            tb_cidade.BorderStyle = BorderStyle.None;
            tb_cidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_cidade.ForeColor = SystemColors.WindowText;
            tb_cidade.Location = new Point(563, 138);
            tb_cidade.Name = "tb_cidade";
            tb_cidade.Size = new Size(147, 20);
            tb_cidade.TabIndex = 9;
            // 
            // tb_funcao
            // 
            tb_funcao.BackColor = Color.White;
            tb_funcao.BorderStyle = BorderStyle.None;
            tb_funcao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_funcao.ForeColor = SystemColors.WindowText;
            tb_funcao.Location = new Point(391, 183);
            tb_funcao.Name = "tb_funcao";
            tb_funcao.Size = new Size(145, 20);
            tb_funcao.TabIndex = 10;
            // 
            // tb_salario
            // 
            tb_salario.BackColor = Color.White;
            tb_salario.BorderStyle = BorderStyle.None;
            tb_salario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_salario.ForeColor = SystemColors.WindowText;
            tb_salario.Location = new Point(563, 183);
            tb_salario.Name = "tb_salario";
            tb_salario.Size = new Size(147, 20);
            tb_salario.TabIndex = 11;
            // 
            // mtb_cpf
            // 
            mtb_cpf.BorderStyle = BorderStyle.None;
            mtb_cpf.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_cpf.Location = new Point(12, 183);
            mtb_cpf.Mask = "000,000,000-00";
            mtb_cpf.Name = "mtb_cpf";
            mtb_cpf.Size = new Size(162, 20);
            mtb_cpf.TabIndex = 12;
            // 
            // tb_rg
            // 
            tb_rg.BackColor = Color.White;
            tb_rg.BorderStyle = BorderStyle.None;
            tb_rg.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_rg.ForeColor = SystemColors.WindowText;
            tb_rg.Location = new Point(205, 183);
            tb_rg.Name = "tb_rg";
            tb_rg.Size = new Size(162, 20);
            tb_rg.TabIndex = 13;
            // 
            // tb_id
            // 
            tb_id.BackColor = Color.White;
            tb_id.BorderStyle = BorderStyle.None;
            tb_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id.ForeColor = SystemColors.WindowText;
            tb_id.Location = new Point(205, 287);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(162, 20);
            tb_id.TabIndex = 15;
            // 
            // mtb_telefone
            // 
            mtb_telefone.BorderStyle = BorderStyle.None;
            mtb_telefone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_telefone.Location = new Point(205, 235);
            mtb_telefone.Mask = "00000-0000";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(162, 20);
            mtb_telefone.TabIndex = 16;
            // 
            // mtb_dataNascimento
            // 
            mtb_dataNascimento.BorderStyle = BorderStyle.None;
            mtb_dataNascimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_dataNascimento.Location = new Point(12, 235);
            mtb_dataNascimento.Mask = "00/00/0000";
            mtb_dataNascimento.Name = "mtb_dataNascimento";
            mtb_dataNascimento.Size = new Size(162, 20);
            mtb_dataNascimento.TabIndex = 17;
            mtb_dataNascimento.ValidatingType = typeof(DateTime);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(722, 426);
            Controls.Add(mtb_dataNascimento);
            Controls.Add(mtb_telefone);
            Controls.Add(tb_id);
            Controls.Add(tb_rg);
            Controls.Add(mtb_cpf);
            Controls.Add(tb_salario);
            Controls.Add(tb_funcao);
            Controls.Add(tb_cidade);
            Controls.Add(tb_estado);
            Controls.Add(tb_estadoCivil);
            Controls.Add(tb_email);
            Controls.Add(tb_endereco);
            Controls.Add(tb_nome);
            Controls.Add(botao_limpar);
            Controls.Add(botao_salvar);
            Controls.Add(botao_fechar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_fechar;
        private Button botao_salvar;
        private Button botao_limpar;
        private TextBox tb_nome;
        private TextBox tb_endereco;
        private TextBox tb_email;
        private TextBox tb_estadoCivil;
        private TextBox tb_estado;
        private TextBox tb_cidade;
        private TextBox tb_funcao;
        private TextBox tb_salario;
        private MaskedTextBox mtb_cpf;
        private TextBox tb_rg;
        private TextBox tb_id;
        private MaskedTextBox mtb_telefone;
        private MaskedTextBox mtb_dataNascimento;
    }
}