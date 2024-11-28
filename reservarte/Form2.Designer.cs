
namespace reservarte
{
    partial class frmBibliotecaBibli
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
            this.mnsOpcoes = new System.Windows.Forms.MenuStrip();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.músicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsOpcoes
            // 
            this.mnsOpcoes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsOpcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmesToolStripMenuItem,
            this.documentáriosToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.músicasToolStripMenuItem,
            this.novoToolStripMenuItem});
            this.mnsOpcoes.Location = new System.Drawing.Point(0, 0);
            this.mnsOpcoes.Name = "mnsOpcoes";
            this.mnsOpcoes.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.mnsOpcoes.Size = new System.Drawing.Size(582, 26);
            this.mnsOpcoes.TabIndex = 0;
            this.mnsOpcoes.Text = "menuStrip1";
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.filmesToolStripMenuItem.Text = "Filmes";
            // 
            // documentáriosToolStripMenuItem
            // 
            this.documentáriosToolStripMenuItem.Name = "documentáriosToolStripMenuItem";
            this.documentáriosToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.documentáriosToolStripMenuItem.Text = "Documentários";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // músicasToolStripMenuItem
            // 
            this.músicasToolStripMenuItem.Name = "músicasToolStripMenuItem";
            this.músicasToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.músicasToolStripMenuItem.Text = "Músicas";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // frmBibliotecaBibli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 365);
            this.Controls.Add(this.mnsOpcoes);
            this.MainMenuStrip = this.mnsOpcoes;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmBibliotecaBibli";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBibliotecaBibli_Load);
            this.mnsOpcoes.ResumeLayout(false);
            this.mnsOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsOpcoes;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem músicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
    }
}