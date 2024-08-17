using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion
{
    public partial class Conexiones : Form
    {
        public Conexiones()
        {
            InitializeComponent();
            RefreshNetworkConnections();
        }


        private void RefreshNetworkConnections()
        {
            GridConexion.Rows.Clear();

            // Obtener las conexiones activas
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = properties.GetActiveTcpConnections();

            // Mostrar las conexiones activas en el DataGridView
            foreach (TcpConnectionInformation connection in tcpConnections)
            {
                GridConexion.Rows.Add("TCP", connection.LocalEndPoint, connection.RemoteEndPoint, connection.State);
            }

            // Obtener las conexiones entrantes
            IPGlobalProperties listeningProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpListeners = listeningProperties.GetActiveTcpListeners();

            // Mostrar las conexiones entrantes en el DataGridView
            foreach (IPEndPoint listener in tcpListeners)
            {
                GridConexion.Rows.Add("TCP Listener", listener, "", "");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
