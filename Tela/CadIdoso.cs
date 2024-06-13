using Cadastrosdeclientes.Controller;
using Cadastrosdeclientes.Crud;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cadastrosdeclientes.View
{
    public partial class CadIdoso : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        private ReadIdoso readIdoso;

        public CadIdoso()
        {
            InitializeComponent();
            readIdoso = new ReadIdoso(connectionString);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = readIdoso.BuscarIdoso(txbId.Text, txbBuscarNome.Text, txbBuscarCpf.Text);
                gvIdoso.DataSource = dataTable;
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                if (string.IsNullOrWhiteSpace(txbDataEntrada.Text))
                {
                    MessageBox.Show("O campo Data de Entrada é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDataEntrada.Focus();
                    return;
                }

                // Validação e conversão das datas
                DateTime dataNascimento;
                if (!DateTime.TryParseExact(txbData.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dataNascimento))
                {
                    MessageBox.Show("Formato de data de nascimento inválido. Por favor, use o formato dd/MM/yyyy.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbData.Focus();
                    return;
                }

                DateTime dataEntrada;
                if (!DateTime.TryParseExact(txbDataEntrada.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dataEntrada))
                {
                    MessageBox.Show("Formato de data de entrada inválido. Por favor, use o formato dd/MM/yyyy.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDataEntrada.Focus();
                    return;
                }

                int idade = DateTime.Now.Year - dataNascimento.Year;
                if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

                if (idade > 120)
                {
                    throw new ArgumentException("Data de nascimento inválida. A idade não pode exceder 120 anos.", nameof(txbData));
                }

                string novaDataNascimento = dataNascimento.ToString("yyyy-MM-dd");
                string novaDataEntrada = dataEntrada.ToString("yyyy-MM-dd");

                Idoso novoIdoso = new Idoso(
                    tipo: chkIdoso.Text,
                    nome: txbNome.Text,
                    cpf: txbCpf.Text,
                    telefone: txbTelefone.Text,
                    dataNascimento: novaDataNascimento,
                    dataEntrada: novaDataEntrada
                );

                CreateIdoso createIdoso = new CreateIdoso();
                createIdoso.EnviarIdoso(novoIdoso);

                LimparFormulario();
            }
            catch (ArgumentException ex) when (ex.ParamName == "cpf")
            {
                MessageBox.Show(ex.Message, "Erro, CPF inválido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCpf.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de data inválido. Por favor, use o formato dd/MM/yyyy.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.Message.Contains("dataNascimento"))
                {
                    txbData.Focus();
                }
                else
                {
                    txbDataEntrada.Focus();
                }
            }
        }


        private void LimparFormulario()
        {
            txbId.Clear();
            txbNome.Clear();
            txbCpf.Clear();
            txbTelefone.Clear();
            txbData.Clear();
            txbDataEntrada.Clear();
            txbBuscarNome.Clear();
            txbBuscarCpf.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvIdoso.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = gvIdoso.SelectedRows[0];
                    int pessoaId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    DeleteIdoso deleteIdoso = new DeleteIdoso(connectionString);
                    deleteIdoso.ApagarIdoso(pessoaId, pessoaId);

                    btnBuscar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Selecione um idoso para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao remover o idoso: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gvIdoso.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvIdoso.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string novoNome = selectedRow.Cells["Nome"].Value.ToString();
                string novoCpf = selectedRow.Cells["CPF"].Value.ToString();
                string novoTelefone = selectedRow.Cells["Telefone"].Value.ToString();
                string novoTipo = selectedRow.Cells["Tipo"].Value.ToString();
                DateTime dataNascimento = Convert.ToDateTime(selectedRow.Cells["Data_Nascimento"].Value);
                DateTime dataEntrada = Convert.ToDateTime(selectedRow.Cells["Data_Entrada"].Value);
                string novaDataNascimento = dataNascimento.ToString("yyyy-MM-dd");
                string novaDataEntrada = dataEntrada.ToString("yyyy-MM-dd");

                UpdateIdoso updateIdoso = new UpdateIdoso(connectionString);
                updateIdoso.AtualizarIdoso(id, novoNome, novoCpf, novoTelefone, novoTipo, novaDataNascimento, novaDataEntrada);

                gvIdoso.Refresh();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
