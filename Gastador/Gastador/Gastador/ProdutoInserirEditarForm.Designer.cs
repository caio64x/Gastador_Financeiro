namespace Gastador
{
    partial class ProdutoInserirEditarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantidadeCheckBox = new System.Windows.Forms.CheckBox();
            this.valorUnitarioCheckBox = new System.Windows.Forms.CheckBox();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(12, 29);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(12, 75);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(437, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(298, 167);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 6;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(379, 167);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 7;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(217, 167);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 8;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(118, 29);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(331, 21);
            this.categoriaComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria";
            // 
            // quantidadeCheckBox
            // 
            this.quantidadeCheckBox.AutoSize = true;
            this.quantidadeCheckBox.Location = new System.Drawing.Point(15, 105);
            this.quantidadeCheckBox.Name = "quantidadeCheckBox";
            this.quantidadeCheckBox.Size = new System.Drawing.Size(81, 17);
            this.quantidadeCheckBox.TabIndex = 9;
            this.quantidadeCheckBox.Text = "Quantidade";
            this.quantidadeCheckBox.UseVisualStyleBackColor = true;
            // 
            // valorUnitarioCheckBox
            // 
            this.valorUnitarioCheckBox.AutoSize = true;
            this.valorUnitarioCheckBox.Location = new System.Drawing.Point(151, 105);
            this.valorUnitarioCheckBox.Name = "valorUnitarioCheckBox";
            this.valorUnitarioCheckBox.Size = new System.Drawing.Size(89, 17);
            this.valorUnitarioCheckBox.TabIndex = 10;
            this.valorUnitarioCheckBox.Text = "Valor Unitario";
            this.valorUnitarioCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(15, 128);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.quantidadeNumericUpDown.TabIndex = 3;
            this.quantidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorNumericUpDown
            // 
            this.valorNumericUpDown.DecimalPlaces = 2;
            this.valorNumericUpDown.Location = new System.Drawing.Point(151, 128);
            this.valorNumericUpDown.Name = "valorNumericUpDown";
            this.valorNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valorNumericUpDown.TabIndex = 4;
            this.valorNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Location = new System.Drawing.Point(288, 128);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 11;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProdutoInserirEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 205);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.valorNumericUpDown);
            this.Controls.Add(this.quantidadeNumericUpDown);
            this.Controls.Add(this.valorUnitarioCheckBox);
            this.Controls.Add(this.quantidadeCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdutoInserirEditarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox quantidadeCheckBox;
        private System.Windows.Forms.CheckBox valorUnitarioCheckBox;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.NumericUpDown valorNumericUpDown;
        private System.Windows.Forms.CheckBox ativoCheckBox;
    }
}