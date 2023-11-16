using System.Text.RegularExpressions;

public class Validacao
{
    public static bool ValidacaoDeCPF(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");
        int soma = 0;
        int contador = 0;
        int PrimeiroNumeroVerificador = 0;
        int SegundoNumeroVerificador = 0;
        if (cpf.Length != 11)
        {
            return false;
        }
        else
        {
            contador = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * contador;
                contador--;
            }
            if (soma % 11 < 2)
            {
                PrimeiroNumeroVerificador = 0;
            }
            else
            {
                PrimeiroNumeroVerificador = 11 - (soma % 11);
            }
            soma = 0;
            contador = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * contador;
                contador--;
            }
            if (soma % 11 < 2)
            {
                SegundoNumeroVerificador = 0;
            }
            else
            {
                SegundoNumeroVerificador = 11 - (soma % 11);
            }
            if (PrimeiroNumeroVerificador == Convert.ToInt32(cpf[9].ToString()) && SegundoNumeroVerificador == Convert.ToInt32(cpf[10].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public static bool ValidacaoDeEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        Regex rejeita = new Regex(pattern);

        return rejeita.IsMatch(email);
    }
}