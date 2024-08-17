using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace aplicacion
{
    public partial class Winver : Form
    {
        public Winver()
        {
            InitializeComponent();
            MostrarInformacionSistema();

        }

        
        public void MostrarInformacionSistema()
        {
            // Consulta para obtener información del sistema operativo
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectCollection information = searcher.Get();

            foreach (ManagementObject obj in information)
            {
                string nombreSO = obj["Caption"].ToString();
                string nombreSO2 = obj["Caption"].ToString();
                string versionSO = obj["Version"].ToString();
                string arquitectura = obj["OSArchitecture"].ToString();
                string fabricanteSO = obj["Manufacturer"].ToString();
                string nombreComputadora = Environment.MachineName;
                
                lbsistemaop.Text = "Sistema Operativo: " + nombreSO;
                lbwindows.Text = nombreSO2;
                lbversion.Text = "Versión: " + versionSO;
                lbarqui.Text = "Arquitectura: " + arquitectura;
                lbfabricante.Text = "Fabricante: " + fabricanteSO;
                lbnombrecompu.Text = "Nombre de la Computadora: " + nombreComputadora;


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
