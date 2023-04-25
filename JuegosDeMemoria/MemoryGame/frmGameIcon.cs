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

namespace MemoryGame
{
    public partial class frmGameIcon : Form
    {
        recordPlayersBL recordPlayerIns= new recordPlayersBL();

        // firstClicked apunta al primer control Label
        // en el que haga clic el jugador, pero será nulo
        // si el jugador aún no ha hecho clic en ninguna etiqueta
        Label firstClicked = null;

        // secondClicked apunta al segundo control Label
        // en el que hace clic el jugador
        Label secondClicked = null;

        public frmGameIcon(string nickName)
        {
            InitializeComponent();
            nombreUsuario(nickName);
            AssignIconsToSquares();
        }
        private void nombreUsuario(string nickName)
        {
            txtUsuario.Text = nickName.ToUpper();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Random random = new Random();

        // Cada una de estas letras es un icono con la fuente Webdings,
        // y cada icono aparece dos veces en esta lista
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k", "a", "a",
            "b", "b", "v", "v", "w", "w", "z", "z", "s", "s"
        };

        /// Asigna cada icono de la lista de iconos a un cuadrado aleatorio
        private void AssignIconsToSquares()
        {
            // El TableLayoutPanel tiene 20 etiquetas,
            // y la lista de iconos tiene 20 iconos,
            // por lo que un icono se extrae al azar de la lista
            // y se añade a cada etiqueta
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count); // asigna un caracter random
                    iconLabel.Text = icons[randomNumber]; // agrega el caracter al lebel 
                    icons.RemoveAt(randomNumber); // elimina de lista para no repetir
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // comienza el contador del timempo en juego 
            timer2.Start();

            // El temporizador sólo se activa después de que dos iconos no coincidentes
            // que no coincidan,
            // así que ignora cualquier clic si el temporizador está en marcha
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Si la etiqueta pulsada es negra, el jugador ha pulsado
                // un icono que ya ha sido revelado --
                // ignora el clic
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // Si firstClicked es null, éste es el primer icono
                // del par en el que el jugador hizo clic,
                // así que establece firstClicked a la etiqueta que el jugador
                // ha pulsado, cambia su color a negro y devuelve
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                // Si el jugador llega hasta aquí, el temporizador no está
                // corriendo y firstClicked no es null,
                // así que este debe ser el segundo icono que el jugador pulsó
                // Establece su color a negro
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                // Comprueba si el jugador ha ganado
                CheckForWinner();

                // Si el jugador hizo clic en dos iconos iguales, mantenerlos
                // negros y reinicia firstClicked y secondClicked
                // para que el jugador pueda pulsar otro icono
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                // Si el jugador llega hasta aquí, el jugador
                // ha pulsado dos iconos diferentes, por lo que se inicia el
                // temporizador (que esperará tres cuartos de
                // de segundo y luego ocultará los iconos).
                timer1.Start();
            }
        }

        /// Este temporizador se inicia cuando el jugador pulsa
        /// dos iconos que no coinciden,
        /// así que cuenta tres cuartos de segundo
        /// y luego se apaga y oculta ambos iconos
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Detener el temporizador
            timer1.Stop();

            // Ocultar ambos iconos
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Restablecer firstClicked y secondClicked
            // para que la próxima vez que se
            // se haga clic, el programa sabrá que es el primer clic
            firstClicked = null;
            secondClicked = null;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            string[] tiempo = labelTime.Text.Split(':');

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

            labelTime.Text = hora.ToString() + ':' + minuto.ToString() + ':' + segundo.ToString();
        }

        /// Comprueba cada icono para ver si coincide, comparando su color de primer plano con el color de fondo.
        /// comparando su color de primer plano con su color de fondo.
        /// Si todos los iconos coinciden, el jugador gana.
        private void CheckForWinner()
        {
            // Recorre todas las etiquetas del TableLayoutPanel,
            // comprobando cada una para ver si su icono coincide
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

            // Si el bucle no retornó, no encontró
            // ningún icono sin emparejar
            // Eso significa que el usuario ganó. Mostrar un mensaje y cerrar el formulario
            MessageBox.Show("Has acertado todos los iconos", "Enhorabuena");
            Close();
        }

        private void salvarGame()
        {
            tbRecordPlayers recordPlayer = new tbRecordPlayers();

            recordPlayer.usuario = txtUsuario.Text.ToUpper();
            recordPlayer.game = "Juego Memoria Icon".ToUpper();
            recordPlayer.tiempo = labelTime.Text;

            recordPlayerIns.guardar(recordPlayer);
        }
    }
}
