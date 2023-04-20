using BL;
using Entities;
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
    public partial class frmListaClientes : Form
    {
        ClientesBL clientesIns = new ClientesBL();
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            var lista = clientesIns.obtenerTodos();
            cargarLista(lista);
        }

        private void cargarLista(List<tbClientes> lista)
        {
            foreach (var clientes in lista)
            {
                ListViewItem item = new ListViewItem();
                item.Text= clientes.cedula;
                item.SubItems.Add(clientes.tbPersona.nombre.Trim().ToUpper());
                item.SubItems.Add(clientes.tbPersona.apellido1.Trim().ToUpper());
                item.SubItems.Add(clientes.tbPersona.apellido2.Trim().ToUpper());

                lstvListaClientes.Items.Add(item);  
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }
    }
}
