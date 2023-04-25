using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Utilities.Excepsiones;

namespace MemoryGame
{
    public partial class frmRegistrar : Form
    {
        UsuarioBL usuarioIns = new UsuarioBL();
        JugadoresBL jugadorIns = new JugadoresBL();

        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
                limpiarRegistro();
                MessageBox.Show(ex.Message);
            }

            catch (ValidationException)
            {
                MessageBox.Show("Excepcion en la  validacion");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void limpiarRegistro()
        {
            mskCedula.Clear();
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
        }

        private bool guardar()
        {
            if (validar())
            {
                tbUsuarios usuario;

                usuario = new tbUsuarios();
                tbJugadores jugador = new tbJugadores();

                jugador.cedula = mskCedula.Text;
                jugador.name = txtNombre.Text.ToUpper();
                jugador.apellido1 = txtApellido1.Text.ToUpper();
                jugador.apellido2 = txtApellido2.Text.ToUpper();
                jugador.fechaIngreso = DateTime.Now;

                usuario.cedula = mskCedula.Text.ToUpper();
                usuario.usuario = txtUsuario.Text.ToUpper();
                usuario.password = txtPassword.Text.ToUpper();
                usuario.tbJugadores = jugador;

                usuarioIns.guardar(usuario);

                return true;

            }
            else
            {
                MessageBox.Show("No se guardo. Veriifique datos");
                return false;
            }
        }

        private bool validar()
        {
            //validaciones de datos de entrada
            if (mskCedula.Text == String.Empty)
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
            else if (txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Falta el usuario");
                return false;
            }
            else if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Falta la contraseña");
                return false;
            }

            return true;

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskCedula_TextChanged(object sender, EventArgs e)
        {
            validarRegistro(mskCedula.Text,txtNombre.Text,txtApellido1.Text,txtApellido2.Text,txtUsuario.Text, txtPassword.Text);
        }

        private bool loginCompleto = false;
        private void validarRegistro(string cedula,string nombre, string apellido1, string apellido2 ,string usuario, string password)
        {
            loginCompleto = !string.IsNullOrEmpty(cedula) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido1) && !string.IsNullOrEmpty(apellido2)
                && !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password);

            btnRegistrar.Enabled = loginCompleto;
        }
    }
}
