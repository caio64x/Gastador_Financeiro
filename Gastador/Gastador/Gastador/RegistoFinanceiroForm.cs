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

        //funçao do sub menu
        public void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenuStrip sub_menu = new ContextMenuStrip();
                int posicao = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (posicao >= 0)
                {
                    sub_menu.Items.Add("Confirmar pagamento").Name = "confirmar_pagamento";
                }

                sub_menu.Show(dataGridView1, new Point(e.X, e.Y));

                sub_menu.ItemClicked += new ToolStripItemClickedEventHandler(sub_menu_clicked);
            }
        }

        //acoes no submenu
        public void sub_menu_clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "confirmar_pagamento":
                    
                    //chama a função de pagamento
                    ConfirmarPagamento(mvFinanceiro);
                    break;
            }
        }

        public void ConfirmarPagamento(MvFinanceiro mvFinanceiro)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDdataGridViewTextBoxColumn1"].Value);
            mvFinanceiro = new MvFinanceiroDAO().Buscar(id);
            try
            {
                mvFinanceiro.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDdataGridViewTextBoxColumn1"].Value);
                if (mvFinanceiro.ID > 0)
                {

                    new MvFinanceiroDAO().Pagamento(mvFinanceiro);

                }

            }
            catch
            {
                MessageBox.Show("Selecione um registro");
            }
                       

            if (mvFinanceiro.ID > 0)
            {
                new MvFinanceiroDAO().Pagamento(mvFinanceiro);
                MessageBox.Show("Pagamento confirmado!");
                Listar();

            }
        }
    }
}
