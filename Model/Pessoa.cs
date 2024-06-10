using System;

public class Pessoa
{
    private string nome { get; set; }
    private string cpf { get; set; }
    private int idade { get; set; }
    private DateTime dataNascimento { get; set; }
    private string telefone { get; set; }

    public Pessoa(string nome, string cpf, DateTime dataNascimento, string telefone)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
        this.telefone = telefone;
    }
}
