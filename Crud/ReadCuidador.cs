using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Cadastrosdeclientes.Controller
{
    public class ReadCuidador
    {
        private string connectionString;

        // Construtor para inicializar a string de conexão
        public ReadCuidador(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Método para carregar dados
        public DataTable BuscarCuidador(string id, string nome, string cpf)
        {
            DataTable table = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        p.id, 
                        p.tipo, 
                        p.nome, 
                        p.cpf, 
                        p.telefone, 
                        p.data_nascimento, 
                        i.matricula
                    FROM 
                        pessoa p
                    INNER JOIN 
                        cuidador i 
                    ON 
                        p.id = i.pessoa_id
                    WHERE 
                        (@id IS NULL OR p.id = @id) AND
                        (@nome IS NULL OR p.nome LIKE @nome) AND
                        (@cpf IS NULL OR p.cpf LIKE @cpf)";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                // Adicionar parâmetros para a consulta
                adapter.SelectCommand.Parameters.AddWithValue("@id", string.IsNullOrEmpty(id) ? (object)DBNull.Value : Convert.ToInt32(id));
                adapter.SelectCommand.Parameters.AddWithValue("@nome", string.IsNullOrEmpty(nome) ? (object)DBNull.Value : "%" + nome + "%");
                adapter.SelectCommand.Parameters.AddWithValue("@cpf", string.IsNullOrEmpty(cpf) ? (object)DBNull.Value : "%" + cpf + "%");

                adapter.Fill(table);
            }

            return table;
        }
    }
}
