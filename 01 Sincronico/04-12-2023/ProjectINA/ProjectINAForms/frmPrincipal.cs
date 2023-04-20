using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectINAForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cierra todo el aplicativo
            Application.Exit();

            // cierre la ventana
            // this.Close();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaClientes form = new frmListaClientes();
            form.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaUsuarios frm = new frmListaUsuarios();
            frm.Show();
        }
    }
}
