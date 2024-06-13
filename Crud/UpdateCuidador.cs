using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cadastrosdeclientes.Crud
{
    public class UpdateCuidador
    {
        private string connectionString;

        public UpdateCuidador(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AtualizarCuidador(int id, string novoNome, string novoCpf, string novoTelefone, string novoTipo, string novaDataNascimento, string novaMatricula)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Atualize o registro na tabela Pessoa
                    string updatePessoaQuery = "UPDATE Pessoa SET Nome = @Nome, CPF = @CPF, Telefone = @Telefone, Tipo = @Tipo, Data_Nascimento = @Data_Nascimento WHERE ID = @ID";
                    using (MySqlCommand updatePessoaCommand = new MySqlCommand(updatePessoaQuery, connection))
                    {
                        updatePessoaCommand.Parameters.AddWithValue("@ID", id);
                        updatePessoaCommand.Parameters.AddWithValue("@Nome", novoNome);
                        updatePessoaCommand.Parameters.AddWithValue("@CPF", novoCpf);
                        updatePessoaCommand.Parameters.AddWithValue("@Telefone", novoTelefone);
                        updatePessoaCommand.Parameters.AddWithValue("@Tipo", novoTipo);
                        updatePessoaCommand.Parameters.AddWithValue("@Data_Nascimento", novaDataNascimento);
                        updatePessoaCommand.ExecuteNonQuery();
                    }

                    // Atualize o registro na tabela Cuidador
                    string updateCuidadorQuery = "UPDATE cuidador SET matricula = @matricula";
                    using (MySqlCommand updateCuidadorCommand = new MySqlCommand(updateCuidadorQuery, connection))
                    {
                        updateCuidadorCommand.Parameters.AddWithValue("@matricula", novaMatricula);
                        updateCuidadorCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados do cuidador atualizados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao atualizar dados do cuidador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
