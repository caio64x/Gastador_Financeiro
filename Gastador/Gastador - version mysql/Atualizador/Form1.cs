using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Atualizador
{
    public partial class AtualizadorForm : Form
    {
        public static bool IsConnected()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public AtualizadorForm()
        {
            InitializeComponent();
            Application.DoEvents();

            WebClient webClient = new WebClient();
            var client = new WebClient();

 
            if (IsConnected() == true)

            {
                try
                {
                    System.Threading.Thread.Sleep(5000);
                    File.Delete(@".\Gastador.exe");
                    client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/update/Gastador.exe", @"Gastador.exe");
                    Process.Start(@".\Gastador.exe");
                    this.Close();

                }
                catch
                {
                    this.Close();
                    MessageBox.Show("Houve algum problema tente novamente!");
                }
            }
            else
            {
                this.Close();
                MessageBox.Show("Houve algum problema na comunicação!");
            }
        }


    }
}
