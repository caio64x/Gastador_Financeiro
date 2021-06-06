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
    public partial class RegistoFinanceiroInserirEditarForm : Form
    {
        Financeiro financeiro = null;
        public RegistoFinanceiroInserirEditarForm()
        {
            InitializeComponent();
            Application.DoEvents();
            ListarFinanceiro();

            this.Text = "Nova despesa/receita";
            idTextBox.Text = "Automático";
            idTextBox.Enabled = false;
            
            financeiro = new Financeiro();

        }

        public RegistoFinanceiroInserirEditarForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();
            ListarFinanceiro();

            this.Text = "Alteração despesa/receita";
            financeiro = new FinanceiroDAO().Buscar(id);

            idTextBox.Text = financeiro.ID.ToString();
            idTextBox.Enabled = false;

           // nomeTextBox.Text = financeiro.Nome;
            
            financeiroComboBox.SelectedValue = Convert.ToInt32(financeiro.IDFinanceiroTipo);

        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            financeiro.IDFinanceiroTipo = Convert.ToInt32(financeiroComboBox.SelectedValue);
        //    financeiro.Nome = nomeTextBox.Text.Trim();
          
            financeiro.ID= new FinanceiroDAO().Salvar(financeiro);

            if (financeiro.ID == 0)
            {
                MessageBox.Show("Erro ao salvar!");
            }
            else
            {
                this.Text = "Alteração despesa/receita";
                idTextBox.Text = financeiro.ID.ToString();
                MessageBox.Show("Registro salvo com sucesso!");
            }

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Deseja realmente excluir o registro " + financeiro.Nome + "?",
            //    "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    var resp = new FinanceiroDAO().Excluir(financeiro.ID);
            //    if (resp)
            //    {
            //        MessageBox.Show("Excluído com sucesso");
            //        Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Erro ao excluir!");
            //    }
            //}
        }

        void ListarFinanceiro()
        {
            var lista = new FinanceiroDAO().ListarParaCombo();
            financeiroComboBox.ValueMember = "ID";
            financeiroComboBox.DisplayMember = "Nome";
            financeiroComboBox.DataSource = lista;
        }

        private void valorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                //Se a tecla digitada não for número e nem backspace
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 )
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44)
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }

                    
                }
            
        }
    }
}
