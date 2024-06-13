using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Cadastrosdeclientes.Crud
{
    public class CreateCuidador
    {
        private string connectionString =
           System.Configuration.ConfigurationManager
           .ConnectionStrings["MySqlConnectionString"]
           .ConnectionString;

        public void EnviarCuidador(Cuidador cuidador)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    string insertPessoaQuery = @"INSERT INTO Pessoa (Tipo, Nome, Cpf, Telefone, Data_Nascimento)
                                             VALUES (@Tipo, @Nome, @Cpf, @Telefone, @Data_Nascimento);
                                             SELECT LAST_INSERT_ID();";

                    MySqlCommand cmdPessoa = new MySqlCommand(insertPessoaQuery, conn);
                    cmdPessoa.Transaction = transaction;
                    cmdPessoa.Parameters.AddWithValue("@Tipo", cuidador.Tipo);
                    cmdPessoa.Parameters.AddWithValue("@Nome", cuidador.Nome);
                    cmdPessoa.Parameters.AddWithValue("@Cpf", cuidador.Cpf);
                    cmdPessoa.Parameters.AddWithValue("@Telefone", cuidador.Telefone);
                    cmdPessoa.Parameters.AddWithValue("@Data_Nascimento", cuidador.DataNascimento);


                    int pessoaId = Convert.ToInt32(cmdPessoa.ExecuteScalar());

                    string insertCuidadorQuery = @"INSERT INTO Cuidador (Pessoa_id, Matricula)
                                            VALUES (@Pessoa_id, @Matricula)";

                    MySqlCommand cmdIdoso = new MySqlCommand(insertCuidadorQuery, conn);
                    cmdIdoso.Transaction = transaction;
                    cmdIdoso.Parameters.AddWithValue("@Pessoa_id", pessoaId);
                    cmdIdoso.Parameters.AddWithValue("@Matricula", cuidador.Matricula);

                    cmdIdoso.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Dados inseridos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Rollback transaction if any error occurs
                    transaction.Rollback();
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
