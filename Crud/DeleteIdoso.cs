using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cadastrosdeclientes.Crud
{
    internal class DeleteIdoso
    {
        private string connectionString;

        public DeleteIdoso(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ApagarIdoso(int PESSOA_ID, int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Remova o registro da tabela Idoso
                    string deleteIdosoQuery = "DELETE FROM Idoso WHERE PESSOA_ID = @PESSOA_ID";
                    using (MySqlCommand deleteIdosoCommand = new MySqlCommand(deleteIdosoQuery, connection))
                    {
                        deleteIdosoCommand.Parameters.AddWithValue("@PESSOA_ID", PESSOA_ID);
                        deleteIdosoCommand.ExecuteNonQuery();
                    }

                    // Remova o registro da tabela Pessoa
                    string deletePessoaQuery = "DELETE FROM Pessoa WHERE ID = @ID";
                    using (MySqlCommand deletePessoaCommand = new MySqlCommand(deletePessoaQuery, connection))
                    {
                        deletePessoaCommand.Parameters.AddWithValue("@ID", ID);
                        deletePessoaCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Idoso e pessoa removidos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao remover idoso: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
