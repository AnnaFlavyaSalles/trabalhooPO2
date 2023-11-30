using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoPO2
{
    public partial class Consultar_Empresa : Form
    {
        public Consultar_Empresa()
        {
            InitializeComponent();
            botao_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_cadastrar.FlatAppearance.BorderSize = 0;
            botao_cadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_cadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_cadastrar.BackColor = Color.Transparent;
            botao_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_voltar.FlatAppearance.BorderSize = 0;
            botao_voltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_voltar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_voltar.BackColor = Color.Transparent;
            botao_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_fechar.FlatAppearance.BorderSize = 0;
            botao_fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_fechar.BackColor = Color.Transparent;
        }
        private void botao_cadastrar_Click (object sender, EventArgs e)
        {
            Form2 empresa = new Form2 ();
            empresa.Show();
            this.Dispose();
        }
        private void botao_voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
