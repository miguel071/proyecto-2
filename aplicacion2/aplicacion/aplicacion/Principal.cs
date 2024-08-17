using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace aplicacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Winver formWinver = new Winver();
            formWinver.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            aplicaciones formAplicaciones = new aplicaciones();
            formAplicaciones.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cpu formAplicaciones = new cpu();
            formAplicaciones.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Conexiones formConexiones = new Conexiones();
            formConexiones.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Procesos formProcesos = new Procesos();
            formProcesos.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Hardware hardware = new Hardware();
            hardware.ShowDialog();
        }
    }
}
