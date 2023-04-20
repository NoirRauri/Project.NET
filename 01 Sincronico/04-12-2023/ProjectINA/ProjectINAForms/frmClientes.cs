using BL;
using Entities;
using System;
using Utilities.Exceptions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectINAForms
{
    public partial class frmClientes : Form
    {
        public tbClientes cliente { get; set; }
        // instacia para ir a la capa BL 
        TipoClientesBL tipoClientesIns=new TipoClientesBL();
        ClientesBL clienteIns=new ClientesBL();

        private bool isCreate;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarCambos();
            isCreate = cliente == null ? true : false;

            if (isCreate)
            {
                lblTitulo.Text = "Crear Cliente";
            }
            else
            {
                lblTitulo.Text = "Modificar Cliente";
            }
        }

        private void cargarCambos()
        {
            var lista = tipoClientesIns.obtenerTodos();

            cbxTipoCliente.DataSource = lista;
            cbxTipoCliente.DisplayMember = "nombre";
            cbxTipoCliente.ValueMember = "id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardar()) 
                {
                    MessageBox.Show("El cliente  se guardo  correctamente.");
                }
            }
            catch (EntityExistsDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private bool guardar()
        {
            if (validar())
            {
                // guardar
                tbClientes clientes = new tbClientes();
                clientes.cedula = mskCedula.Text;
                clientes.descMax=(int)nupDescuento.Value;
                clientes.tipoCliente = (int)cbxTipoCliente.SelectedValue;
                clientes.foto = null;

                tbPersona persona = new tbPersona();
                persona.cedula=mskCedula.Text;
                persona.nombre = txtNombre.Text;
                persona.apellido1 = txtApellido1.Text;
                persona.apellido2= txtApellido2.Text;
                persona.genero = cbxGenero.Text.Trim().ToUpper()=="MASCULINO" ? 1: cbxGenero.Text.Trim().ToUpper()=="FEMENINO" ? 2:3;
                persona.fechaNac=dtpFechaNac.Value;

                clientes.tbPersona= persona;

                clienteIns.guardar(clientes);
                return true;
            }
            else
            {
                MessageBox.Show("No se guardo. Verifique Datos!!!");
                return false;
            }
        }

        private bool validar()
        {
            if (mskCedula.Text == string.Empty)
            {
                MessageBox.Show("Falta cedula");
                return false;
            }
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Falta el Nombre");
                return false;
            }
            else if (txtApellido1.Text == string.Empty)
            {
                MessageBox.Show("Falta el .primer apellido");
                return false;
            }
            else if (txtApellido2.Text == string.Empty)
            {
                MessageBox.Show("Falta el segundo apellido");
                return false;
            }
            else if (cbxGenero.Text == string.Empty)
            {
                MessageBox.Show("Falta el genero");
                return false;
            }
            else if (cbxTipoCliente.Text == string.Empty)
            {
                MessageBox.Show("Falta el tipo cliente");
                return false;
            }
            else if (nupDescuento.Text == string.Empty)
            {
                MessageBox.Show("Falta el descuento");
                return false;
            }
            return true;
        }
    }
}
