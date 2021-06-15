using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atualizador
{
    public partial class AtualizadorForm : Form
    {

        public AtualizadorForm()
        {
            InitializeComponent();
            Application.DoEvents();

            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\Gastador.exe");
                client.DownloadString("https://mega.nz/file/ADoEnZAa#FLzn6DMqYbwWQ77g9KzKt2ciRrA2Ca5pAoHzGxUWXaI");
                Process.Start(@".\Gastador.exe");
                this.Close();
            }
            catch
            {

                throw;
            }
        }

        
    }
}
