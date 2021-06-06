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
        MvFinanceiro mvFinanceiro = null;
        public RegistoFinanceiroInserirEditarForm()
        {
            InitializeComponent();
            Application.DoEvents();
            ListarFinanceiro();

            this.Text = "Nova despesa/receita";
            idTextBox.Text = "Automático";
            idTextBox.Enabled = false;

            mvFinanceiro = new MvFinanceiro();

        }

        public RegistoFinanceiroInserirEditarForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();
            ListarFinanceiro();

            this.Text = "Alteração despesa/receita";
            mvFinanceiro = new MvFinanceiroDAO().Buscar(id);

            idTextBox.Text = mvFinanceiro.ID.ToString();
            idTextBox.Enabled = false;

           // nomeTextBox.Text = financeiro.Nome;
            
            financeiroComboBox.SelectedValue = Convert.ToInt32(mvFinanceiro.IDFinanceiroTipo);

        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            // mvFinanceiro.IDFinanceiroTipo = Convert.ToInt32(financeiroComboBox.SelectedValue);

            //    financeiro.Nome = nomeTextBox.Text.Trim();
            if (dataVencimentoDateTimePicker.Value.Date == null)
            {
                MessageBox.Show("Selecione uma data",
                   "data nao verificada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     

            mvFinanceiro.Descricao = descricaoTextBox.Text.Trim();
            mvFinanceiro.Valor = Convert.ToDecimal(valorTextBox.Text.Trim());
            mvFinanceiro.DataVencimento = Convert.ToDateTime(dataVencimentoDateTimePicker.Value.Date);
            mvFinanceiro.IDFinanceiro = Convert.ToInt32(financeiroComboBox.SelectedValue);
                        
            mvFinanceiro.ID= new MvFinanceiroDAO().Salvar(mvFinanceiro);
          
            if (mvFinanceiro.ID == 0)
            {
                MessageBox.Show("Erro ao salvar!");
            }
            else
            {
                this.Text = "Alteração despesa/receita";
                idTextBox.Text = mvFinanceiro.ID.ToString();
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
