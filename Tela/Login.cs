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
       
        private Login validadorLogin;
        //Declaração de uma variável privada do tipo ValidadorLogin 
        //Esta variável será usada para armazenar uma instância da classe ValidadorLogin

        public FrmCadastro()
        {
            // Inicializa os componentes do formulário.
            InitializeComponent();
            
            
           string connectionString =
        System.Configuration.ConfigurationManager
       .ConnectionStrings["MySqlConnectionString"]
       .ConnectionString;

        validadorLogin = new Login(connectionString);
          // A instância é armazenada na variável validadorLogin declarada anteriormente.      
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

        private void ValidarUsuario() //Criando um metodo privado, que nao retorna nada por ser void.
        {
            string usuario = txbUsuario.Text; //ler o texto do campo de entrada txbUsuario e o armazena na variável usuario.
            string senha = txbSenha.Text; ///ler o texto do campo de entrada txbUsuario e o armazena na variável senha.

            bool isValid = validadorLogin.ValidarLogin(usuario, senha); // Chama o método ValidarLogin do objeto validadorLogin com as credenciais
                                                                        // fornecidas e armazena o resultado na variavel isValid

            if (isValid == true)
            {
                MessageBox.Show("Login bem-sucedido!", "Login",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Painel entrar = new Painel(); //Cria uma nova instância do formulário Painel.
                entrar.Show(); //pra exibir o formulario painel
                this.Hide(); // Esconde o formulário de login ao fazer login com as credencias certass
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
