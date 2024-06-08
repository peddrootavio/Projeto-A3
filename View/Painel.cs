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
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void btnIdoso_Click(object sender, EventArgs e)
        {
            CadIdoso registroidoso = new CadIdoso();
            registroidoso.Show();
        }

        private void btnCuidador_Click(object sender, EventArgs e)
        {
            CadCuidador registrocuidador = new CadCuidador();   
            registrocuidador.Show();
        }
    }
}
