
namespace Gastador
{
    partial class RestaurarBackup
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
            this.diretorioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restaurarButton = new System.Windows.Forms.Button();
            this.selecionarSqlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // diretorioTextBox
            // 
            this.diretorioTextBox.Location = new System.Drawing.Point(12, 82);
            this.diretorioTextBox.Name = "diretorioTextBox";
            this.diretorioTextBox.ReadOnly = true;
            this.diretorioTextBox.Size = new System.Drawing.Size(472, 20);
            this.diretorioTextBox.TabIndex = 0;
            this.diretorioTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(138, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESTAURAR BACKUP\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione o arquivo de backup";
            // 
            // restaurarButton
            // 
            this.restaurarButton.Location = new System.Drawing.Point(12, 108);
            this.restaurarButton.Name = "restaurarButton";
            this.restaurarButton.Size = new System.Drawing.Size(129, 23);
            this.restaurarButton.TabIndex = 3;
            this.restaurarButton.Text = "Restaurar";
            this.restaurarButton.UseVisualStyleBackColor = true;
            this.restaurarButton.Click += new System.EventHandler(this.restaurarButton_Click);
            // 
            // selecionarSqlOpenFileDialog
            // 
            this.selecionarSqlOpenFileDialog.Filter = "Arquivos de banco (*.sql*)|*.*";
            this.selecionarSqlOpenFileDialog.FilterIndex = 2;
            this.selecionarSqlOpenFileDialog.InitialDirectory = "C:\\\\Gastador\\\\Backup";
            this.selecionarSqlOpenFileDialog.RestoreDirectory = true;
            // 
            // RestaurarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 144);
            this.Controls.Add(this.restaurarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diretorioTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestaurarBackup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurar Backup";
            this.Load += new System.EventHandler(this.RestaurarBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diretorioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restaurarButton;
        private System.Windows.Forms.OpenFileDialog selecionarSqlOpenFileDialog;
    }
}