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
    public partial class pantalla : Form
    {
        public pantalla()
        {
            InitializeComponent();
            MostrarInformacionPantalla();

        }


        private void MostrarInformacionPantalla()
        {
            try
            {
                // Consultar WMI para obtener información sobre la pantalla
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                ManagementObjectCollection information = searcher.Get();

                foreach (ManagementObject obj in information)
                {
                    string nombre = obj["Name"].ToString();
                    string fabricante = obj["AdapterCompatibility"].ToString();
                    string tipoChip = obj["VideoProcessor"].ToString();
                    string tipoDAC = obj["VideoArchitecture"].ToString();

                    ulong memoriaTotalAproxBytes = Convert.ToUInt64(obj["AdapterRAM"]);
                    ulong memoriaDePantallaBytes = (Convert.ToUInt64(obj["CurrentBitsPerPixel"]) * Convert.ToUInt64(obj["CurrentHorizontalResolution"]) * Convert.ToUInt64(obj["CurrentVerticalResolution"])) / 8;
                    ulong memoriaTotalAproxMB = memoriaTotalAproxBytes / (1024 * 1024);  // Convertir a MB
                    ulong memoriaDePantallaMB = memoriaDePantallaBytes / (1024 * 1024);  // Convertir a MB
                    ulong memoriaCompartidaMB = memoriaTotalAproxMB - memoriaDePantallaMB;

                    string tipoDispositivo = GetStringProperty(obj, "AdapterType");
                    string modoPresentacion = GetStringProperty(obj, "VideoModeDescription");
                    string monitor = GetStringProperty(obj, "DeviceName");

                    // agregados reciente 
                    string modeloControlador = obj["Caption"].ToString();
                    string controladorPrincipal = GetStringProperty(obj, "VideoController");
                    string versionControlador = GetStringProperty(obj, "DriverVersion");
                    string fechaInstalacion = GetStringProperty(obj, "DriverDate");
                    string whqlLogo = GetStringProperty(obj, "DriverWHQLLevel");
                    string ddiDirect3D = GetStringProperty(obj, "DDIVersion");
                    string nivelCaracteristica = GetStringProperty(obj, "DriverLevel");



                    ///Info.Text = $"Dispositivo";
                   // infoContro.Text = $"Controlador";
                    // mostrar info
                    LisDis.Items.Add("Dispositivo");
                    LisDis.Items.Add($"Nombre------------------>   {nombre}");
                    LisDis.Items.Add($"Fabricante-------------->   {fabricante} ");
                    LisDis.Items.Add($"Tipo de Chip------------>   {tipoChip}");
                    LisDis.Items.Add($"Tipo de DAC------------->   {tipoDAC}");
                    LisDis.Items.Add($"{(string.IsNullOrEmpty(tipoDispositivo) ? string.Empty : $"Tipo de Dispositivo----->   {tipoDispositivo}")}");
                    LisDis.Items.Add($"Memoria Total Aprox----->   {memoriaTotalAproxMB} BM");
                    LisDis.Items.Add($"Memoria de la Pantalla-->   {memoriaDePantallaMB}");
                    LisDis.Items.Add($"Memoria Compartida------>   {memoriaCompartidaMB} MB ");
                    LisDis.Items.Add($"{(string.IsNullOrEmpty(modoPresentacion) ? string.Empty : $"Mo.Presentación--------->   {modoPresentacion}")}");
                    LisDis.Items.Add($"{(string.IsNullOrEmpty(monitor) ? string.Empty : $"Monitor----------------->   {monitor}\r\n")}");
                    LisDis.Items.Add("");


                    // segundo ListViw

                    listContro.Items.Add("Controlador");
                    listContro.Items.Add($"Modelo del Controlador---->   {modeloControlador}");
                    listContro.Items.Add($"Controlador Principal----->   {controladorPrincipal}");
                    listContro.Items.Add($"Versión del Controlador--->   {versionControlador}");
                    listContro.Items.Add($"Fecha--------------------->   {fechaInstalacion}");
                    listContro.Items.Add($"Con Logo WHQL------------->   {whqlLogo}");
                    listContro.Items.Add($"DDI Direct3D-------------->   {ddiDirect3D}");
                    listContro.Items.Add($"Nivel de Característica--->   {nivelCaracteristica}");
                    listContro.Items.Add($"Modelo del Controlador---->   {modeloControlador}");
                    listContro.Items.Add("");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener información de la pantalla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private string GetStringProperty(ManagementObject obj, string propertyName)
        {
            try
            {
                return obj[propertyName].ToString();
            }
            catch (Exception)
            {
                return "No disponible";
            }
        }

        private ulong GetUInt64Property(ManagementObject obj, string propertyName)
        {
            try
            {
                return Convert.ToUInt64(obj[propertyName]);
            }
            catch (Exception)
            {
                return 0; // Otra opción podría ser devolver ulong.MaxValue para indicar que el valor no está disponible.
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
