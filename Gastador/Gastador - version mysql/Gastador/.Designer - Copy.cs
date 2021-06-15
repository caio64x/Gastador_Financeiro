namespace Gastador
{
    partial class RelatorioMensalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioMensalForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.anoDespesaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mesDespesacomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeFinanceiroTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFinanceiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.restanteReceberlabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lucroLabel = new System.Windows.Forms.Label();
            this.restantePagarLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.valorTotalDespesaFixaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valorTotalDespesaVariavelLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorTotalDespesaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valorTotalReceitaLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fecharButton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.iDdataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFinanceiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConfirmacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvFinanceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvFinanceiroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.anoDespesaDateTimePicker);
            this.panel1.Controls.Add(this.mesDespesacomboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buscarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 72);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(559, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ano despesa";
            // 
            // anoDespesaDateTimePicker
            // 
            this.anoDespesaDateTimePicker.CustomFormat = "yyyy";
            this.anoDespesaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.anoDespesaDateTimePicker.Location = new System.Drawing.Point(562, 38);
            this.anoDespesaDateTimePicker.Name = "anoDespesaDateTimePicker";
            this.anoDespesaDateTimePicker.Size = new System.Drawing.Size(79, 20);
            this.anoDespesaDateTimePicker.TabIndex = 9;
            this.anoDespesaDateTimePicker.Value = new System.DateTime(2021, 6, 12, 0, 0, 0, 0);
            // 
            // mesDespesacomboBox
            // 
            this.mesDespesacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesDespesacomboBox.FormattingEnabled = true;
            this.mesDespesacomboBox.Items.AddRange(new object[] {
            "MÊS ATUAL",
            "01 - JANEIRO",
            "02 - FEVEREIRO",
            "03 - MARÇO ",
            "04 - ABRIL ",
            "05 - MAIO ",
            "06 - JUNHO",
            "07 - JULHO ",
            "08 - AGOSTO ",
            "09 - SETEMBRO ",
            "10 - OUTUBRO ",
            "11 - NOVEMBRO ",
            "12 - DEZEMBRO"});
            this.mesDespesacomboBox.Location = new System.Drawing.Point(424, 37);
            this.mesDespesacomboBox.Name = "mesDespesacomboBox";
            this.mesDespesacomboBox.Size = new System.Drawing.Size(121, 21);
            this.mesDespesacomboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(421, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Despesa do mês";
            // 
            // buscarButton
            // 
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(343, 36);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 1;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 408);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDdataGridViewTextBoxColumn1,
            this.iDFinanceiroDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn,
            this.NomeFinanceiroTipo,
            this.NomeFinanceiro,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataConfirmacaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mvFinanceiroBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(818, 408);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // NomeFinanceiroTipo
            // 
            this.NomeFinanceiroTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NomeFinanceiroTipo.DataPropertyName = "NomeFinanceiroTipo";
            this.NomeFinanceiroTipo.HeaderText = "Tipo";
            this.NomeFinanceiroTipo.Name = "NomeFinanceiroTipo";
            this.NomeFinanceiroTipo.ReadOnly = true;
            this.NomeFinanceiroTipo.Width = 53;
            // 
            // NomeFinanceiro
            // 
            this.NomeFinanceiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NomeFinanceiro.DataPropertyName = "NomeFinanceiro";
            this.NomeFinanceiro.HeaderText = "Despesa/Receita";
            this.NomeFinanceiro.Name = "NomeFinanceiro";
            this.NomeFinanceiro.ReadOnly = true;
            this.NomeFinanceiro.Width = 116;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.restanteReceberlabel);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lucroLabel);
            this.panel5.Controls.Add(this.restantePagarLabel);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.valorTotalDespesaFixaLabel);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.valorTotalDespesaVariavelLabel);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.valorTotalDespesaLabel);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.valorTotalReceitaLabel);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1358, 408);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(982, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Restante a receber";
            // 
            // restanteReceberlabel
            // 
            this.restanteReceberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restanteReceberlabel.ForeColor = System.Drawing.Color.Green;
            this.restanteReceberlabel.Location = new System.Drawing.Point(822, 274);
            this.restanteReceberlabel.Name = "restanteReceberlabel";
            this.restanteReceberlabel.Size = new System.Drawing.Size(361, 17);
            this.restanteReceberlabel.TabIndex = 23;
            this.restanteReceberlabel.Text = "...";
            this.restanteReceberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(982, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Lucro";
            // 
            // lucroLabel
            // 
            this.lucroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lucroLabel.ForeColor = System.Drawing.Color.Green;
            this.lucroLabel.Location = new System.Drawing.Point(822, 383);
            this.lucroLabel.Name = "lucroLabel";
            this.lucroLabel.Size = new System.Drawing.Size(361, 17);
            this.lucroLabel.TabIndex = 21;
            this.lucroLabel.Text = "...";
            this.lucroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restantePagarLabel
            // 
            this.restantePagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restantePagarLabel.ForeColor = System.Drawing.Color.Red;
            this.restantePagarLabel.Location = new System.Drawing.Point(822, 323);
            this.restantePagarLabel.Name = "restantePagarLabel";
            this.restantePagarLabel.Size = new System.Drawing.Size(361, 17);
            this.restantePagarLabel.TabIndex = 19;
            this.restantePagarLabel.Text = "...";
            this.restantePagarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(982, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total despesas fixas confirmadas";
            // 
            // valorTotalDespesaFixaLabel
            // 
            this.valorTotalDespesaFixaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalDespesaFixaLabel.ForeColor = System.Drawing.Color.Red;
            this.valorTotalDespesaFixaLabel.Location = new System.Drawing.Point(822, 140);
            this.valorTotalDespesaFixaLabel.Name = "valorTotalDespesaFixaLabel";
            this.valorTotalDespesaFixaLabel.Size = new System.Drawing.Size(361, 17);
            this.valorTotalDespesaFixaLabel.TabIndex = 17;
            this.valorTotalDespesaFixaLabel.Text = "...";
            this.valorTotalDespesaFixaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(982, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total despesas variaveis confirmadas";
            // 
            // valorTotalDespesaVariavelLabel
            // 
            this.valorTotalDespesaVariavelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalDespesaVariavelLabel.ForeColor = System.Drawing.Color.Red;
            this.valorTotalDespesaVariavelLabel.Location = new System.Drawing.Point(822, 90);
            this.valorTotalDespesaVariavelLabel.Name = "valorTotalDespesaVariavelLabel";
            this.valorTotalDespesaVariavelLabel.Size = new System.Drawing.Size(361, 17);
            this.valorTotalDespesaVariavelLabel.TabIndex = 15;
            this.valorTotalDespesaVariavelLabel.Text = "...";
            this.valorTotalDespesaVariavelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(982, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total despesas confirmadas";
            // 
            // valorTotalDespesaLabel
            // 
            this.valorTotalDespesaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalDespesaLabel.ForeColor = System.Drawing.Color.Red;
            this.valorTotalDespesaLabel.Location = new System.Drawing.Point(822, 189);
            this.valorTotalDespesaLabel.Name = "valorTotalDespesaLabel";
            this.valorTotalDespesaLabel.Size = new System.Drawing.Size(361, 17);
            this.valorTotalDespesaLabel.TabIndex = 11;
            this.valorTotalDespesaLabel.Text = "...";
            this.valorTotalDespesaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(982, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total receitas confirmadas";
            // 
            // valorTotalReceitaLabel
            // 
            this.valorTotalReceitaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalReceitaLabel.ForeColor = System.Drawing.Color.Green;
            this.valorTotalReceitaLabel.Location = new System.Drawing.Point(822, 37);
            this.valorTotalReceitaLabel.Name = "valorTotalReceitaLabel";
            this.valorTotalReceitaLabel.Size = new System.Drawing.Size(361, 17);
            this.valorTotalReceitaLabel.TabIndex = 12;
            this.valorTotalReceitaLabel.Text = "...";
            this.valorTotalReceitaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(982, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Restante a pagar";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.quantidadeLabel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1358, 50);
            this.panel3.TabIndex = 1;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(12, 17);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(84, 13);
            this.quantidadeLabel.TabIndex = 4;
            this.quantidadeLabel.Text = "Nenhum registro";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fecharButton);
            this.panel4.Controls.Add(this.inserirButton);
            this.panel4.Controls.Add(this.excluirButton);
            this.panel4.Controls.Add(this.alterarButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(787, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(571, 50);
            this.panel4.TabIndex = 0;
            // 
            // fecharButton
            // 
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(487, 19);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(79, 25);
            this.fecharButton.TabIndex = 3;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // inserirButton
            // 
            this.inserirButton.Image = ((System.Drawing.Image)(resources.GetObject("inserirButton.Image")));
            this.inserirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inserirButton.Location = new System.Drawing.Point(244, 19);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(79, 25);
            this.inserirButton.TabIndex = 0;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirButton.Image")));
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(406, 19);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(79, 25);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Image = ((System.Drawing.Image)(resources.GetObject("alterarButton.Image")));
            this.alterarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarButton.Location = new System.Drawing.Point(325, 19);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(79, 25);
            this.alterarButton.TabIndex = 1;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // iDdataGridViewTextBoxColumn1
            // 
            this.iDdataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDdataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDdataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDdataGridViewTextBoxColumn1.Name = "iDdataGridViewTextBoxColumn1";
            this.iDdataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDdataGridViewTextBoxColumn1.Width = 43;
            // 
            // iDFinanceiroDataGridViewTextBoxColumn
            // 
            this.iDFinanceiroDataGridViewTextBoxColumn.DataPropertyName = "IDFinanceiro";
            this.iDFinanceiroDataGridViewTextBoxColumn.HeaderText = "IDFinanceiro";
            this.iDFinanceiroDataGridViewTextBoxColumn.Name = "iDFinanceiroDataGridViewTextBoxColumn";
            this.iDFinanceiroDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFinanceiroDataGridViewTextBoxColumn.Visible = false;
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "Pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "Pago";
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            this.pagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagoDataGridViewTextBoxColumn.Width = 57;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataConfirmacaoDataGridViewTextBoxColumn
            // 
            this.dataConfirmacaoDataGridViewTextBoxColumn.DataPropertyName = "DataConfirmacao";
            this.dataConfirmacaoDataGridViewTextBoxColumn.HeaderText = "DataConfirmacao";
            this.dataConfirmacaoDataGridViewTextBoxColumn.Name = "dataConfirmacaoDataGridViewTextBoxColumn";
            this.dataConfirmacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataConfirmacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // mvFinanceiroBindingSource
            // 
            this.mvFinanceiroBindingSource.DataSource = typeof(Gastador.Negocios.Mapeamento.MvFinanceiro);
            // 
            // RelatorioMensalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioMensalForm";
            this.Text = "Relatorio mensal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegistrarFinanceiroForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mvFinanceiroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button alterarButton;
        //private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn iDCategoriaDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn categoriaNomeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label valorTotalDespesaLabel;
        private System.Windows.Forms.BindingSource mvFinanceiroBindingSource;
        private System.Windows.Forms.Label valorTotalReceitaLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox mesDespesacomboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label valorTotalDespesaFixaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label valorTotalDespesaVariavelLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label restantePagarLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lucroLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label restanteReceberlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker anoDespesaDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFinanceiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFinanceiroTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFinanceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConfirmacaoDataGridViewTextBoxColumn;
    }
}