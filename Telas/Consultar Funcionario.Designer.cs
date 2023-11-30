namespace trabalhoPO2
{
    partial class Consultar_Funcionario
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
            botao_fechar = new Button();
            botao_voltar = new Button();
            botao_cadastrar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // botao_fechar
            // 
            botao_fechar.Cursor = Cursors.Hand;
            botao_fechar.Location = new Point(674, 4);
            botao_fechar.Margin = new Padding(3, 4, 3, 4);
            botao_fechar.Name = "botao_fechar";
            botao_fechar.Size = new Size(42, 40);
            botao_fechar.TabIndex = 40;
            botao_fechar.UseVisualStyleBackColor = true;
            // 
            // botao_voltar
            // 
            botao_voltar.Cursor = Cursors.Hand;
            botao_voltar.Location = new Point(12, 360);
            botao_voltar.Margin = new Padding(3, 4, 3, 4);
            botao_voltar.Name = "botao_voltar";
            botao_voltar.Size = new Size(159, 50);
            botao_voltar.TabIndex = 41;
            botao_voltar.UseVisualStyleBackColor = true;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Cursor = Cursors.Hand;
            botao_cadastrar.Location = new Point(553, 362);
            botao_cadastrar.Margin = new Padding(3, 4, 3, 4);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(159, 50);
            botao_cadastrar.TabIndex = 42;
            botao_cadastrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(699, 286);
            dataGridView1.TabIndex = 43;
            // 
            // Consultar_Funcionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Consultar_Funcionário;
            ClientSize = new Size(723, 428);
            Controls.Add(dataGridView1);
            Controls.Add(botao_cadastrar);
            Controls.Add(botao_voltar);
            Controls.Add(botao_fechar);
            Name = "Consultar_Funcionario";
            Text = "Consultar_Funcionario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button botao_fechar;
        private Button botao_voltar;
        private Button botao_cadastrar;
        private DataGridView dataGridView1;
    }
}