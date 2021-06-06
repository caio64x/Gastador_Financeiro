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
    public partial class UsuariosListarForm : Form
    {
        public UsuariosListarForm()
        {
            InitializeComponent();
            Application.DoEvents();// enquanto o evento acontece

        }

        public void Listar()
        {
            quantidadeLabel.Text = "Aguarde... buscando....";
            Application.DoEvents();// enquanto o evento acontece


            var lista = new UsuarioDAO().Listar(filtroTextBox.Text);

            alterarButton.Enabled = lista.Count > 0;
            quantidadeLabel.Text = "Regristros encontrados: " + lista.Count;
            Application.DoEvents();// enquanto o evento acontece

            dataGridView1.DataSource = lista;
        }


        private void buscarButton_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);
            }
            catch
            {

                MessageBox.Show("Selecione um registro");
            }

            if (id > 0)
            {
                new UsuarioInserirEditarForm(id).ShowDialog();
                Listar();
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void filtroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarButton.PerformClick();
        }

        private void UsuariosListarForm_Load(object sender, EventArgs e)
        {
            buscarButton.PerformClick();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            new UsuarioInserirEditarForm().ShowDialog();
            Listar();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);
            }
            catch
            {

                MessageBox.Show("Selecione um registro");
            }

            if (id > 0)
            {

                new UsuarioDAO().Excluir(id);
                MessageBox.Show("Registro excluído!",
                "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();

            }
        }


    }
}
