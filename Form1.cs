namespace trabalhoPO2
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void botao_limpar_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_nome.Text = "";
            tb_email.Text = "";
            mtb_telefone.Text = "";
            mtb_cpf.Text = "";
            tb_estadoCivil.Text = "";
            tb_rg.Text = "";
            tb_endereco.Text = "";
            tb_cidade.Text = "";
            tb_estado.Text = "";
            tb_funcao.Text = "";
            mtb_dataNascimento.Text = "";
            tb_salario.Text = "";
        }

        private void botao_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botao_salvar_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string nome = tb_nome.Text;
            string email = tb_email.Text;
            string telefone = mtb_telefone.Text;
            string cpf = mtb_cpf.Text;
            string estadoCivil = tb_estadoCivil.Text;
            string rg = tb_rg.Text;
            DateTime dataNasc = DateTime.Parse(mtb_dataNascimento.Text);
            string endereco = tb_endereco.Text;
            string cidade = tb_cidade.Text;
            string estado = tb_estado.Text;
            string funcao = tb_funcao.Text;
            double salario = Double.Parse(tb_salario.Text);

            Funcionario funcionario = new Funcionario(id, nome, email, telefone, cpf, estadoCivil, rg, dataNasc, endereco, cidade, estado, funcao, salario);

            bool cpfValido = Validacao.ValidacaoDeCPF(mtb_cpf.Text);
            bool emailValido = Validacao.ValidacaoDeEmail(tb_email.Text);

            if (!cpfValido)
            {
                MessageBox.Show("Insira um CPF que seja válido");
            }
            if (!emailValido)
            {
                MessageBox.Show("Insira um email que seja válido");
            }
            if (cpfValido && emailValido)
            {
                MessageBox.Show("Funcionário Cadastrado");
                this.Dispose();
            }
        }
    }
}