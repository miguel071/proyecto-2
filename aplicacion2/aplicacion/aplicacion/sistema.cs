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
    public partial class sistema : Form
    {
        public sistema()
        {
            InitializeComponent();
            MostrarInformacionEquipo();
        }

        private void MostrarInformacionEquipo()
        {
            try
            {
                string fechaHoraActual = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                string nombreEquipo = Environment.MachineName;
                string idiomaSistema = System.Globalization.CultureInfo.InstalledUICulture.DisplayName;
                string fabricanteSistema = infoFabricante();
                string procesador = InfoProcesador();
                string archivoPaginacion = $"{Environment.SystemPageSize / 1024} KB";
                string versionDirectX = VersionInstalada();
                string modeloSistema = InfoModel();
                string modeloBIOS = InfoBios();
                string memoriaTotalRAM = InfoRam();
                string versionSistemaOperativo = VerSistem();
                // string VersiondeSistema = infoSiste();
                //motrando ingormacion 


                listSISTEMA.Items.Add("Informacion");

                listSISTEMA.Items.Add($"Fecha y Hora Actual ->   {fechaHoraActual}");
                listSISTEMA.Items.Add($"Nombre del Equipo --->   {nombreEquipo}");
                listSISTEMA.Items.Add($"Sistema Operativo --->   {versionSistemaOperativo}");
                listSISTEMA.Items.Add($"Idioma del Sistema -->   {idiomaSistema}");
                listSISTEMA.Items.Add($"Sistema ------------->   {fabricanteSistema}");
                listSISTEMA.Items.Add($"Procesador ---------->   {procesador}");
                listSISTEMA.Items.Add($"Paginación ---------->   {archivoPaginacion}");
                listSISTEMA.Items.Add($"Versión de DirectX -->   {versionDirectX}");
                listSISTEMA.Items.Add($"Modelo del Sistema -->   {modeloSistema}");
                listSISTEMA.Items.Add($"Modelo de la BIOS --->   {modeloBIOS}");
                listSISTEMA.Items.Add($"Memoria Total RAM --->   {memoriaTotalRAM}");
                listSISTEMA.Items.Add("");
            }

            // al momento de ejecutar si nos aparce error
            catch (Exception ex)
            {
                MessageBox.Show($"Error de informacion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string VerSistem()
        {
            try
            {
                // Obtener la versión completa del sistema operativo
                return Environment.OSVersion.VersionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de informacion: {ex.Message}");
            }

            return "Desconocido";
        }


        private string InfoRam()
        {
            // Consulta para obtener información sobre la memoria RAM
            var query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
            long totalRAM = 0;

            using (var searcher = new ManagementObjectSearcher(query))
            {
                foreach (var result in searcher.Get())
                {
                    // Sumar la capacidad de cada módulo de memoria
                    totalRAM += Convert.ToInt64(result["Capacity"]);
                }
            }

            return $"{totalRAM / (1024 * 1024)} MB";
        }


        private string InfoBios()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\BIOS"))
            {
                if (key != null)
                {
                    return key.GetValue("SystemVersion") as string;
                }
                return "Desconocido";
            }
        }


        private string InfoModel()
        {
            // Consulta para obtener información sobre el sistema
            var query = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
            using (var searcher = new ManagementObjectSearcher(query))
            {
                foreach (var result in searcher.Get())
                {
                    // Obtener el modelo del sistema
                    return result["Model"]?.ToString();
                }
            }

            return "No disponible";
        }
        private string infoFabricante()
        {
            // Obtener el fabricante del sistema operativo (Solo funciona en Windows)
            string manufacturer = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    manufacturer = obj["Manufacturer"] as string;
                    break;
                }
            }
            return manufacturer;
        }

        private string InfoProcesador()
        {
            // Obtener detalles del procesador
            string processorInfo = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    processorInfo = $"{obj["Name"]} - {obj["MaxClockSpeed"]} MHz";
                    break;
                }
            }
            return processorInfo;
        }

        private string VersionInstalada()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\DirectX"))
                {
                    object version = key.GetValue("Version");
                    if (version != null)
                    {
                        return version.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de informacion: {ex.Message}");
            }

            return "Desconocido";
        }

        private void sistema_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
