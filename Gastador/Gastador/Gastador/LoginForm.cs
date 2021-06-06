using Gastador.Negocios.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void entrarButton_Click(object sender, EventArgs e)
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

      
    }
}
