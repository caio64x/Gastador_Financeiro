using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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
                    //atualizar principal
                    File.Delete(@".\Gastador.exe");
                    client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/update/Gastador.exe", @"Gastador.exe");

                    File.Delete(@".\Gastador.exe.config");
                    client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/update/Gastador.exe.zip", @"Gastador.exe.zip");

                    string caminhoZip = @".\Gastador.exe.zip";
                    string pastaExtrair = @".\";

                    using (ZipArchive zip = ZipFile.OpenRead(caminhoZip))
                    {
                        zip.ExtractToDirectory(pastaExtrair);
                    }
                    File.Delete(@".\Gastador.exe.zip");


                    //verifica as dlls
                    if (File.Exists(@".\Dapper.dll") == false)
                    {
                        client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/UpdateDLL/Dapper.dll", @"Dapper.dll");
                    }

                    if (File.Exists(@".\MySql.Data.dll") == false)
                    {
                        client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/UpdateDLL/MySql.Data.dll", @"MySql.Data.dll");
                    }

                    if (File.Exists(@".\mysqlbackup.dll") == false)
                    {
                        client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/UpdateDLL/mysqlbackup.dll", @"mysqlbackup.dll");
                    }

                    if (File.Exists(@".\SQLite.Interop.dll") == false)
                    {
                        client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/UpdateDLL/SQLite.Interop.dll", @"SQLite.Interop.dll");
                    }

                    if (File.Exists(@".\System.Net.Http.dll") == false)
                    {
                        client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/UpdateDLL/System.Net.Http.dll", @"System.Net.Http.dll");
                    }

                    if (File.Exists(@".\System.Runtime.CompilerServices.Unsafe.dll") == false)
                    {
                        client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/UpdateDLL/System.Runtime.CompilerServices.Unsafe.dll", @"System.Runtime.CompilerServices.Unsafe.dll");
                    }

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
