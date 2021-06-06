using Gastador.Negocios.DAL;
using Gastador.Negocios.Mapeamento;
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
    public partial class RegistoFinanceiroForm : Form
    {
        MvFinanceiro mvFinanceiro = null;
        public RegistoFinanceiroForm()
        {
            InitializeComponent();
            Application.DoEvents();// enquanto o evento acontece
            mvFinanceiro = new MvFinanceiro();

        }

        public void Listar()
        {
            quantidadeLabel.Text = "Aguarde... buscando....";
            Application.DoEvents();// enquanto o evento acontece



            var lista = new MvFinanceiroDAO().Listar(filtroTextBox.Text, mesDespesacomboBox.Text.Substring(0, 2).Trim());

            alterarButton.Enabled = lista.Count > 0;
            quantidadeLabel.Text = "Regristros encontrados: " + lista.Count;



            valorTotalDespesaLabel.Text = lista.Where(s => s.IDFinanceiroTipo == 3 || s.IDFinanceiroTipo == 2).Sum(s => s.Valor).ToString("C");
            valorTotalReceitaLabel.Text = lista.Where(s => s.IDFinanceiroTipo == 1).Sum(s => s.Valor).ToString("C");
            Application.DoEvents();
            // enquanto o evento acontece

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
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDdataGridViewTextBoxColumn1"].Value);
            }
            catch
            {
                MessageBox.Show("Selecione um registro");
            }
            if (id > 0)
            {
                new RegistoFinanceiroInserirEditarForm(id).ShowDialog();
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

        private void inserirButton_Click(object sender, EventArgs e)
        {
            new RegistoFinanceiroInserirEditarForm().ShowDialog();
            Listar();
        }

        private void RegistrarFinanceiroForm_Load(object sender, EventArgs e)
        {
            buscarButton.PerformClick();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDdataGridViewTextBoxColumn1"].Value);
            }
            catch
            {

                MessageBox.Show("Selecione um registro");
            }

            if (id > 0)
            {

                new MvFinanceiroDAO().Excluir(id);
                MessageBox.Show("Registro excluído!",
                "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();

            }

        }

        private void RegistrarFinanceiroForm_Load_1(object sender, EventArgs e)
        {
            mesDespesacomboBox.SelectedIndex = 0;

            buscarButton.PerformClick();
        }

       
    }
}
