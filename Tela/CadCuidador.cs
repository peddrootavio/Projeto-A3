using Cadastrosdeclientes.Controller;
using Cadastrosdeclientes.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrosdeclientes.View
{
    public partial class CadCuidador : Form
    {
        // Declaração da string de conexão com o banco de dados, obtida do arquivo de configuração
        private string connectionString =
            System.Configuration.ConfigurationManager
            .ConnectionStrings["MySqlConnectionString"]
            .ConnectionString;

        private ReadCuidador readCuidador;

        public CadCuidador()
        {

            InitializeComponent();
            readCuidador = new ReadCuidador(connectionString); // Inicializa a instância de ReadCuidador com a string de conexão

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificação de campos obrigatórios
                if (string.IsNullOrWhiteSpace(txbNome.Text))
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbNome.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbCpf.Text))
                {
                    MessageBox.Show("O campo CPF é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbCpf.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbTelefone.Text))
                {
                    MessageBox.Show("O campo Telefone é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbTelefone.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbData.Text))
                {
                    MessageBox.Show("O campo Data de Nascimento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbData.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbMatricula.Text))
                {
                    MessageBox.Show("O campo Matrícula é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMatricula.Focus();
                    return;
                }

                // Validação e conversão da data de nascimento
                DateTime dataNascimento;
                if (!DateTime.TryParseExact(txbData.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dataNascimento))
                {
                    MessageBox.Show("Formato de data de nascimento inválido. Por favor, use o formato dd/MM/yyyy.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbData.Focus();
                    return;
                }

                int idade = DateTime.Now.Year - dataNascimento.Year;
                if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

                if (idade > 120)
                {
                    throw new ArgumentException("Data de nascimento inválida. A idade não pode exceder 120 anos.", nameof(txbData));
                }

                string novaDataNascimento = dataNascimento.ToString("yyyy-MM-dd");

                // Cria uma nova instância de Cuidador com os dados fornecidos
                Cuidador novoCuidador = new Cuidador(
                    tipo: chkCuidador.Text,
                    nome: txbNome.Text,
                    cpf: txbCpf.Text,
                    dataNascimento: novaDataNascimento,
                    telefone: txbTelefone.Text,
                    matricula: txbMatricula.Text
                );

                // Cria uma nova instância de CreateCuidador e envia os dados do novo cuidador para o banco
                CreateCuidador createCuidador = new CreateCuidador();
                createCuidador.EnviarCuidador(novoCuidador);

                LimparFormulario(); // Limpa o formulário após o cadastro
            }
            catch (FormatException) // Trata exceções de formato de data
            {
                // Exibe uma mensagem de erro caso a data esteja em um formato inválido
                MessageBox.Show("Formato de data inválido. Por favor, use o formato dd/MM/yyyy.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbData.Focus(); // Foca no campo de data de nascimento
            }
            catch (ArgumentException ex) when (ex.ParamName == nameof(txbData)) // Trata exceções de argumento para a data de nascimento
            {
                // Exibe uma mensagem de erro caso a data de nascimento seja inválida
                MessageBox.Show(ex.Message, "Erro de Data de Nascimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbData.Focus(); // Foca no campo de data de nascimento
            }
            catch (ArgumentException ex) when (ex.ParamName == "cpf") // Trata exceções de argumento para o CPF
            {
                // Exibe uma mensagem de erro caso o CPF seja inválido
                MessageBox.Show(ex.Message, "Erro de CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCpf.Focus(); // Foca no campo de CPF
            }
            catch (Exception ex) // Trata qualquer outra exceção
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpar todos os campos do formulário
        private void LimparFormulario()
        {
            txbId.Clear(); // Limpa o campo ID
            txbNome.Clear(); // Limpa o campo Nome
            txbCpf.Clear(); // Limpa o campo CPF
            txbTelefone.Clear(); // Limpa o campo Telefone
            txbData.Clear(); // Limpa o campo Data de Nascimento
            txbBuscarNome.Clear(); // Limpa o campo de busca Nome
            txbBuscarCpf.Clear(); // Limpa o campo de busca CPF
            txbMatricula.Clear(); // Limpa o campo Matrícula
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Busca dados do cuidador com base nos critérios fornecidos e os exibe no GridView
                DataTable dataTable = readCuidador.BuscarCuidador(
                    txbId.Text,
                    txbBuscarNome.Text,
                    txbBuscarCpf.Text
                );

                gvCuidador.DataSource = dataTable; // Define a fonte de dados do GridView
                LimparFormulario(); // Limpa o formulário após a busca
            }
            catch (Exception ex) // Trata qualquer exceção que ocorra
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Ocorreu um erro ao buscar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gvCuidador.SelectedRows.Count > 0) // Verifica se há linhas selecionadas no GridView
            {
                DataGridViewRow selectedRow = gvCuidador.SelectedRows[0]; // Obtém a linha selecionada

                // Converte e obtém os dados da linha selecionada
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string novoNome = selectedRow.Cells["Nome"].Value.ToString();
                string novoCpf = selectedRow.Cells["CPF"].Value.ToString();
                string novoTelefone = selectedRow.Cells["Telefone"].Value.ToString();
                string novoTipo = selectedRow.Cells["Tipo"].Value.ToString();
                string novaMatricula = selectedRow.Cells["Tipo"].Value.ToString();

                DateTime dataNascimento = Convert.ToDateTime(selectedRow.Cells["Data_Nascimento"].Value);
                string novaDataNascimento = dataNascimento.ToString("yyyy-MM-dd");

                // Cria uma nova instância de UpdateCuidador e atualiza os dados do cuidador no banco de dados
                UpdateCuidador updateCuidador = new UpdateCuidador(connectionString);
                updateCuidador.AtualizarCuidador(id, novoNome, novoCpf, novoTelefone, novoTipo, novaDataNascimento, novaMatricula);

                gvCuidador.Refresh(); // Atualiza o GridView
            }
            else
            {
                // Exibe uma mensagem de aviso caso nenhuma linha esteja selecionada
                MessageBox.Show("Selecione uma linha para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gvCuidador.SelectedRows.Count > 0) // Verifica se há linhas selecionadas no GridView
                {
                    DataGridViewRow selectedRow = gvCuidador.SelectedRows[0]; // Obtém a linha selecionada
                    int pessoaId = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Converte o valor do ID para inteiro
                    int cuidadorId = pessoaId; // Define o ID do cuidador como o ID da pessoa (redundante, mas mantido aqui)

                    // Cria uma nova instância de DeleteCuidador e apaga o cuidador do banco de dados
                    DeleteCuidador deleteCuidador = new DeleteCuidador(connectionString);
                    deleteCuidador.ApagarCuidador(pessoaId, cuidadorId);

                    btnBuscar_Click(sender, e); // Atualiza o GridView após a exclusão
                }
                else
                {
                    // Exibe uma mensagem de aviso caso nenhuma linha esteja selecionada
                    MessageBox.Show("Selecione um cuidador para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) // Trata qualquer exceção que ocorra
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção ao remover o cuidador
                MessageBox.Show("Ocorreu um erro ao remover o cuidador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
