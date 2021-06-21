namespace Gastador
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loginToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariostoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.registrarFinanceiroToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.relatorioMensalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeCustoreceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.usuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realziarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.loginToolStripButton,
            this.toolStripSeparator2,
            this.usuariostoolStripButton,
            this.registrarFinanceiroToolStripButton,
            this.relatorioMensalToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 54);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // loginToolStripButton
            // 
            this.loginToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loginToolStripButton.Name = "loginToolStripButton";
            this.loginToolStripButton.Size = new System.Drawing.Size(42, 51);
            this.loginToolStripButton.Text = "Entrar";
            this.loginToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loginToolStripButton.Click += new System.EventHandler(this.loginToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // usuariostoolStripButton
            // 
            this.usuariostoolStripButton.Image = global::Gastador.Properties.Resources.usuarios;
            this.usuariostoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usuariostoolStripButton.Name = "usuariostoolStripButton";
            this.usuariostoolStripButton.Size = new System.Drawing.Size(56, 51);
            this.usuariostoolStripButton.Text = "Usuários";
            this.usuariostoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuariostoolStripButton.ToolTipText = "Gerenciar os usuarios";
            this.usuariostoolStripButton.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // registrarFinanceiroToolStripButton
            // 
            this.registrarFinanceiroToolStripButton.Image = global::Gastador.Properties.Resources.registro;
            this.registrarFinanceiroToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.registrarFinanceiroToolStripButton.Name = "registrarFinanceiroToolStripButton";
            this.registrarFinanceiroToolStripButton.Size = new System.Drawing.Size(110, 51);
            this.registrarFinanceiroToolStripButton.Text = "Registro financeiro";
            this.registrarFinanceiroToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registrarFinanceiroToolStripButton.ToolTipText = "Registro despesa ou receita";
            this.registrarFinanceiroToolStripButton.Click += new System.EventHandler(this.registrarFinanceiroToolStripMenuItem_Click);
            // 
            // relatorioMensalToolStripButton
            // 
            this.relatorioMensalToolStripButton.Image = global::Gastador.Properties.Resources.relatoriomensal;
            this.relatorioMensalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.relatorioMensalToolStripButton.Name = "relatorioMensalToolStripButton";
            this.relatorioMensalToolStripButton.Size = new System.Drawing.Size(99, 51);
            this.relatorioMensalToolStripButton.Text = "Relatório mensal";
            this.relatorioMensalToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.relatorioMensalToolStripButton.ToolTipText = "Visualizar o resumo de cada mês";
            this.relatorioMensalToolStripButton.Click += new System.EventHandler(this.relatorioMensalToolStripButton_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.centroDeCustoreceitaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.usuariosToolStripMenuItem.Text = "Usuários";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // centroDeCustoreceitaToolStripMenuItem
            // 
            this.centroDeCustoreceitaToolStripMenuItem.Name = "centroDeCustoreceitaToolStripMenuItem";
            this.centroDeCustoreceitaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.centroDeCustoreceitaToolStripMenuItem.Text = "Centro de custo/receita";
            this.centroDeCustoreceitaToolStripMenuItem.Click += new System.EventHandler(this.centroDeCustoreceitaToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.atualizaçõesToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // atualizaçõesToolStripMenuItem
            // 
            this.atualizaçõesToolStripMenuItem.Name = "atualizaçõesToolStripMenuItem";
            this.atualizaçõesToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.atualizaçõesToolStripMenuItem.Text = "Atualizar Sistema";
            this.atualizaçõesToolStripMenuItem.Click += new System.EventHandler(this.atualizaçõesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // usuarioToolStripStatusLabel
            // 
            this.usuarioToolStripStatusLabel.Name = "usuarioToolStripStatusLabel";
            this.usuarioToolStripStatusLabel.Size = new System.Drawing.Size(47, 17);
            this.usuarioToolStripStatusLabel.Text = "Usuário";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realziarBackupToolStripMenuItem,
            this.restaurarToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "backup";
            // 
            // realziarBackupToolStripMenuItem
            // 
            this.realziarBackupToolStripMenuItem.Name = "realziarBackupToolStripMenuItem";
            this.realziarBackupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realziarBackupToolStripMenuItem.Text = "Realizar backup";
            this.realziarBackupToolStripMenuItem.Click += new System.EventHandler(this.realziarBackupToolStripMenuItem_Click);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar backup";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PrincipalForm";
            this.Text = "Gastador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.Shown += new System.EventHandler(this.PrincipalForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton loginToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton registrarFinanceiroToolStripButton;
        private System.Windows.Forms.ToolStripButton relatorioMensalToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel usuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton usuariostoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem centroDeCustoreceitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realziarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
    }
}

