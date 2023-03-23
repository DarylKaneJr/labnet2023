namespace Lab.EF.UI
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.methodSintaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.del1Al6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.de7A13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.methodSintaxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // methodSintaxToolStripMenuItem
            // 
            this.methodSintaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delToolStripMenuItem});
            this.methodSintaxToolStripMenuItem.Name = "methodSintaxToolStripMenuItem";
            this.methodSintaxToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.methodSintaxToolStripMenuItem.Text = "Practica LINQ";
            this.methodSintaxToolStripMenuItem.Click += new System.EventHandler(this.methodSintaxToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.del1Al6ToolStripMenuItem,
            this.de7A13ToolStripMenuItem});
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delToolStripMenuItem.Text = "Consultas";
            // 
            // del1Al6ToolStripMenuItem
            // 
            this.del1Al6ToolStripMenuItem.Name = "del1Al6ToolStripMenuItem";
            this.del1Al6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.del1Al6ToolStripMenuItem.Text = "De 1 al 6";
            this.del1Al6ToolStripMenuItem.Click += new System.EventHandler(this.del1Al6ToolStripMenuItem_Click);
            // 
            // de7A13ToolStripMenuItem
            // 
            this.de7A13ToolStripMenuItem.Name = "de7A13ToolStripMenuItem";
            this.de7A13ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.de7A13ToolStripMenuItem.Text = "De 7 a 13";
            this.de7A13ToolStripMenuItem.Click += new System.EventHandler(this.de7A13ToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 214);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem methodSintaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem del1Al6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem de7A13ToolStripMenuItem;
    }
}

