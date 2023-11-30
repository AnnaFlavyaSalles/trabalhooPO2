namespace trabalhoPO2
{
    partial class Menu
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
            botao_funcionario = new Button();
            botao_fechar = new Button();
            botao_empresa = new Button();
            SuspendLayout();
            // 
            // botao_funcionario
            // 
            botao_funcionario.Cursor = Cursors.Hand;
            botao_funcionario.Location = new Point(284, 146);
            botao_funcionario.Margin = new Padding(3, 4, 3, 4);
            botao_funcionario.Name = "botao_funcionario";
            botao_funcionario.Size = new Size(159, 50);
            botao_funcionario.TabIndex = 38;
            botao_funcionario.UseVisualStyleBackColor = true;
            // 
            // botao_fechar
            // 
            botao_fechar.Cursor = Cursors.Hand;
            botao_fechar.Location = new Point(674, 5);
            botao_fechar.Margin = new Padding(3, 4, 3, 4);
            botao_fechar.Name = "botao_fechar";
            botao_fechar.Size = new Size(42, 40);
            botao_fechar.TabIndex = 39;
            botao_fechar.UseVisualStyleBackColor = true;
            // 
            // botao_empresa
            // 
            botao_empresa.Cursor = Cursors.Hand;
            botao_empresa.Location = new Point(284, 241);
            botao_empresa.Margin = new Padding(3, 4, 3, 4);
            botao_empresa.Name = "botao_empresa";
            botao_empresa.Size = new Size(159, 50);
            botao_empresa.TabIndex = 40;
            botao_empresa.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Menu;
            ClientSize = new Size(723, 428);
            Controls.Add(botao_empresa);
            Controls.Add(botao_fechar);
            Controls.Add(botao_funcionario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button botao_funcionario;
        private Button botao_fechar;
        private Button botao_empresa;
    }
}