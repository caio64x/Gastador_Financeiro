using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        private void atualizaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            try
            {

                if (MessageBox.Show("Deseja efetuar a atualização?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) using (var client = new WebClient())
                        MessageBox.Show("Aguarde o sistema recarregar!", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                {
                    System.Threading.Thread.Sleep(1000);
                        Process.Start("Atualizador.exe");
                        this.Close();
                    }

            }
            catch
            {

            }
        }
    }
}
