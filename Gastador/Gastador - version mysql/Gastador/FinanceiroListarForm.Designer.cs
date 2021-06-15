namespace Gastador
{
    partial class FinanceiroListarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceiroListarForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscarButton = new System.Windows.Forms.Button();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFinanceiroTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.financeiroTipoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financeiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fecharButton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buscarButton);
            this.panel1.Controls.Add(this.filtroTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 0;
            // 
            // buscarButton
            // 
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(344, 35);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 1;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(15, 37);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(323, 20);
            this.filtroTextBox.TabIndex = 0;
            this.filtroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtroTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o Nome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 323);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddataGridViewTextBoxColumn1,
            this.iDFinanceiroTipoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.financeiroTipoNomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.financeiroBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // iddataGridViewTextBoxColumn1
            // 
            this.iddataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iddataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iddataGridViewTextBoxColumn1.Name = "iddataGridViewTextBoxColumn1";
            this.iddataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDFinanceiroTipoDataGridViewTextBoxColumn
            // 
            this.iDFinanceiroTipoDataGridViewTextBoxColumn.DataPropertyName = "IDFinanceiroTipo";
            this.iDFinanceiroTipoDataGridViewTextBoxColumn.HeaderText = "IDFinanceiroTipo";
            this.iDFinanceiroTipoDataGridViewTextBoxColumn.Name = "iDFinanceiroTipoDataGridViewTextBoxColumn";
            this.iDFinanceiroTipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // financeiroTipoNomeDataGridViewTextBoxColumn
            // 
            this.financeiroTipoNomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.financeiroTipoNomeDataGridViewTextBoxColumn.DataPropertyName = "FinanceiroTipoNome";
            this.financeiroTipoNomeDataGridViewTextBoxColumn.HeaderText = "FinanceiroTipo";
            this.financeiroTipoNomeDataGridViewTextBoxColumn.Name = "financeiroTipoNomeDataGridViewTextBoxColumn";
            this.financeiroTipoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // financeiroBindingSource
            // 
            this.financeiroBindingSource.DataSource = typeof(Gastador.Negocios.Mapeamento.Financeiro);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.quantidadeLabel);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 55);
            this.panel3.TabIndex = 1;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(12, 20);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(84, 13);
            this.quantidadeLabel.TabIndex = 4;
            this.quantidadeLabel.Text = "Nenhum registro";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fecharButton);
            this.panel4.Controls.Add(this.inserirButton);
            this.panel4.Controls.Add(this.alterarButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(344, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 55);
            this.panel4.TabIndex = 0;
            // 
            // fecharButton
            // 
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(365, 20);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(79, 25);
            this.fecharButton.TabIndex = 2;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // inserirButton
            // 
            this.inserirButton.Image = global::Gastador.Properties.Resources.incluir;
            this.inserirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inserirButton.Location = new System.Drawing.Point(203, 20);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(79, 25);
            this.inserirButton.TabIndex = 0;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Image = global::Gastador.Properties.Resources.alterar;
            this.alterarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarButton.Location = new System.Drawing.Point(284, 20);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(79, 25);
            this.alterarButton.TabIndex = 1;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // FinanceiroListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinanceiroListarForm";
            this.Text = "Lista de tipos de finanças";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.buscarButton_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button alterarButton;
  
        private System.Windows.Forms.BindingSource financeiroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFinanceiroTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn financeiroTipoNomeDataGridViewTextBoxColumn;
    }
}