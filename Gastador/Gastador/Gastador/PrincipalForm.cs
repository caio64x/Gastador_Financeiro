﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void pegarStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var str = System.Configuration.ConfigurationManager.AppSettings["banco"];
            MessageBox.Show(str);
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

                 usuarioToolStripStatusLabel.Text = "Usuário não logado";

            }
            else
            {
                loginToolStripButton.Text = "SAIR";
                loginToolStripButton.Image = Gastador.Properties.Resources.sair;
                usuarioToolStripStatusLabel.Text = "Usuário: " + Compartilhada.UsuarioLogado.Nome;

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
    }

}
