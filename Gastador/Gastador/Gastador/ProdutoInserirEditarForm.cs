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
    public partial class ProdutoInserirEditarForm : Form
    {
        Financeiro produto = null;

        void ListarCategorias(bool somenteAtivos)
        {
            //var lista = new CategoriaDAO().ListarParaCombo(somenteAtivos);
            //categoriaComboBox.ValueMember = "ID";
            //categoriaComboBox.DisplayMember = "Nome";
            //categoriaComboBox.DataSource = lista;
        }
        public ProdutoInserirEditarForm()
        {
            InitializeComponent();
            Application.DoEvents();

            ListarCategorias(true);

            this.Text = "Novo Produto";
            idTextBox.Text = "Automático";
            idTextBox.Enabled = false;
            excluirButton.Enabled = false;
            produto = new Financeiro();

        }

        public ProdutoInserirEditarForm(int id)
        {
            //InitializeComponent();
            //Application.DoEvents();

            //ListarCategorias(true);

            //this.Text = "Alteração de Produto";
            //produto = new ProdutoDAO().Buscar(id);

            //idTextBox.Text = produto.ID.ToString();
            //idTextBox.Enabled = false;

            //categoriaComboBox.SelectedValue = produto.IDCategoria;

            //nomeTextBox.Text = produto.Nome;
            //ativoCheckBox.Checked = produto.Ativo;
            //quantidadeNumericUpDown.Value = produto.Quantidade;
            //valorNumericUpDown.Value = produto.Valor;

            //excluirButton.Enabled = true;
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            //produto.Nome = nomeTextBox.Text.Trim();
            //produto.Ativo = ativoCheckBox.Checked;

            //produto.Quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value);
            //produto.Valor = Convert.ToDecimal(valorNumericUpDown.Value);


            //produto.IDCategoria = Convert.ToInt32(categoriaComboBox.SelectedValue);

            ////executa e pega o id
            //produto.ID= new ProdutoDAO().Salvar(produto);

            if (produto.ID == 0)
            {
                MessageBox.Show("Erro ao salvar!");
            }
            else
            {
                this.Text = "Alteração de Produto";
                idTextBox.Text = produto.ID.ToString();
                excluirButton.Enabled = true;

                MessageBox.Show("Registro salvo com sucesso!");
            }

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro " + produto.Nome + "?",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //var resp = new ProdutoDAO().Excluir(produto.ID);
                //if (resp)
                //{
                //    MessageBox.Show("Excluído com sucesso");
                //    Close();
                //}
                //else
                //{
                //    MessageBox.Show("Erro ao excluir!");
                //}
            }
        }

       
    }
}
