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
        List<tbClientes> lista;
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            try
            {
                lista = clientesIns.obtenerTodos();
                cargarLista(lista);
            }
            catch (Exception)
            {
                MessageBox.Show("Se genero un error al cargar la lista de clientes");
            }
        }

        private void cargarLista(List<tbClientes> lista)
        {
            // LIMPIAR EL LISTVIEW 

            lstvListaClientes.Items.Clear();

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
            // cargar la lista nueva
            obtenerDatos();
        }

        private void lstvListaClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cedula = ((ListView)sender).SelectedItems[0].Text;

            var cliente = lista.Where(x => x.cedula.Trim() == cedula.Trim()).SingleOrDefault();

            frmClientes formClientes = new frmClientes();
            formClientes.cliente= cliente;
            formClientes.ShowDialog();
        }
    }
}
