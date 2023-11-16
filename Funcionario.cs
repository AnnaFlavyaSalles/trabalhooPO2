public class Funcionario
{
    public string id {  get; set; }
    public string nome { get; set; }
    public string email { get; set; }
    public string telefone { get; set; }
    public string cpf { get; set; }
    public string estadoCivil { get; set; }
    public string rg { get; set; }
    public DateTime dataNascimento { get; set; }
    public string endereco { get; set; }
    public string cidade { get; set; }
    public string estado { get; set; }
    public string funcao { get; set; }
    public double salario { get; set; }

    public Funcionario(string id, string nome, string email, string telefone, string cpf, string estadoCivil, string rg, DateTime dataNascimento, string endereco, string cidade, string estado, string funcao, double salario)
    {
        this.id = id;
        this.nome = nome;
        this.email = email;
        this.telefone = telefone;
        this.cpf = cpf;
        this.estadoCivil = estadoCivil;
        this.rg = rg;
        this.dataNascimento = dataNascimento;
        this.endereco = endereco;
        this.cidade = cidade;
        this.estado = estado;
        this.funcao = funcao;
        this.salario = salario;
    }
}
