using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoINAForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuCerrar_Click(object sender, EventArgs e)
        {
            //cerrar un formulario
            //this.Close();
           //Si quiero cerrar la aplicacion
           Application.Exit();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            //mostrar el forms de clientes
            frmListaCliente  form = new frmListaCliente();
            form.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            //mostrar el forms de usuarios
            frmListaUsuarios form = new frmListaUsuarios();
            form.Show();
        }
    }
}
