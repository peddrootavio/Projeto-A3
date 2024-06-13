using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cadastrosdeclientes.Crud
{
    internal class DeleteCuidador
    {
        private string connectionString;

        public DeleteCuidador(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ApagarCuidador(int PESSOA_ID, int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Remova o registro da tabela Cuidador
                    string deleteCuidadorQuery = "DELETE FROM cuidador WHERE PESSOA_ID = @PESSOA_ID";
                    using (MySqlCommand deleteCuidadorCommand = new MySqlCommand(deleteCuidadorQuery, connection))
                    {
                        deleteCuidadorCommand.Parameters.AddWithValue("@PESSOA_ID", PESSOA_ID);
                        deleteCuidadorCommand.ExecuteNonQuery();
                    }

                    // Remova o registro da tabela Pessoa
                    string deletePessoaQuery = "DELETE FROM Pessoa WHERE ID = @ID";
                    using (MySqlCommand deletePessoaCommand = new MySqlCommand(deletePessoaQuery, connection))
                    {
                        deletePessoaCommand.Parameters.AddWithValue("@ID", ID);
                        deletePessoaCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cuidador removidos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao remover Cuidador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
