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
    public partial class frmRecords : Form
    {
        public frmRecords(string nickName)
        {
            InitializeComponent();
            nombreUsuario(nickName);
        }
        private void nombreUsuario(string nickName)
        {
            txtUsuario.Text = nickName.ToUpper();
        }
    }
}
