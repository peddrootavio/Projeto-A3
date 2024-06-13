using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cadastrosdeclientes.Crud
{
    public class UpdateIdoso
    {
        private string connectionString;

        public UpdateIdoso(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AtualizarIdoso(int id, string novoNome, string novoCpf, string novoTelefone, string novoTipo, string novaDataNascimento, string novaDataEntrada)
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

                    // Atualize o registro na tabela Idoso
                    string updateIdosoQuery = "UPDATE Idoso SET Data_Entrada = @Data_Entrada";
                    using (MySqlCommand updateIdosoCommand = new MySqlCommand(updateIdosoQuery, connection))
                    {
                        updateIdosoCommand.Parameters.AddWithValue("@Data_Entrada", novaDataEntrada);
                        updateIdosoCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados do idoso atualizados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao atualizar dados do idoso: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
