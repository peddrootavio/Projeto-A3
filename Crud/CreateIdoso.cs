using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Cadastrosdeclientes.Crud
{
    public class CreateIdoso
    {
        private string connectionString =
           System.Configuration.ConfigurationManager
           .ConnectionStrings["MySqlConnectionString"]
           .ConnectionString;

        public void EnviarIdoso(Idoso idoso)
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
                    cmdPessoa.Parameters.AddWithValue("@Tipo", idoso.Tipo);
                    cmdPessoa.Parameters.AddWithValue("@Nome", idoso.Nome);
                    cmdPessoa.Parameters.AddWithValue("@Cpf", idoso.Cpf);
                    cmdPessoa.Parameters.AddWithValue("@Telefone", idoso.Telefone);
                    cmdPessoa.Parameters.AddWithValue("@Data_Nascimento", idoso.DataNascimento);


                    int pessoaId = Convert.ToInt32(cmdPessoa.ExecuteScalar());

                    string insertIdosoQuery = @"INSERT INTO Idoso (Pessoa_id, Data_Entrada)
                                            VALUES (@Pessoa_id, @Data_Entrada)";

                    MySqlCommand cmdIdoso = new MySqlCommand(insertIdosoQuery, conn);
                    cmdIdoso.Transaction = transaction;
                    cmdIdoso.Parameters.AddWithValue("@Pessoa_id", pessoaId);
                    cmdIdoso.Parameters.AddWithValue("@Data_Entrada", idoso.DataEntrada);

                    cmdIdoso.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Dados inseridos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
