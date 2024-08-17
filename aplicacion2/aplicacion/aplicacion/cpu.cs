using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.IO;

namespace aplicacion
{
    public partial class cpu : Form
    {
        public cpu()
        {
            InitializeComponent();
            ActualizarInformacion();
        }


        private void cpu_Load(object sender, EventArgs e)
        {
            timer2.Start();

            PerformanceCounterCategory[] categories = System.Diagnostics.PerformanceCounterCategory.GetCategories();
            foreach (PerformanceCounterCategory cat in categories) {
                listCPU2.Items.Add(cat.CategoryName);
            }
        }


       


        // Obtiene el nombre de la aplicación correspondiente a un proceso
        private string GetApplicationName(int processId)
        {
            try
            {
                Process process = Process.GetProcessById(processId);
                return process.ProcessName;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            float fcpu = PCPU.NextValue();
            float fram = PRAM.NextValue();
            float frdisco = PDISCO.NextValue();
            float frred = PRED.NextValue();

            lbCPU.Text = String.Format("{0:0.00}%", fcpu);
            lbRAM.Text = String.Format("{0:0.00}%", fram);
            lbDISCO.Text = String.Format("{0:0.00}%", frdisco);
            lbRED.Text = String.Format("{0:0.00}%", frred);

            chCPU.Series["CPU"].Points.AddY(fcpu);
            chRAM.Series["RAM"].Points.AddY(fram);
            chRED2.Series["RED"].Points.AddY(frdisco);
            chMEMORIA.Series["DISCO"].Points.AddY(frred);

        }


        private void ActualizarInformacion()
        {
            listRAM.Items.Clear();

            Process[] procesos = Process.GetProcesses();
            foreach (var proceso in procesos)
            {
                try
                {
                    // Obtener información del uso de memoria del proceso
                    long memoryUsage = proceso.PrivateMemorySize64 / (1024 * 1024); // Convertir a megabytes

                    // Mostrar el proceso y su uso de memoria en el ListBox
                    listRAM.Items.Add($"{proceso.ProcessName} - {memoryUsage} MB");
                }
                catch (Exception ex)
                {
                    // Manejar excepciones al acceder a información del proceso
                    Console.WriteLine($"Error al obtener información del proceso {proceso.ProcessName}: {ex.Message}");
                }
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detener el temporizador al cerrar el formulario
            timer2.Stop();
            timer2.Dispose();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void piccpu_Click(object sender, EventArgs e)
        {
            PANCPU2.Visible = true;
        }


        private void picram_Click(object sender, EventArgs e)
        {
            PANRAM.Visible = true;
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PANMEMORIA.Visible = true;
        }

        private void picred_Click(object sender, EventArgs e)
        {
            PANRED.Visible = true;
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            PANCPU2.Visible=false;
            PANRAM.Visible=false;
            PANMEMORIA.Visible=false;
            PANRED.Visible=false;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PANCPU2.Visible = false;
            PANRAM.Visible = false;
            PANMEMORIA.Visible = false;
            PANRED.Visible = false;
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            PANCPU2.Visible = false;
            PANRAM.Visible = false;
            PANMEMORIA.Visible = false;
            PANRED.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PANCPU2.Visible = false;
            PANRAM.Visible = false;
            PANMEMORIA.Visible = false;
            PANRED.Visible = false;
        }

    }
}
