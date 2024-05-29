using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_Multihilo.Properties;

namespace Tarea2_Multihilo
{
    public partial class MenuPrincipal : Form
    {
        SoundPlayer player;

        public MenuPrincipal()
        {
            InitializeComponent();

            // Centrar la ventana en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            player = new SoundPlayer(Resources.f1theme);
            player.Play();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            player.Stop();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
