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
    public partial class RelatorioMensalForm : Form
    {
        MvFinanceiro mvFinanceiro = null;
        public RelatorioMensalForm()
        {
            InitializeComponent();
            Application.DoEvents();// enquanto o evento acontece
            mvFinanceiro = new MvFinanceiro();
        }

        //listar os registros financeiros, que sao os gastos ou receitas
        public void Listar()
        {
            quantidadeLabel.Text = "Aguarde... buscando....";
            Application.DoEvents();// enquanto o evento acontece

            var lista = new MvFinanceiroDAO().Listar(filtroTextBox.Text, mesDespesacomboBox.Text.Substring(0, 2).Trim());

            alterarButton.Enabled = lista.Count > 0;
            quantidadeLabel.Text = "Regristros encontrados: " + lista.Count;

            //somatorio filtrado
            valorTotalDespesaLabel.Text = lista.Where(s => s.IDFinanceiroTipo == 3 || s.IDFinanceiroTipo == 2 && s.Pago == "S").Sum(s => s.Valor).ToString("C");
            valorTotalReceitaLabel.Text = lista.Where(s => s.IDFinanceiroTipo == 1 && s.Pago == "S").Sum(s => s.Valor).ToString("C");
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
                mvFinanceiro = new MvFinanceiroDAO().Buscar(id);
            }
            catch
            {
                MessageBox.Show("Selecione um registro");
            }

            if (id > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o registro " + mvFinanceiro.ID + " " + mvFinanceiro.NomeFinanceiro + "?",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resp = new MvFinanceiroDAO().Excluir(id);

                    MessageBox.Show("Excluído com sucesso");
                    buscarButton.PerformClick();
                }
            }
        }

        private void RegistrarFinanceiroForm_Load_1(object sender, EventArgs e)
        {
            mesDespesacomboBox.SelectedIndex = 0;

            buscarButton.PerformClick();
        }

        //opções do sub menu
        public void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenuStrip sub_menu = new ContextMenuStrip();
                int posicao = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (posicao >= 0)
                {
                    sub_menu.Items.Add("Confirmar pagamento").Name = "confirmar_pagamento";
                    sub_menu.Items.Add("Estornar pagamento").Name = "estornar_pagamento";
                }

                sub_menu.Show(dataGridView1, new Point(e.X, e.Y));

                sub_menu.ItemClicked += new ToolStripItemClickedEventHandler(sub_menu_clicked);
            }
        }

        //acoes no submenu do datagrid
        public void sub_menu_clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "confirmar_pagamento":

                    //chama a função de pagamento

                    ConfirmarPagamento();

                    break;
                case "estornar_pagamento":

                    //chama a função de pagamento

                    EstornarPagamento();

                    break;
            }
        }

        //função para confirmar o pagamento
        public void ConfirmarPagamento()
        {
            int id;
            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDdataGridViewTextBoxColumn1"].Value);
                mvFinanceiro = new MvFinanceiroDAO().Buscar(id);
            }
            catch
            {
                MessageBox.Show("Selecione um registro");
            }


            if (mvFinanceiro.ID > 0 && mvFinanceiro.Pago == "N")
            {
                new MvFinanceiroDAO().Pagamento(mvFinanceiro);
                MessageBox.Show("Pagamento confirmado!");
                Listar();
            }
            else

            {
                MessageBox.Show("Pagamento já confirmado!");
                Listar();
            }
        }

        //funcao para desfazer o pagamento
        public void EstornarPagamento()
        {
            int id;
            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["iDdataGridViewTextBoxColumn1"].Value);

                mvFinanceiro = new MvFinanceiroDAO().Buscar(id);

            }
            catch
            {
                MessageBox.Show("Selecione um registro");
            }


            if (mvFinanceiro.ID > 0 && mvFinanceiro.Pago == "S")
            {

                new MvFinanceiroDAO().Pagamento(mvFinanceiro);
                MessageBox.Show("Pagamento estornado!");
                Listar();
            }
            else
            {
                MessageBox.Show("Pagamento ja estornado");
                Listar();
            }

        }

        //formatar coluna pelo valor do status do pagamento
         public void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.Value.ToString() == "S")
            {
                e.CellStyle.BackColor = Color.Green;
            }
            else
            {
                if (e.Value.ToString() == "N")
                {
                    e.CellStyle.BackColor = Color.Red;
                }

            }
        }
    }
}
