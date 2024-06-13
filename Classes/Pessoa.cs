using System;
using System.Linq;
using System.Windows.Forms;

public class Pessoa
{
    public string Tipo { get; private set; }
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public int Idade { get; private set; }
    public string Telefone { get; private set; }
    public string DataNascimento { get; private set; }

    public Pessoa(string tipo, string nome, string cpf, string dataNascimento, string telefone)
    {
 
        if (!ValidarCpf(cpf))
        {
            throw new ArgumentException("CPF inválido.");
        }

        if (!ValidarDataNascimento(dataNascimento))
        {
            MessageBox.Show("Data de nascimento inválida. A idade não pode exceder 120 anos.");
        }

        Tipo = tipo;
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Telefone = telefone;

        // Calcula a idade para a propriedade Idade
        Idade = CalcularIdade(Convert.ToDateTime(DataNascimento));

    }

    public virtual string GetDescricao()
    {
        return $"Nome: {Nome}";
    }

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

    public bool ValidarDataNascimento(string dataNascimento)
    {
        // Tenta converter a string para DateTime
        if (DateTime.TryParse(dataNascimento, out DateTime data))
        {
            // Calcula a idade com base na data atual
            int idade = CalcularIdade(data);
            // Verifica se a idade é maior que 120 anos
            return idade <= 120;
        }
        return false;
    }

    private int CalcularIdade(DateTime dataNascimento)
    {
        // Calcula a idade com base na data atual
        int idade = DateTime.Now.Year - dataNascimento.Year;

        // Ajusta a idade se a data de aniversário ainda não passou este ano
        if (dataNascimento.Date > DateTime.Now.AddYears(-idade)) idade--;

        return idade;
    }
}

public class Idoso : Pessoa
{
    public string DataEntrada { get; private set; }

    public Idoso(string tipo, string nome, string cpf, string dataNascimento, string telefone, string dataEntrada)
        : base(tipo, nome, cpf, dataNascimento, telefone) // Chamando o construtor da classe base com os parâmetros corretos
    {
        DataEntrada = dataEntrada;
    }

    public override string GetDescricao()
    {
        return base.GetDescricao() + $"\nData de Entrada: {DataEntrada}";
    }
}

public class Cuidador : Pessoa
{
    public string Matricula { get; private set; }

    public Cuidador(string tipo, string nome, string cpf, string dataNascimento, string telefone, string matricula)
        : base(tipo, nome, cpf, dataNascimento, telefone) // Chamando o construtor da classe base com os parâmetros corretos
    {
        Matricula = matricula;
    }
}
