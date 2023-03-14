namespace labNetPractica3.Consultas
{
    partial class FrmConsultaEmployees
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstdireccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstnombrescustomer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlistar = new System.Windows.Forms.Button();
            this.lstcustomersdireccion = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstdireccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstnombrescustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnlistar);
            this.groupBox1.Controls.Add(this.lstcustomersdireccion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Nombre y ";
            // 
            // lstdireccion
            // 
            this.lstdireccion.AutoSize = true;
            this.lstdireccion.Location = new System.Drawing.Point(214, 24);
            this.lstdireccion.Name = "lstdireccion";
            this.lstdireccion.Size = new System.Drawing.Size(52, 13);
            this.lstdireccion.TabIndex = 5;
            this.lstdireccion.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Y Apellidos";
            // 
            // lstnombrescustomer
            // 
            this.lstnombrescustomer.Enabled = false;
            this.lstnombrescustomer.FormattingEnabled = true;
            this.lstnombrescustomer.Location = new System.Drawing.Point(6, 40);
            this.lstnombrescustomer.Name = "lstnombrescustomer";
            this.lstnombrescustomer.Size = new System.Drawing.Size(205, 238);
            this.lstnombrescustomer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(6, 284);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(422, 23);
            this.btnlistar.TabIndex = 1;
            this.btnlistar.Text = "Listar";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // lstcustomersdireccion
            // 
            this.lstcustomersdireccion.Enabled = false;
            this.lstcustomersdireccion.FormattingEnabled = true;
            this.lstcustomersdireccion.Location = new System.Drawing.Point(217, 40);
            this.lstcustomersdireccion.Name = "lstcustomersdireccion";
            this.lstcustomersdireccion.Size = new System.Drawing.Size(211, 238);
            this.lstcustomersdireccion.TabIndex = 0;
            // 
            // FrmConsultaEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 338);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaEmployees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstcustomersdireccion;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstnombrescustomer;
        private System.Windows.Forms.Label lstdireccion;
    }
}