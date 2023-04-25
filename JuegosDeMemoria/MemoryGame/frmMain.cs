using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class frmMain : Form
    {
        public frmMain(string nickName)
        {
            InitializeComponent();
            nombreUsuario(nickName);
            customDesing();
        }

        private void nombreUsuario(string nickName)
        {
            lbNickname.Text = nickName.ToUpper();
        }

        public void customDesing()
        {
            panelSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        public void btnGameMemory_Click(object sender, EventArgs e)
        {
            // codigo y acciones
            openChildForm(new frmGameIcon(lbNickname.Text));

            // ingresa y se oculta el panel
            hideSubMenu();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            // codigo y acciones
            openChildForm(new frmGameNumber(lbNickname.Text));

            // ingresa y se oculta el panel
            hideSubMenu();
        }

        private Form activarForm = null;
        public void openChildForm(Form childForm)
        {
            if (activarForm != null) // existe un fomulario se cierra
            {
                activarForm.Close();
            }
            activarForm = childForm; // guardamos nuevo form
            childForm.TopLevel = false;// nuevo formulario se comporta como un control
            childForm.FormBorderStyle = FormBorderStyle.None;// sin borde
            childForm.Dock = DockStyle.Fill;// regenamos el panel con el form
            panelChildForm.Controls.Add(childForm); // agregamos el contenerdos a la lista de controles
            panelChildForm.Tag = childForm; // se asocia el form con el panel superior
            childForm.BringToFront(); // se presenta el form siempre al frente
            childForm.Show(); // mostramos el form
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // codigo y acciones
            openChildForm(new frmRecords(lbNickname.Text));

            // ingresa y se oculta el panel
            hideSubMenu();
        }
    }
}
