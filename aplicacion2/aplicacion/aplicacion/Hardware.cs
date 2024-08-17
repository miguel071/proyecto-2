using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion
{
    public partial class Hardware : Form
    {
        public Hardware()
        {
            InitializeComponent();

        }
      

        private void piccpu_Click(object sender, EventArgs e)
        {
            sistema formsiste = new sistema();
            formsiste.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pantalla formspantalla = new pantalla();
            formspantalla.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picram_Click(object sender, EventArgs e)
        {
            sonido formssonido = new sonido();
            formssonido.Show();
        }
    }
}
