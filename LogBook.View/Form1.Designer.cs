namespace LogBook.View
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioDeBordoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diarioDeBordoPorTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioDeBordoPorAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.relatrioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.diárioDeBordoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // relatrioToolStripMenuItem
            // 
            this.relatrioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diarioDeBordoPorTurmaToolStripMenuItem,
            this.diárioDeBordoPorAlunoToolStripMenuItem});
            this.relatrioToolStripMenuItem.Name = "relatrioToolStripMenuItem";
            this.relatrioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatrioToolStripMenuItem.Text = "Relatório";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // diárioDeBordoToolStripMenuItem
            // 
            this.diárioDeBordoToolStripMenuItem.Name = "diárioDeBordoToolStripMenuItem";
            this.diárioDeBordoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diárioDeBordoToolStripMenuItem.Text = "Diário de Bordo";
            this.diárioDeBordoToolStripMenuItem.Click += new System.EventHandler(this.diárioDeBordoToolStripMenuItem_Click);
            // 
            // diarioDeBordoPorTurmaToolStripMenuItem
            // 
            this.diarioDeBordoPorTurmaToolStripMenuItem.Name = "diarioDeBordoPorTurmaToolStripMenuItem";
            this.diarioDeBordoPorTurmaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.diarioDeBordoPorTurmaToolStripMenuItem.Text = "Diário de Bordo por Turma";
            // 
            // diárioDeBordoPorAlunoToolStripMenuItem
            // 
            this.diárioDeBordoPorAlunoToolStripMenuItem.Name = "diárioDeBordoPorAlunoToolStripMenuItem";
            this.diárioDeBordoPorAlunoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.diárioDeBordoPorAlunoToolStripMenuItem.Text = "Diário de Bordo por Aluno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioDeBordoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diarioDeBordoPorTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioDeBordoPorAlunoToolStripMenuItem;
    }
}

