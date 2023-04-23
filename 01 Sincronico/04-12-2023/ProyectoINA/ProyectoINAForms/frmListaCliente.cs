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

namespace ProyectoINAForms
{
    public partial class frmListaCliente : Form
    {
        ClientesBL clientesIns = new ClientesBL();
        List<tbClientes> lista;
        public frmListaCliente()
        {
            InitializeComponent();
        }

        private void frmListaCliente_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos() 
        {

            try
            {
            //cuando el forms cargue tengo el metodo de obtener todos los clientes
            lista = clientesIns.obtenerTodos();
            cargarLista(lista);

            }
            catch (Exception)
            {

                MessageBox.Show("Se genero un error al cargar una lista de clientes");
            }
        }

        private void cargarLista(List<tbClientes> lista)
        {//muestro los clientes en la lista clientes

            //A la hora  de cargar la  lista debemos de limpiar la lista para
            //caerle encima, asi evitamos que se muestren datos repetidos en la lista
            lstvClientes.Items.Clear();

            foreach(var cliente in lista) 
            {
                //Hago  un item por cada elemento de la  lista
                ListViewItem item = new ListViewItem();

                //cargo los datos en cada uno de las colummas
                item.Text = cliente.cedula;
                item.SubItems.Add(cliente.tbPersona.nombre.Trim().ToUpper());
                item.SubItems.Add(cliente.tbPersona.apellido1.Trim().ToUpper());
                item.SubItems.Add(cliente.tbPersona.apellido2.Trim().ToUpper());
                //agrego  el item al listview
                lstvClientes.Items.Add(item);
            }
        }

        private void btnAgregrar_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.ShowDialog();
            //cargar la lista nuevamente
            obtenerDatos();
        }

    

        private void lstvClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //al darle doble click ya sea al nombre cedula etc(items o subitems) 
            // y que podamos modificar un cliente


            var cedula = ((ListView)sender).SelectedItems[0].Text;
            var cliente = lista.Where(x => x.cedula.Trim() == cedula.Trim()).SingleOrDefault();

            frmClientes formClientes = new frmClientes();
            formClientes.clientes = cliente;

            formClientes.ShowDialog();
            // refresco datos despues de modificar
            obtenerDatos();
        }

        private void lstvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == String.Empty)
            {
                cargarLista(lista);
            }
            else
            {
                var listaFiltrada = lista.Where(x => x.cedula.Trim().Contains(txtSearch.Text) || 
                x.tbPersona.nombre.Trim().Contains(txtSearch.Text) ||
                x.tbPersona.apellido1.Trim().Contains(txtSearch.Text) ||
                x.tbPersona.apellido2.Trim().Contains(txtSearch.Text)).ToList();
                cargarLista(listaFiltrada);
            }
        }
    }
}
