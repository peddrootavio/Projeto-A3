using MySql.Data.MySqlClient;
using System;

namespace Cadastrosdeclientes.Controller
{
    public class ValidadorLogin
    {
        // Campo para armazenar a string de conexão
        private string connectionString;

        // Construtor que recebe a string de conexão como parâmetro
        public ValidadorLogin(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Método para validar o login
        public bool ValidarLogin(string usuario, string senha)
        {
            bool isValid = false;

            // Estabelecendo a conexão com o banco de dados MySQL
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM usuario WHERE usuario = @usuario AND senha = @senha";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Adicionando parâmetros para evitar SQL Injection
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    // Executando o comando e verificando se existe um usuário com o nome e senha fornecidos
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    isValid = count > 0;
                }
            }

            return isValid; // Retorna verdadeiro se o login for válido, caso contrário, retorna falso
        }
    }
}
