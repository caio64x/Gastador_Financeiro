namespace Gastador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistoFinanceiroInserirEditarForm));
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.financeiroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataVencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.excluirButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.repetirCadastroCheckBox = new System.Windows.Forms.CheckBox();
            this.valorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.mvFinanceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvFinanceiroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(1, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // salvarButton
            // 
            this.salvarButton.Image = global::Gastador.Properties.Resources.salvar;
            this.salvarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvarButton.Location = new System.Drawing.Point(370, 237);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(79, 25);
            this.salvarButton.TabIndex = 6;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(451, 237);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(79, 25);
            this.fecharButton.TabIndex = 7;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // financeiroComboBox
            // 
            this.financeiroComboBox.DisplayMember = "1";
            this.financeiroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.financeiroComboBox.FormattingEnabled = true;
            this.financeiroComboBox.Location = new System.Drawing.Point(126, 25);
            this.financeiroComboBox.Name = "financeiroComboBox";
            this.financeiroComboBox.Size = new System.Drawing.Size(273, 21);
            this.financeiroComboBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(123, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Despesa/Receita";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descricaoTextBox.Location = new System.Drawing.Point(1, 81);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(532, 140);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor";
            // 
            // dataVencimentoDateTimePicker
            // 
            this.dataVencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVencimentoDateTimePicker.Location = new System.Drawing.Point(402, 26);
            this.dataVencimentoDateTimePicker.Name = "dataVencimentoDateTimePicker";
            this.dataVencimentoDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.dataVencimentoDateTimePicker.TabIndex = 1;
            this.dataVencimentoDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dataVencimentoDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataVencimentoDateTimePicker_KeyDown);
            // 
            // excluirButton
            // 
            this.excluirButton.Image = global::Gastador.Properties.Resources.excluir;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(289, 237);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(79, 25);
            this.excluirButton.TabIndex = 5;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(397, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de vencimento";
            // 
            // repetirCadastroCheckBox
            // 
            this.repetirCadastroCheckBox.AutoSize = true;
            this.repetirCadastroCheckBox.Location = new System.Drawing.Point(394, 61);
            this.repetirCadastroCheckBox.Name = "repetirCadastroCheckBox";
            this.repetirCadastroCheckBox.Size = new System.Drawing.Size(104, 17);
            this.repetirCadastroCheckBox.TabIndex = 2;
            this.repetirCadastroCheckBox.Text = "Repetir cadastro";
            this.repetirCadastroCheckBox.UseVisualStyleBackColor = true;
            // 
            // valorNumericUpDown
            // 
            this.valorNumericUpDown.DecimalPlaces = 2;
            this.valorNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.valorNumericUpDown.Location = new System.Drawing.Point(72, 238);
            this.valorNumericUpDown.Maximum = new decimal(new int[] {
            -1586618625,
            232830643,
            0,
            131072});
            this.valorNumericUpDown.Name = "valorNumericUpDown";
            this.valorNumericUpDown.Size = new System.Drawing.Size(211, 23);
            this.valorNumericUpDown.TabIndex = 4;
            this.valorNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorNumericUpDown.ValueChanged += new System.EventHandler(this.valorNumericUpDown_ValueChanged);
            this.valorNumericUpDown.Enter += new System.EventHandler(this.valorNumericUpDown_Enter);
            this.valorNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valorNumericUpDown_KeyDown);
            this.valorNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorNumericUpDown_KeyPress);
            this.valorNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.valorNumericUpDown_MouseClick);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Gastador.Properties.Resources.incluir;
            this.button1.Location = new System.Drawing.Point(102, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mvFinanceiroBindingSource
            // 
            this.mvFinanceiroBindingSource.DataSource = typeof(Gastador.Negocios.Mapeamento.MvFinanceiro);
            // 
            // RegistoFinanceiroInserirEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valorNumericUpDown);
            this.Controls.Add(this.repetirCadastroCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.dataVencimentoDateTimePicker);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistoFinanceiroInserirEditarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistoFinanceiroInserirEditarForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvFinanceiroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource mvFinanceiroBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataVencimentoDateTimePicker;
        private System.Windows.Forms.Button excluirButton;
        public System.Windows.Forms.ComboBox financeiroComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox repetirCadastroCheckBox;
        private System.Windows.Forms.NumericUpDown valorNumericUpDown;
        private System.Windows.Forms.Button button1;
    }
}