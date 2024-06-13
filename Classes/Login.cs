using MySql.Data.MySqlClient;
using System;

namespace Cadastrosdeclientes.Controller
{
    public class Login
    {
        private string connectionString;

        public Login(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool ValidarLogin(string usuario, string senha)
        {
            bool isValid = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM recepcionista WHERE usuario = @usuario AND senha = @senha";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    int login = Convert.ToInt32(command.ExecuteScalar());
                    isValid = login > 0;
                }
            }

            return isValid;
        }
    }
}
