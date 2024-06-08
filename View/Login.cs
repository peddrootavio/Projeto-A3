using Cadastrosdeclientes.Controller;
using Cadastrosdeclientes.View;
using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cadastrosdeclientes
{
    public partial class FrmCadastro : Form
    {
       
        private ValidadorLogin validadorLogin;

        public FrmCadastro()
        {
            // Inicializa os componentes do formulário.
            InitializeComponent();
            
            
           string connectionString =
        System.Configuration.ConfigurationManager
       .ConnectionStrings["MySqlConnectionString"]
       .ConnectionString;

            validadorLogin = new ValidadorLogin(connectionString);

                   

        }


    private void FrmCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada (keyCode) é Enter (Keys.Enter).
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}"); //Toda vez o C# identificar que apertei a tecla ENTER, irá enviar a tecla TAB.
                e.SuppressKeyPress = true; //Propriedade para desabilitar retorno de som ao clicar ENTER.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
         

        }
        private void ValidarUsuario()
        {
            string usuario = txbUsuario.Text;
            string senha = txbSenha.Text;

            bool isValid = validadorLogin.ValidarLogin(usuario, senha);

            if (isValid)
            {
                MessageBox.Show("Login bem-sucedido!");
                Painel entrar = new Painel();
                entrar.Show();
                this.Hide(); // Esconde o formulário de login ao fazer login com sucesso
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
                txbSenha.Clear(); // Limpa o campo de senha
                txbSenha.Focus(); // Define o foco de volta para o campo de senha
            }
        }
    }
}
