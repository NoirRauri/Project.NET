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
using Utilities.Excepsiones;

namespace MemoryGame
{
    public partial class frmLogin : Form
    {
        UsuarioBL usuarioIns = new UsuarioBL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                // verificamos usuarios
                if (verificarUsuario())
                {
                    // Ocultar el formulario actual
                    this.Hide();
                    // Se crea una instancia del formulario Main
                    frmMain principal = new frmMain(txtUsuario.Text);
                    // Mostrar el formulario Main
                    principal.ShowDialog();
                    this.Show();
                }
                limpiarLogin();

            }
            catch (ValidationException)
            {
                MessageBox.Show("Excepcion en la  validacion");
            }
            catch (Exception)
            {
                MessageBox.Show("El Usuario o contraseña estan incorrectos");
                limpiarLogin();
            }
            
        }

        private bool verificarUsuario()
        {
            if (validarDatos())
            {
                tbUsuarios usuarios = new tbUsuarios();

                usuarios.usuario = txtUsuario.Text.ToUpper();
                usuarios.password = txtPassword.Text.ToUpper();

                if (usuarioIns.logearUsuario(usuarios))
                {
                    return true;
                }
                MessageBox.Show("No se Encontro Usuario. Veriifique datos");
            }
            return false;
        }

        private bool validarDatos()
        {
            if (txtUsuario==null)
            {
                MessageBox.Show("Falta la Usuario");
                return false;
            }
            else if (txtPassword==null)
            {
                MessageBox.Show("Falta la contraseña");
                return false;
            }
            return true;
        }

        // Limpiar el login
        private void limpiarLogin()
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }

        private void linkLabelRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();
            // Ingreso al registro
            frmRegistrar registro = new frmRegistrar();
            registro.ShowDialog();
            // Limpiar usuario y contraseña
            limpiarLogin();
            // mostrar de nuevo el login
            this.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validarLogin(txtUsuario.Text,txtPassword.Text);
        }

        private bool loginCompleto = false;
        private void validarLogin(string usuario, string password)
        {
            loginCompleto = !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password);

            btnIniciar.Enabled = loginCompleto;
        }
    }
}
