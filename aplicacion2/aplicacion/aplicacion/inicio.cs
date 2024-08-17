using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

    


        private void inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(6);
            if (progressBar1.Value == progressBar1.Maximum) {
            timer1.Stop();
                Principal formPrincipal = new Principal();
                formPrincipal.ShowDialog();
            }
        }
    }
}
