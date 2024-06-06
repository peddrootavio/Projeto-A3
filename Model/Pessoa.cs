using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrosdeclientes.Model
{
    public class Pessoa
    {
        protected String nome {  get; set; }
        protected int cpf { get; set; }
        protected DateTime dataNascimento { get; set; } 
        protected int idade { get; set; } 
        protected String telefone { get; set; } 

        public Pessoa(string nome, DateTime dataNascimento, int cpf, string telefone)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.telefone = telefone;
        }


    }
}
