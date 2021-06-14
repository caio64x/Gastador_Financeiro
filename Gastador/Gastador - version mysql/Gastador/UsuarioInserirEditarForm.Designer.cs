namespace Gastador
{
    partial class UsuarioInserirEditarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioInserirEditarForm));
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(12, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox.Location = new System.Drawing.Point(12, 68);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(158, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Location = new System.Drawing.Point(25, 169);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 3;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // salvarButton
            // 
            this.salvarButton.Image = global::Gastador.Properties.Resources.salvar;
            this.salvarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvarButton.Location = new System.Drawing.Point(295, 169);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(79, 25);
            this.salvarButton.TabIndex = 5;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(376, 169);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(79, 25);
            this.fecharButton.TabIndex = 6;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Image = global::Gastador.Properties.Resources.excluir;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(214, 169);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(79, 25);
            this.excluirButton.TabIndex = 4;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.loginTextBox.Location = new System.Drawing.Point(176, 68);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.senhaTextBox.Location = new System.Drawing.Point(282, 68);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(132, 20);
            this.senhaTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha";
            // 
            // UsuarioInserirEditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 198);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioInserirEditarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsuarioInserirEditarForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label label4;
    }
}