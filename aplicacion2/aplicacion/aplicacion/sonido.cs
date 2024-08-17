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
    public partial class sonido : Form
    {
        public sonido()
        {
            InitializeComponent();
            MostrarInformacionDispositivosSonido();

        }

        private void MostrarInformacionDispositivosSonido()
        {
            try
            {
                // Consultar WMI para obtener información sobre dispositivos de sonido
                ManagementObjectSearcher searcherSound = new ManagementObjectSearcher("SELECT * FROM Win32_SoundDevice");

                // Obtener información sobre dispositivos de sonido
                foreach (ManagementObject obj in searcherSound.Get())
                {
                    MostrarInformacionDispositivoSonido(obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener información de dispositivos de sonido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetPropertyValue(ManagementObject obj, string propertyName)
        {
            PropertyData property = obj.Properties[propertyName];
            return property != null ? property.Value.ToString() : "No disponible";

        }
        private void MostrarInformacionDispositivoSonido(ManagementObject obj)
        {
            string nombre = GetStringProperty(obj, "Name");
            string fabricante = GetStringProperty(obj, "Manufacturer");
            string descripcion = GetStringProperty(obj, "Description");

            string driverName = GetStringProperty(obj, "DriverName");
            string status = GetStringProperty(obj, "Status");
            string deviceId = GetStringProperty(obj, "DeviceID");
            string pnpDeviceId = GetStringProperty(obj, "PNPDeviceID");


            LisDis.Items.Add("Dispositivo");
            LisDis.Items.Add($"Nombre------------------> {nombre}");
            LisDis.Items.Add($"Fabricante--------------> {fabricante}");
            LisDis.Items.Add($"Descripción-------------> {descripcion}");
            LisDis.Items.Add($"Controlador-------------> {driverName}");
            LisDis.Items.Add($"Estado------------------> {status}");
            LisDis.Items.Add($"ID del Dispositivo------> {deviceId}");
            LisDis.Items.Add($"ID del Dispositivo PnP--> {pnpDeviceId}");
            LisDis.Items.Add("");
            LisDis.Items.Add("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

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
