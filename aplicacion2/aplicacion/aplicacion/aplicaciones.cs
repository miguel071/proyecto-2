using Microsoft.Win32;
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
    public partial class aplicaciones : Form
    {
        public aplicaciones()
        {
            InitializeComponent();

            ListInstalledApplications();
        }

        private void ListInstalledApplications()
        {
            // Configura las columnas del ListView
            viewaplicaciones.View = View.Details;
            viewaplicaciones.Columns.Add("   ", 600);

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall"))
            {
                if (key != null)
                {
                    foreach (string subkeyName in key.GetSubKeyNames())
                    {
                        using (RegistryKey subkey = key.OpenSubKey(subkeyName))
                        {
                            string displayName = subkey.GetValue("DisplayName") as string;
                            if (!string.IsNullOrEmpty(displayName))
                            {
                                // Agregar el nombre de la aplicación al ListView
                                ListViewItem item = new ListViewItem(displayName);
                                viewaplicaciones.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}

