using Cadastrosdeclientes.View;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cadastrosdeclientes
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            // Inicializa os componentes do formulário.
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
           RegistrarUsuario registrar = new RegistrarUsuario();
            registrar.Show();
            
        }

        private void lblLogotipo_Click(object sender, EventArgs e)
        {

        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
