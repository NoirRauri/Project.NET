using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Enums;
using Utility.Excepciones;

namespace ProyectoINAForms
{
    public partial class frmClientes : Form
    {
        //Instancia para ir a la capade  negocio
        TipoClientesBL tipoClienteIns = new TipoClientesBL();
        ClientesBL clienteIns = new ClientesBL();

        //para saber si  estamos creando o modificando
        private bool isCreated;

        public tbClientes clientes { set; get; }

        public frmClientes()
        {
            InitializeComponent();
        }

     

           private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarCombos();
            isCreated = clientes == null ? true : false;

            if (isCreated)
            {
                lblTitulo.Text = "Crear Cliente";
            }else
            {
                lblTitulo.Text = "Modificar Cliente";
                //MessageBox.Show("Modificar cliente");
                cargarForm();
                mskCedula.Enabled = false;
            }

        }

        private void cargarForm()
        {
            try
            {
                mskCedula.Text = clientes.cedula.Trim();
                txtNombre.Text = clientes.tbPersona.nombre.Trim().ToUpper();
                txtApellido1.Text = clientes.tbPersona.apellido1.Trim().ToUpper();
                txtApellido2.Text = clientes.tbPersona.apellido2.Trim().ToUpper();
                cbGenero.SelectedIndex = clientes.tbPersona.genero == 1 ? (int)EnumsTypes.Genero.Masculino : clientes.tbPersona.genero == 2 ? (int)EnumsTypes.Genero.Femenino: (int)EnumsTypes.Genero.Indefinido;
                dTPFechaNacimiento.Value = clientes.tbPersona.fechaNac;
                cbTipoCliente.SelectedValue = clientes.tipoCliente;
                nUDDescuento.Value = clientes.descMax;
                if (clientes.foto!=null)
                {
                    pBFoto.Image = Utilidades.convertByteToImage(clientes.foto);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }

        private void cargarCombos()
        {
            var lista = tipoClienteIns.obtenerTodos();

            cbTipoCliente.DataSource = lista;
            cbTipoCliente.DisplayMember = "nombre";
            cbTipoCliente.ValueMember = "id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            { //en caso de que se guardo, muestro mensaje
                if (guardar())
                {
                    MessageBox.Show("Se guardo correctamente el usuario");
                }
                this.Close();

            }

            catch (EntityExistDBException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            catch (ValidationException){
                MessageBox.Show("Excepcion en la  validacion");
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
                tbClientes cliente;

                if (isCreated)
                {
                    cliente = new tbClientes();
                    tbPersona persona = new tbPersona();
                    persona.cedula = mskCedula.Text;
                    persona.nombre = txtNombre.Text;
                    persona.apellido1 = txtApellido1.Text;
                    persona.apellido2 = txtApellido2.Text;
                    persona.genero = cbGenero.Text.ToUpper() == "Masculino" ? 1 : cbGenero.Text.Trim().ToUpper() == "FEMENINO" ? 2 : 3;
                    persona.fechaNac = dTPFechaNacimiento.Value;

                    cliente.estado = true;
                    cliente.tbPersona = persona;
                    cliente.cedula = mskCedula.Text;
                }
                else
                {
                    cliente = this.clientes;

                    cliente.tbPersona.nombre = txtNombre.Text;
                    cliente.tbPersona.apellido1 = txtApellido1.Text;
                    cliente.tbPersona.apellido2 = txtApellido2.Text;
                    cliente.tbPersona.genero = cbGenero.Text.ToUpper() == "Masculino" ? 1 : cbGenero.Text.Trim().ToUpper() == "FEMENINO" ? 2 : 3;
                    cliente.tbPersona.fechaNac = dTPFechaNacimiento.Value;
                }
                
                cliente.descMax =(int)nUDDescuento.Value;
                cliente.tipoCliente = (int)cbTipoCliente.SelectedValue;

                if (pBFoto.Image != null)
                {
                    cliente.foto = Utilidades.convertImageToByte(pBFoto.Image);
                }


                if (isCreated)
                {
                    clienteIns.guardar(cliente);
                    btnCancel.Enabled = false;
                }
                else
                {
                    clienteIns.modificar(cliente);
                    btnCancel.Enabled = true;
                }

                return true;

            }
            else
            {
                MessageBox.Show("No se guardo. Veriifique datos");
                return false;
            }
        }

        private bool validar()
        {//validaciones de datos de entrada
            if(mskCedula.Text==String.Empty)
            {
                MessageBox.Show("Falta la cedula");
                return false;
            }
            else if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Falta el nombre");
                return false;
            }
            else if (txtApellido1.Text == String.Empty)
            {
                MessageBox.Show("Falta el primer apellido");
                return false;
            }
            else if (txtApellido2.Text == String.Empty)
            {
                MessageBox.Show("Falta el segundo apellido");
                return false;
            }
            else if (cbGenero.Text == String.Empty)
            {
                MessageBox.Show("Falta el genero");
                return false;
            }
            else if (cbTipoCliente.Text == String.Empty)
            {
                MessageBox.Show("Falta el tipo de cliente");
                return false;
            }
            else if (nUDDescuento.Text == String.Empty)
            {
                MessageBox.Show("Falta el descuento");
                return false;
            }


            return true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // eliminar
            try
            {
                DialogResult resp = MessageBox.Show("Eliminar", "¿Decea eliminar e cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp==DialogResult.Yes)
                {
                    clientes.estado = false;
                    if (clienteIns.eliminar(clientes))
                    {
                        MessageBox.Show("El Cliente a sido eliminado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo elimniar el cliente de la basa de datos");
                    }

                }
                else
                {
                    MessageBox.Show("El cliente no se elimino");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pBFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    string ruta = openFileDialog1.FileName;
                    pBFoto.Image = Image.FromFile(ruta);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo no es tipo imagen");
            }
        }
    }
}
