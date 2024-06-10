using System.Linq;
using System;

public class Validadores
{
    public bool ValidarCpf(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf)) return false;

        cpf = new string(cpf.Where(char.IsDigit).ToArray());

        if (cpf.Length != 11) return false;

        var tempCpf = cpf.Substring(0, 9);
        var soma = 0;

        for (var i = 0; i < 9; i++)
        {
            soma += (tempCpf[i] - '0') * (10 - i);
        }

        var resto = soma % 11;
        var digito = resto < 2 ? 0 : 11 - resto;

        if (cpf[9] - '0' != digito) return false;

        tempCpf += digito;
        soma = 0;

        for (var i = 0; i < 10; i++)
        {
            soma += (tempCpf[i] - '0') * (11 - i);
        }

        resto = soma % 11;
        digito = resto < 2 ? 0 : 11 - resto;

        return cpf[10] - '0' == digito;
    }

    public bool ValidarData(DateTime dataNascimento)
    {
        var idade = DateTime.Now.Year - dataNascimento.Year;
        if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;
        return idade <= 120;
    }
}
