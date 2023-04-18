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
            foreach (var cliente in lista)
            {
                ListViewItem item = new ListViewItem(); 
                item.Text = cliente.cedula;
                item.SubItems.Add(cliente.tbPersona.nombre.Trim().ToLower());
                item.SubItems.Add(cliente.tbPersona.apellido1.Trim().ToLower());
                item.SubItems.Add(cliente.tbPersona.apellido2.Trim().ToLower());

                lstvListaClientes.Items.Add(item);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
          
        }
    }
}
