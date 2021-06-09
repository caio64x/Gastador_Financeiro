﻿using Gastador.Negocios.DAL;
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
            excluirButton.Enabled = false;
            dataVencimentoDateTimePicker.Text = ("");
            valorTextBox.Text = "0,00";
            mvFinanceiro = new MvFinanceiro();

        }


        public RegistoFinanceiroInserirEditarForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();
            ListarFinanceiro();

            this.Text = "Alteração despesa/receita";
            mvFinanceiro = new MvFinanceiroDAO().Buscar(id);

            

            financeiroComboBox.SelectedValue = Convert.ToInt32(mvFinanceiro.IDFinanceiro);

            dataVencimentoDateTimePicker.Value = mvFinanceiro.DataVencimento;
            idTextBox.Text = mvFinanceiro.ID.ToString();
            descricaoTextBox.Text = mvFinanceiro.Descricao.ToString().Trim();
            valorTextBox.Text = mvFinanceiro.Valor.ToString().Trim();
            idTextBox.Enabled = false;
            // nomeTextBox.Text = financeiro.Nome;
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {

            if (dataVencimentoDateTimePicker.Text == "")
            {
                MessageBox.Show("Selecione uma data",
                   "data nao verificada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mvFinanceiro.Descricao = descricaoTextBox.Text.Trim();
            mvFinanceiro.Valor = Convert.ToDecimal(valorTextBox.Text.Trim());
            //formatar data do datatimepicker pra pegar so a data
            mvFinanceiro.DataVencimento = Convert.ToDateTime(dataVencimentoDateTimePicker.Value.Date);
            mvFinanceiro.IDFinanceiro = Convert.ToInt32(financeiroComboBox.SelectedValue);

            if (mvFinanceiro.IDFinanceiro == 0)
            {
                MessageBox.Show("Selecione a despesa/receita!");
            }
            else
            {
                //com repetição de cadastro
                if (repetirCadastroCheckBox.Checked)
                {
                    mvFinanceiro.ID = 0;
                    mvFinanceiro.ID = new MvFinanceiroDAO().Salvar(mvFinanceiro);

                    if (mvFinanceiro.ID == 0)
                    {
                        MessageBox.Show("Erro ao salvar!");
                    }
                    else
                    {
                        this.Text = "Alteração despesa/receita";
                        idTextBox.Text = mvFinanceiro.ID.ToString();
                        excluirButton.Enabled = true;
                        MessageBox.Show("Registro salvo com sucesso!");
                    }
                }
                else
                {
                    //sem repetição de cadastro
                    mvFinanceiro.ID = new MvFinanceiroDAO().Salvar(mvFinanceiro);

                    if (mvFinanceiro.ID == 0)
                    {
                        MessageBox.Show("Erro ao salvar!");
                    }
                    else
                    {
                        this.Text = "Alteração despesa/receita";
                        idTextBox.Text = mvFinanceiro.ID.ToString();
                        excluirButton.Enabled = true;
                        MessageBox.Show("Registro salvo com sucesso!");
                    }
                }
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro " + mvFinanceiro.ID + " " + mvFinanceiro.NomeFinanceiro + "?",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var resp = new MvFinanceiroDAO().Excluir(mvFinanceiro.ID);
                if (resp)
                {
                    MessageBox.Show("Excluído com sucesso");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir!");
                }
            }
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44)
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }


            }

        }

        private void RegistoFinanceiroInserirEditarForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
