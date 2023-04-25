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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MemoryGame
{
    public partial class frmGameNumber : Form
    {
        recordPlayersBL recordPlayerIns = new recordPlayersBL();

        Label firstClicked = null;
        Label secondClicked = null;
        Random random = new Random();

        public frmGameNumber(string nickName)
        {
            InitializeComponent();
            nombreUsuario(nickName);
            asignarCuadros();
        }

        private void nombreUsuario(string nickName)
        {
            txtUsuario.Text = nickName.ToUpper();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<int> nums = new List<int>()
        {
            1,1,2,2,3,3,4,4,5,5,
            6,6,7,7,8,8,9,9,10,10
        };

        private void asignarCuadros()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(nums.Count);
                    iconLabel.Text = nums[randomNumber].ToString();
                    nums.RemoveAt(randomNumber);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer2.Start();

            // El temporizador sólo se activa después de que dos iconos no coincidentes
            // que no coincidan,
            // así que ignora cualquier clic si el temporizador está en marcha
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            timer2.Stop();
            // Guardar Juego ganado en BD
            salvarGame();

            MessageBox.Show("Has acertado todos los Numeros", "Muy bien echo");
            this.Close();
        }

        private void salvarGame()
        {
            tbRecordPlayers recordPlayer = new tbRecordPlayers();

            recordPlayer.usuario = txtUsuario.Text.ToUpper();
            recordPlayer.game = "Juego Memoria Numeros".ToUpper();
            recordPlayer.tiempo = lbTime.Text;

            recordPlayerIns.guardar(recordPlayer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string[] tiempo = lbTime.Text.Split(':');

            int hora = Convert.ToInt32(tiempo[0]);
            int minuto = Convert.ToInt32(tiempo[1]);
            int segundo = Convert.ToInt32(tiempo[2]);

            segundo++;

            if (segundo > 59)
            {
                segundo = 0;
                minuto++;
            }
            if (minuto > 59)
            {
                minuto = 0;
                hora++;
            }

            lbTime.Text = hora.ToString() + ':' + minuto.ToString() + ':' + segundo.ToString();
        }
    }
}
