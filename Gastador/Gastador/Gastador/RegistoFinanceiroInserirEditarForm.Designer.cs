﻿namespace Gastador
{
    partial class RegistoFinanceiroInserirEditarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.financeiroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataVencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mvFinanceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mvFinanceiroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(12, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(306, 226);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 4;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(387, 226);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 3;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // financeiroComboBox
            // 
            this.financeiroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.financeiroComboBox.FormattingEnabled = true;
            this.financeiroComboBox.Location = new System.Drawing.Point(126, 20);
            this.financeiroComboBox.Name = "financeiroComboBox";
            this.financeiroComboBox.Size = new System.Drawing.Size(204, 21);
            this.financeiroComboBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Despesa/Receita";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(1, 60);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(532, 120);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mvFinanceiroBindingSource, "Valor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.valorTextBox.Location = new System.Drawing.Point(79, 226);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(208, 23);
            this.valorTextBox.TabIndex = 2;
            this.valorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor";
            // 
            // dataVencimentoDateTimePicker
            // 
            this.dataVencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVencimentoDateTimePicker.Location = new System.Drawing.Point(344, 21);
            this.dataVencimentoDateTimePicker.Name = "dataVencimentoDateTimePicker";
            this.dataVencimentoDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.dataVencimentoDateTimePicker.TabIndex = 11;
            this.dataVencimentoDateTimePicker.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // mvFinanceiroBindingSource
            // 
            this.mvFinanceiroBindingSource.DataSource = typeof(Gastador.Negocios.Mapeamento.MvFinanceiro);
            // 
            // RegistoFinanceiroInserirEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 261);
            this.Controls.Add(this.dataVencimentoDateTimePicker);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.financeiroComboBox);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistoFinanceiroInserirEditarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.mvFinanceiroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.ComboBox financeiroComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource mvFinanceiroBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataVencimentoDateTimePicker;
    }
}