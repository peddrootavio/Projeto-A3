using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;

namespace Cadastrosdeclientes.Controller
{
    public class Login
    {
        // Campo para armazenar a string de conexão
        private string connectionString;

        // Construtor que recebe a string de conexão como parâmetro
        public Login(string connectionString)
        {
            this.connectionString = connectionString;  // Inicializa o campo connectionString com o valor passado
        }

        // Método para validar o login e senha
        public bool ValidarLogin(string usuario, string senha) // Define um método público que valida o login e senha
        {
            bool isValid = false; // Inicializa uma variável booleana para indicar se o login é válido
            //Inicializa isValid como false. Isso significa que, por padrão, o login é considerado inválido até que se prove o contrário.

            // Estabelecendo a conexão com o banco de dados MySQL
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Cria uma conexão com o banco de dados MySQL
            {
                connection.Open(); // Abre a conexão com o banco de dados
                string query = "SELECT COUNT(1) FROM recepcionista WHERE usuario = @usuario AND senha = @senha"; // Define a consulta SQL
                using (MySqlCommand command = new MySqlCommand(query, connection)) // Cria um comando SQL para executar a consulta
                {
                    // Adicionando parâmetros para evitar SQL Injection
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    // Executando o comando e verificando se existe um usuário com o nome e senha fornecidos
                    int login = Convert.ToInt32(command.ExecuteScalar()); // o executeScalar recebe um valor object e convertemo pelo int.
                    // Executa a consulta e converte o resultado para um inteiro
                    // ExecuteScalar retorna a primeira coluna da primeira linha no conjunto de resultados

                    isValid = login > 0;
                    // verifica se o valor da variável login é maior que zero e contem o resultado dessa verificação na variável isValid
                    // se login for maior que 0 sera definido como true, issso significa que existe pelo menos um registro na tabela de usuario.
                    // logim for > 0 verifica se existe pelo menos um registro correspondente na tabelaa.

                }
            }

            return isValid; // Retorna verdadeiro se o login for válido, se for invalido, retorna falso
        }
    }
}
