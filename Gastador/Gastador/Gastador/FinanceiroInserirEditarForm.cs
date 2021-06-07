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
    public partial class FinanceiroInserirEditarForm : Form
    {
        Financeiro financeiro = null;
        public FinanceiroInserirEditarForm()
        {
            InitializeComponent();
            Application.DoEvents();
            ListarFinanceiroTipos();

            this.Text = "Novo cadastro de tipo de finanças";
            idTextBox.Text = "Automático";
            idTextBox.Enabled = false;
            ativoCheckBox.Checked = true;
            financeiro = new Financeiro();
         

        }

        public FinanceiroInserirEditarForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();
            ListarFinanceiroTipos();

            this.Text = "Alteração de cadastro de tipo de finanças";
            financeiro = new FinanceiroDAO().Buscar(id);

            idTextBox.Text = financeiro.ID.ToString();
            idTextBox.Enabled = false;

            nomeTextBox.Text = financeiro.Nome;
            ativoCheckBox.Checked = financeiro.Ativo;
            financeiroTipoComboBox.SelectedValue = Convert.ToInt32(financeiro.IDFinanceiroTipo);

        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            financeiro.IDFinanceiroTipo = Convert.ToInt32(financeiroTipoComboBox.SelectedValue);
            financeiro.Nome = nomeTextBox.Text.Trim();
            financeiro.Ativo = ativoCheckBox.Checked;
            financeiro.ID= new FinanceiroDAO().Salvar(financeiro);

            if (financeiro.ID == 0)
            {
                MessageBox.Show("Erro ao salvar!");
            }
            else
            {
                this.Text = "Alteração de cadastro de tipo de finanças";
                idTextBox.Text = financeiro.ID.ToString();
                MessageBox.Show("Registro salvo com sucesso!");
            }

        }

        //private void excluirButton_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Deseja realmente excluir o registro " + financeiro.Nome + "?",
        //        "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        var resp = new FinanceiroDAO().Excluir(financeiro.ID);
        //        if (resp)
        //        {
        //            MessageBox.Show("Excluído com sucesso");
        //            Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Erro ao excluir!");
        //        }
        //    }
        //}

        void ListarFinanceiroTipos()
        {
            var lista = new FinanceiroTipoDAO().ListarParaCombo();
            financeiroTipoComboBox.ValueMember = "ID";
            financeiroTipoComboBox.DisplayMember = "Nome";
            financeiroTipoComboBox.DataSource = lista;
        }

        
    }
}
