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
    public partial class frmListaUsuarios : Form
    {
        UsuariosBL usuariosIns=new UsuariosBL();
        List<tbUsuarios> lista;
        public frmListaUsuarios()
        {
            InitializeComponent();
        }

        private void frmListaUsuarios_Load_1(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            try
            {
                //cuando el forms cargue tengo el metodo de obtener todos los clientes
                lista = usuariosIns.obtenerTodos();
                cargarLista(lista);
                

            }
            catch (Exception)
            {

                MessageBox.Show("Se genero un error al cargar una lista de usuarios");
            }
        }

        private void cargarLista(List<tbUsuarios> lista)
        {//muestro los clientes en el forms


            //A la hora  de cargar la  lista debemos de limpiar la lista para
            //caerle encima, asi evitamos que se muestren datos repetidos en la lista
            lstvUsuarios.Items.Clear();

            foreach (var usuario in lista)
            {
                //Hago  un item por cada elemento de la  lista
                ListViewItem item = new ListViewItem();

                //cargo los datos en cada uno de las colummas
                item.Text = usuario.cedula;
                item.SubItems.Add(usuario.tbPersona.apellido1.Trim().ToUpper());
                item.SubItems.Add(usuario.tbPersona.apellido2.Trim().ToUpper());
                item.SubItems.Add(usuario.nombre.Trim().ToUpper());
                item.SubItems.Add(usuario.tbRoles.rol.Trim().ToUpper());


                //agrego  el item al listview
                lstvUsuarios.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmCrearUsuario frm = new frmCrearUsuario();
            frm.ShowDialog();
            //cargar la lista nuevamente
            obtenerDatos();
        }

        private void lstvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cedula = ((ListView)sender).SelectedItems[0].Text;
            var user = lista.Where(x => x.cedula.Trim() == cedula.Trim()).SingleOrDefault();

            frmCrearUsuario formClientes = new frmCrearUsuario();
            formClientes.user = user;

            formClientes.ShowDialog();
        }
    }
}

