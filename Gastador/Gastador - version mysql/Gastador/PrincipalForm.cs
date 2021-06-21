using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gastador
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }


        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UsuariosListarForm();
            form.MdiParent = this;
            form.Show();

        }

        public void ValidarUsuario()
        {
            if (Compartilhada.UsuarioLogado == null)
            {

                loginToolStripButton.Text = "ENTRAR";
                loginToolStripButton.Image = Gastador.Properties.Resources.entrar;

                //bloqueia acesso se não logar
                usuariostoolStripButton.Enabled = false;
                registrarFinanceiroToolStripButton.Enabled = false;
                cadastrosToolStripMenuItem.Enabled = false;
                relatorioMensalToolStripButton.Enabled = false;

                usuarioToolStripStatusLabel.Text = "Usuário não logado";

            }
            else
            {
                loginToolStripButton.Text = "SAIR";
                loginToolStripButton.Image = Gastador.Properties.Resources.sair;
                usuarioToolStripStatusLabel.Text = "Usuário: " + Compartilhada.UsuarioLogado.Nome;

                //libera acesso ao logar 
                usuariostoolStripButton.Enabled = true;
                registrarFinanceiroToolStripButton.Enabled = true;
                cadastrosToolStripMenuItem.Enabled = true;
                relatorioMensalToolStripButton.Enabled = true;


            }
        }

        private void loginToolStripButton_Click(object sender, EventArgs e)
        {
            Compartilhada.UsuarioLogado = null;

            ValidarUsuario();

            new LoginForm().ShowDialog();

            ValidarUsuario();
        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            Compartilhada.UsuarioLogado = null;

            ValidarUsuario();

            new LoginForm().ShowDialog();

            ValidarUsuario();
        }



        private void centroDeCustoreceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FinanceiroListarForm();
            form.MdiParent = this;
            form.Show();
        }

        private void registrarFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RegistoFinanceiroForm();
            form.MdiParent = this;
            form.Show();
        }

        private void relatorioMensalToolStripButton_Click(object sender, EventArgs e)
        {
            var form = new RelatorioMensalForm();
            form.MdiParent = this;
            form.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SobreForm();
            form.ShowDialog();
        }

        public void atualizar()
        {
            if (MessageBox.Show("Deseja efetuar a atualização?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show("Aguarde o sistema recarregar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            {
                System.Threading.Thread.Sleep(1000);
                this.Close();
                Close();
                Process.Start("Atualizador.exe");

            }
        }
        private void atualizaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            try
            {
                atualizar();
            }
            catch
            {
                try
                {
                    MessageBox.Show("O atualizador está com problemas, o sistema irá tentar atualiza-lo!");
                    var client = new WebClient();
                    // MessageBox.Show("Hove um problema ao realizar o download!");
                    System.Threading.Thread.Sleep(5000);
                    client.DownloadFile("https://github.com/caio64x/Gastador_Financeiro/raw/main/Gastador/Gastador%20-%20version%20mysql/Gastador/update/Atualizador.exe", @"Atualizador.exe");
                    atualizar();
                }
                catch
                {
                    MessageBox.Show("Problemas de conexão com a internet!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //realizar o backup
            if (MessageBox.Show("Deseja efetuar o backup?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Por favor aguarde!");

                System.Threading.Thread.Sleep(500);
                Backup backup = new Backup();

                if (backup.GerarBackup() == 1)
                {

                    MessageBox.Show("Backup realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Houve um problema ao gerar o backup");
                }
            }
            else
            {
            }
        }

        private void realziarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor aguarde!");

            System.Threading.Thread.Sleep(500);
            Backup backup = new Backup();

            if (backup.GerarBackup() == 1)
            {

                MessageBox.Show("Backup realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Houve um problema ao gerar o backup, tente novamente");
            }
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RestaurarBackup();
            form.ShowDialog();
        }
    }
}
