namespace trabalhoPO2
{
    partial class Form2
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
            tb_razao = new TextBox();
            tb_endereco = new TextBox();
            tb_nomeF = new TextBox();
            tb_cidade = new TextBox();
            tb_nomePro = new TextBox();
            mtb_cnpj = new MaskedTextBox();
            mtb_cpfPro = new MaskedTextBox();
            mtb_cep = new MaskedTextBox();
            mtb_telefone = new MaskedTextBox();
            tb_capital = new TextBox();
            tb_numero = new TextBox();
            cb_estado = new ComboBox();
            cb_situacao = new ComboBox();
            dp_data = new DateTimePicker();
            rb_simples = new RadioButton();
            rb_real = new RadioButton();
            rb_lucro = new RadioButton();
            rb_PorteGrande = new RadioButton();
            rb_PorteMedio = new RadioButton();
            rb_PortePequeno = new RadioButton();
            cb_natureza = new ComboBox();
            rb_matriz = new RadioButton();
            tb_filial = new RadioButton();
            botao_limpar = new Button();
            botao_salvar = new Button();
            botao_fechar = new Button();
            SuspendLayout();
            // 
            // tb_razao
            // 
            tb_razao.BackColor = Color.White;
            tb_razao.BorderStyle = BorderStyle.None;
            tb_razao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_razao.ForeColor = SystemColors.WindowText;
            tb_razao.Location = new Point(203, 91);
            tb_razao.Margin = new Padding(3, 4, 3, 4);
            tb_razao.Name = "tb_razao";
            tb_razao.Size = new Size(162, 25);
            tb_razao.TabIndex = 5;
            // 
            // tb_endereco
            // 
            tb_endereco.BackColor = Color.White;
            tb_endereco.BorderStyle = BorderStyle.None;
            tb_endereco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_endereco.ForeColor = SystemColors.WindowText;
            tb_endereco.Location = new Point(389, 91);
            tb_endereco.Margin = new Padding(3, 4, 3, 4);
            tb_endereco.Name = "tb_endereco";
            tb_endereco.Size = new Size(321, 25);
            tb_endereco.TabIndex = 6;
            // 
            // tb_nomeF
            // 
            tb_nomeF.BackColor = Color.White;
            tb_nomeF.BorderStyle = BorderStyle.None;
            tb_nomeF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nomeF.ForeColor = SystemColors.WindowText;
            tb_nomeF.Location = new Point(12, 135);
            tb_nomeF.Margin = new Padding(3, 4, 3, 4);
            tb_nomeF.Name = "tb_nomeF";
            tb_nomeF.Size = new Size(353, 25);
            tb_nomeF.TabIndex = 7;
            // 
            // tb_cidade
            // 
            tb_cidade.BackColor = Color.White;
            tb_cidade.BorderStyle = BorderStyle.None;
            tb_cidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_cidade.ForeColor = SystemColors.WindowText;
            tb_cidade.Location = new Point(562, 135);
            tb_cidade.Margin = new Padding(3, 4, 3, 4);
            tb_cidade.Name = "tb_cidade";
            tb_cidade.Size = new Size(148, 25);
            tb_cidade.TabIndex = 8;
            // 
            // tb_nomePro
            // 
            tb_nomePro.BackColor = Color.White;
            tb_nomePro.BorderStyle = BorderStyle.None;
            tb_nomePro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nomePro.ForeColor = SystemColors.WindowText;
            tb_nomePro.Location = new Point(389, 335);
            tb_nomePro.Margin = new Padding(3, 4, 3, 4);
            tb_nomePro.Name = "tb_nomePro";
            tb_nomePro.Size = new Size(321, 25);
            tb_nomePro.TabIndex = 9;
            // 
            // mtb_cnpj
            // 
            mtb_cnpj.BorderStyle = BorderStyle.None;
            mtb_cnpj.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_cnpj.Location = new Point(12, 91);
            mtb_cnpj.Margin = new Padding(3, 4, 3, 4);
            mtb_cnpj.Mask = "99,999,999/9999-99";
            mtb_cnpj.Name = "mtb_cnpj";
            mtb_cnpj.Size = new Size(162, 25);
            mtb_cnpj.TabIndex = 18;
            mtb_cnpj.ValidatingType = typeof(DateTime);
            // 
            // mtb_cpfPro
            // 
            mtb_cpfPro.BorderStyle = BorderStyle.None;
            mtb_cpfPro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_cpfPro.Location = new Point(12, 317);
            mtb_cpfPro.Margin = new Padding(3, 4, 3, 4);
            mtb_cpfPro.Mask = "000,000,000-00";
            mtb_cpfPro.Name = "mtb_cpfPro";
            mtb_cpfPro.Size = new Size(162, 25);
            mtb_cpfPro.TabIndex = 19;
            mtb_cpfPro.ValidatingType = typeof(DateTime);
            // 
            // mtb_cep
            // 
            mtb_cep.BorderStyle = BorderStyle.None;
            mtb_cep.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_cep.Location = new Point(389, 180);
            mtb_cep.Margin = new Padding(3, 4, 3, 4);
            mtb_cep.Mask = "00000-000";
            mtb_cep.Name = "mtb_cep";
            mtb_cep.Size = new Size(146, 25);
            mtb_cep.TabIndex = 20;
            mtb_cep.ValidatingType = typeof(DateTime);
            // 
            // mtb_telefone
            // 
            mtb_telefone.BorderStyle = BorderStyle.None;
            mtb_telefone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_telefone.Location = new Point(203, 282);
            mtb_telefone.Margin = new Padding(3, 4, 3, 4);
            mtb_telefone.Mask = "(00) 00000-000-";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(162, 25);
            mtb_telefone.TabIndex = 21;
            mtb_telefone.ValidatingType = typeof(DateTime);
            // 
            // tb_capital
            // 
            tb_capital.BackColor = Color.White;
            tb_capital.BorderStyle = BorderStyle.None;
            tb_capital.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_capital.ForeColor = SystemColors.WindowText;
            tb_capital.Location = new Point(12, 270);
            tb_capital.Margin = new Padding(3, 4, 3, 4);
            tb_capital.Name = "tb_capital";
            tb_capital.Size = new Size(162, 25);
            tb_capital.TabIndex = 22;
            // 
            // tb_numero
            // 
            tb_numero.BackColor = Color.White;
            tb_numero.BorderStyle = BorderStyle.None;
            tb_numero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_numero.ForeColor = SystemColors.WindowText;
            tb_numero.Location = new Point(562, 180);
            tb_numero.Margin = new Padding(3, 4, 3, 4);
            tb_numero.Name = "tb_numero";
            tb_numero.Size = new Size(148, 25);
            tb_numero.TabIndex = 23;
            // 
            // cb_estado
            // 
            cb_estado.FormattingEnabled = true;
            cb_estado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            cb_estado.Location = new Point(389, 132);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(146, 28);
            cb_estado.TabIndex = 24;
            // 
            // cb_situacao
            // 
            cb_situacao.FormattingEnabled = true;
            cb_situacao.Items.AddRange(new object[] { "Ativa", "Nula", "Suspensa", "Inapta", "Baixada" });
            cb_situacao.Location = new Point(12, 177);
            cb_situacao.Name = "cb_situacao";
            cb_situacao.Size = new Size(162, 28);
            cb_situacao.TabIndex = 25;
            // 
            // dp_data
            // 
            dp_data.Location = new Point(12, 225);
            dp_data.Name = "dp_data";
            dp_data.Size = new Size(162, 27);
            dp_data.TabIndex = 26;
            // 
            // rb_simples
            // 
            rb_simples.AutoSize = true;
            rb_simples.Location = new Point(203, 178);
            rb_simples.Name = "rb_simples";
            rb_simples.Size = new Size(145, 24);
            rb_simples.TabIndex = 27;
            rb_simples.TabStop = true;
            rb_simples.Text = "Simples Nacional\r\n";
            rb_simples.UseVisualStyleBackColor = true;
            rb_simples.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rb_real
            // 
            rb_real.AutoSize = true;
            rb_real.Location = new Point(203, 238);
            rb_real.Name = "rb_real";
            rb_real.Size = new Size(59, 24);
            rb_real.TabIndex = 28;
            rb_real.TabStop = true;
            rb_real.Text = "Real\r\n";
            rb_real.UseVisualStyleBackColor = true;
            // 
            // rb_lucro
            // 
            rb_lucro.AutoSize = true;
            rb_lucro.Location = new Point(203, 208);
            rb_lucro.Name = "rb_lucro";
            rb_lucro.Size = new Size(140, 24);
            rb_lucro.TabIndex = 29;
            rb_lucro.TabStop = true;
            rb_lucro.Text = "Lucro Presumido\r\n";
            rb_lucro.UseVisualStyleBackColor = true;
            // 
            // rb_PorteGrande
            // 
            rb_PorteGrande.AutoSize = true;
            rb_PorteGrande.Location = new Point(389, 224);
            rb_PorteGrande.Name = "rb_PorteGrande";
            rb_PorteGrande.Size = new Size(78, 24);
            rb_PorteGrande.TabIndex = 30;
            rb_PorteGrande.TabStop = true;
            rb_PorteGrande.Text = "Grande";
            rb_PorteGrande.UseVisualStyleBackColor = true;
            // 
            // rb_PorteMedio
            // 
            rb_PorteMedio.AutoSize = true;
            rb_PorteMedio.Location = new Point(389, 254);
            rb_PorteMedio.Name = "rb_PorteMedio";
            rb_PorteMedio.Size = new Size(73, 24);
            rb_PorteMedio.TabIndex = 31;
            rb_PorteMedio.TabStop = true;
            rb_PorteMedio.Text = "Médio";
            rb_PorteMedio.UseVisualStyleBackColor = true;
            // 
            // rb_PortePequeno
            // 
            rb_PortePequeno.AutoSize = true;
            rb_PortePequeno.Location = new Point(389, 284);
            rb_PortePequeno.Name = "rb_PortePequeno";
            rb_PortePequeno.Size = new Size(87, 24);
            rb_PortePequeno.TabIndex = 32;
            rb_PortePequeno.TabStop = true;
            rb_PortePequeno.Text = "Pequeno";
            rb_PortePequeno.UseVisualStyleBackColor = true;
            // 
            // cb_natureza
            // 
            cb_natureza.FormattingEnabled = true;
            cb_natureza.Location = new Point(562, 223);
            cb_natureza.Name = "cb_natureza";
            cb_natureza.Size = new Size(148, 28);
            cb_natureza.TabIndex = 33;
            // 
            // rb_matriz
            // 
            rb_matriz.AutoSize = true;
            rb_matriz.Location = new Point(203, 319);
            rb_matriz.Name = "rb_matriz";
            rb_matriz.Size = new Size(72, 24);
            rb_matriz.TabIndex = 34;
            rb_matriz.TabStop = true;
            rb_matriz.Text = "Matriz";
            rb_matriz.UseVisualStyleBackColor = true;
            // 
            // tb_filial
            // 
            tb_filial.AutoSize = true;
            tb_filial.Location = new Point(203, 349);
            tb_filial.Name = "tb_filial";
            tb_filial.Size = new Size(61, 24);
            tb_filial.TabIndex = 35;
            tb_filial.TabStop = true;
            tb_filial.Text = "Filial";
            tb_filial.UseVisualStyleBackColor = true;
            // 
            // botao_limpar
            // 
            botao_limpar.Cursor = Cursors.Hand;
            botao_limpar.Location = new Point(18, 371);
            botao_limpar.Margin = new Padding(3, 4, 3, 4);
            botao_limpar.Name = "botao_limpar";
            botao_limpar.Size = new Size(122, 40);
            botao_limpar.TabIndex = 36;
            botao_limpar.UseVisualStyleBackColor = true;
            // 
            // botao_salvar
            // 
            botao_salvar.Cursor = Cursors.Hand;
            botao_salvar.Location = new Point(583, 370);
            botao_salvar.Margin = new Padding(3, 4, 3, 4);
            botao_salvar.Name = "botao_salvar";
            botao_salvar.Size = new Size(122, 40);
            botao_salvar.TabIndex = 37;
            botao_salvar.UseVisualStyleBackColor = true;
            // 
            // botao_fechar
            // 
            botao_fechar.Cursor = Cursors.Hand;
            botao_fechar.Location = new Point(673, 6);
            botao_fechar.Margin = new Padding(3, 4, 3, 4);
            botao_fechar.Name = "botao_fechar";
            botao_fechar.Size = new Size(43, 40);
            botao_fechar.TabIndex = 38;
            botao_fechar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cadastro_E_mpresa__2_;
            ClientSize = new Size(722, 427);
            Controls.Add(botao_fechar);
            Controls.Add(botao_salvar);
            Controls.Add(botao_limpar);
            Controls.Add(tb_filial);
            Controls.Add(rb_matriz);
            Controls.Add(cb_natureza);
            Controls.Add(rb_PortePequeno);
            Controls.Add(rb_PorteMedio);
            Controls.Add(rb_PorteGrande);
            Controls.Add(rb_lucro);
            Controls.Add(rb_real);
            Controls.Add(rb_simples);
            Controls.Add(dp_data);
            Controls.Add(cb_situacao);
            Controls.Add(cb_estado);
            Controls.Add(tb_numero);
            Controls.Add(tb_capital);
            Controls.Add(mtb_telefone);
            Controls.Add(mtb_cep);
            Controls.Add(mtb_cpfPro);
            Controls.Add(mtb_cnpj);
            Controls.Add(tb_nomePro);
            Controls.Add(tb_cidade);
            Controls.Add(tb_nomeF);
            Controls.Add(tb_endereco);
            Controls.Add(tb_razao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_razao;
        private TextBox tb_endereco;
        private TextBox tb_nomeF;
        private TextBox tb_cidade;
        private TextBox tb_nomePro;
        private MaskedTextBox mtb_cnpj;
        private MaskedTextBox mtb_cpfPro;
        private MaskedTextBox mtb_cep;
        private MaskedTextBox mtb_telefone;
        private TextBox tb_capital;
        private TextBox tb_numero;
        private ComboBox cb_estado;
        private ComboBox cb_situacao;
        private DateTimePicker dp_data;
        private RadioButton rb_simples;
        private RadioButton rb_real;
        private RadioButton rb_lucro;
        private RadioButton rb_PorteGrande;
        private RadioButton rb_PorteMedio;
        private RadioButton rb_PortePequeno;
        private ComboBox cb_natureza;
        private RadioButton rb_matriz;
        private RadioButton tb_filial;
        private Button botao_limpar;
        private Button botao_salvar;
        private Button botao_fechar;
    }
}