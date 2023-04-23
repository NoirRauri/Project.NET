using BL;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Excepciones;

namespace ProyectoINAForms
{
    public partial class frmCrearUsuario : Form
    {
        RolesBl rolesIns = new RolesBl(); 
        UsuariosBL usuariosIns= new UsuariosBL();

        private bool isCreated;
        public tbUsuarios user { set; get; }

        public frmCrearUsuario()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            cargarCombos();
            isCreated = user == null ? true : false;

            if (isCreated)
            {
                lblTitulo.Text = "Crear Usuario";
            }
            else
            {
                lblTitulo.Text = "Modificar Usuario";
                MessageBox.Show("Modificar Usuario");
            }
        }

        private void cargarCombos()
        {
            var lista = rolesIns.obtenerTodos();

            cbRol.DataSource = lista;
            cbRol.DisplayMember = "nombre";
            cbRol.ValueMember = "idRol";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //en caso de que se guardo, muestro mensaje
                if (guardar()) {
                    MessageBox.Show("Se guardo correctamente el usuario");
                }
                this.Close();

            }
            catch (EntityExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (ValidationException)
            {
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
                tbUsuarios user = new tbUsuarios();
                user.cedula = mskCedulaUsers.Text;
                user.nombre = txtNombreUsuario.Text;
                user.fechaIngreso = dTPFechaIngreso.Value;
                user.password = txtContra.Text;
                user.rol=(string) cbRol.SelectedValue;

                tbPersona persona = new tbPersona();
                persona.cedula = mskCedulaUsers.Text;
                persona.nombre = txtNombre.Text;
                persona.apellido1 = txtApellido1.Text;
                persona.apellido1 = txtApellido2.Text;
                persona.genero = cbGenero.Text.ToUpper() == "Masculino" ? 1 : cbGenero.Text.Trim().ToUpper() == "FEMENINO" ? 2 : 3;
                persona.fechaNac = dTPFechaNacimiento.Value;

                user.tbPersona = persona;
                usuariosIns.guardar(user);

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
            if (mskCedulaUsers.Text == String.Empty)
            {
                MessageBox.Show("Falta la cedula");
                return false;
            }
            else if (txtNombreUsuario.Text == String.Empty)
            {
                MessageBox.Show("Falta el nombre de usuario");
                return false;
            }
            else if (dTPFechaIngreso.Text == String.Empty)
            {
                MessageBox.Show("Falta la fecha de ingreso");
                return false;
            }
            else if (txtContra.Text == String.Empty)
            {
                MessageBox.Show("Falta la contrasela");
                return false;
            }
            else if (cbRol.Text == String.Empty)
            {
                MessageBox.Show("Falta el rol");
                return false;
            }
            


            return true;

        }

    }
}
