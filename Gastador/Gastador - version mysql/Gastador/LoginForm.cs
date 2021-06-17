using Gastador.Negocios.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gastador
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            try
            { 
                var usuario = new UsuarioDAO().EfetuarLogin(loginTextBox.Text.Trim(), senhaTextBox.Text.Trim());

                if (usuario == null)
                {
                    MessageBox.Show("Usuário ou senha inválido!",
                        "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    senhaTextBox.Clear();
                    loginTextBox.Clear();
                    loginTextBox.Focus();

                    return;
                }

                //se logou, mas ta inativo

                if (usuario.Ativo == false)
                {
                    MessageBox.Show("Usuário inativado!",
                        "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                //se chegou aqui, está ok
                Compartilhada.UsuarioLogado = usuario;
                Close();
            }
            catch 
            {
                //ativar o banco caso o serviço esteja desligado
                var startInfo2 = new ProcessStartInfo(@"C:\Gastador\MySQL\bat\adicionando_porta_firewall.bat");
                startInfo2.Verb = "runas";
                //startInfo.WorkingDirectory = @"C:\Gastador\MySQL\adicionando_porta_firewall.bat";
                startInfo2.WorkingDirectory = @"C:\Gastador\MySQL\bat\adicionando_porta_firewall.bat.bat";
                Process proc2 = Process.Start(startInfo2);
                Thread.Sleep(1500);

                var startInfo = new ProcessStartInfo(@"C:\Gastador\MySQL\bat\install_mysql_service.bat");
                startInfo.Verb = "runas";
                //startInfo.WorkingDirectory = @"C:\Gastador\MySQL\adicionando_porta_firewall.bat";
                startInfo.WorkingDirectory = @"C:\Gastador\MySQL\bat\install_mysql_service.bat";
                Process proc = Process.Start(startInfo);
                Thread.Sleep(500);

            }

        }  
    }
}
