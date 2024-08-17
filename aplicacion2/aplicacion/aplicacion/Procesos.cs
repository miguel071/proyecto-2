using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace aplicacion
{
    public partial class Procesos : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        static extern int CloseHandle(IntPtr hThread);
        public enum ThreadAccess : uint
        {
            TERMINATE = 0x0001,
            SUSPEND_RESUME = 0x0002,
            GET_CONTEXT = 0x0008,
            SET_CONTEXT = 0x0010,
            SET_INFORMATION = 0x0020,
            QUERY_INFORMATION = 0x0040,
            SET_THREAD_TOKEN = 0x0080,
            IMPERSONATE = 0x0100,
            DIRECT_IMPERSONATION = 0x0200
        }

        private int maxMemoryLimitKB = 102400;

        public Procesos()
        {
            InitializeComponent();
            MostrarProcesos();
            timer1 = new Timer();
            timer1.Interval = 10000; // Intervalo en milisegundos
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarProcesos();
        }

        private void MostrarProcesos()
        {
            // Obtener la lista de procesos en ejecución
            var procesos = Process.GetProcesses().OrderBy(p => p.ProcessName);

            // Limpiar la DataGridView antes de actualizar
            dataGridView1.Rows.Clear();

            // Mostrar la información de cada proceso en la DataGridView
            foreach (var proceso in procesos)
            {

                int memoriaKB = (int)(proceso.WorkingSet64 / 1024);  // declaramos el tamaño .
                // Agregar una fila a la DataGridView
                dataGridView1.Rows.Add(proceso.ProcessName, proceso.Id, $"{proceso.WorkingSet64 / 1024} KB");
                // Cambiar el color de fondo si la memoria supera el límite establecido
                if (memoriaKB > maxMemoryLimitKB)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        private void piccpu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el nombre del proceso seleccionado
                string nombreProceso = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                // Buscar el proceso por nombre y matarlo
                Process[] procesos = Process.GetProcessesByName(nombreProceso);
                if (procesos.Length > 0)
                {
                    procesos[0].Kill();
                    procesos[0].WaitForExit();
                    procesos[0].Close();
                    MessageBox.Show($"Proceso '{nombreProceso}' terminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se encontró el proceso '{nombreProceso}'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proceso de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void PausarProceso(string nombreProceso)
        {
            // Buscar el proceso por nombre
            Process[] procesos = Process.GetProcessesByName(nombreProceso);

            if (procesos.Length > 0)
            {
                IntPtr hThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)procesos[0].Threads[0].Id);
                if (hThread != IntPtr.Zero)
                {
                    // Suspende el hilo del proceso
                    SuspendThread(hThread);

                    // Cierra el identificador del hilo
                    CloseHandle(hThread);

                    MessageBox.Show($"Proceso '{nombreProceso}' pausado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se pudo abrir el hilo del proceso '{nombreProceso}'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"No se encontró el proceso '{nombreProceso}'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
       
                string nombreProceso = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                // Pausar el proceso seleccionado
                PausarProceso(nombreProceso);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proceso de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReanudarProceso(string nombreProceso)
        {
            // Buscar el proceso por nombre
            Process[] procesos = Process.GetProcessesByName(nombreProceso);

            if (procesos.Length > 0)
            {
                IntPtr hThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)procesos[0].Threads[0].Id);
                if (hThread != IntPtr.Zero)
                {
                    // Reanuda el hilo del proceso
                    ResumeThread(hThread);

                    // Cierra el identificador del hilo
                    CloseHandle(hThread);

                    MessageBox.Show($"Proceso '{nombreProceso}' reanudado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se pudo abrir el hilo del proceso '{nombreProceso}'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"No se encontró el proceso '{nombreProceso}'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private IntPtr OpenThread(object sUSPEND_RESUME, bool v, uint id)
        {
            throw new NotImplementedException();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el nombre del proceso seleccionado
                string nombreProceso = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                // Reanudar el proceso seleccionado
                ReanudarProceso(nombreProceso);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proceso de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
