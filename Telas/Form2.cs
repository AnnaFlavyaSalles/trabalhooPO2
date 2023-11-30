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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            botao_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_salvar.FlatAppearance.BorderSize = 0;
            botao_salvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_salvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_salvar.BackColor = Color.Transparent;
            botao_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_limpar.FlatAppearance.BorderSize = 0;
            botao_limpar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_limpar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_limpar.BackColor = Color.Transparent;
            botao_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botao_fechar.FlatAppearance.BorderSize = 0;
            botao_fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao_fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao_fechar.BackColor = Color.Transparent;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
