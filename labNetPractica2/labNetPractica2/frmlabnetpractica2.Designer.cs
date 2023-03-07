namespace labNetPractica2
{
    partial class frmlabnetpractica2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnvalor = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnopera3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnopera4 = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIVIDENDO";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(76, 19);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(152, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(76, 42);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(152, 20);
            this.txtnum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DIVISOR";
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(76, 70);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(152, 23);
            this.btndividir.TabIndex = 4;
            this.btndividir.Text = "DIVIDIR";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnvalor
            // 
            this.btnvalor.Location = new System.Drawing.Point(82, 53);
            this.btnvalor.Name = "btnvalor";
            this.btnvalor.Size = new System.Drawing.Size(152, 23);
            this.btnvalor.TabIndex = 5;
            this.btnvalor.Text = "INGRESAR";
            this.btnvalor.UseVisualStyleBackColor = true;
            this.btnvalor.Click += new System.EventHandler(this.btnvalor_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(82, 27);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(152, 20);
            this.txtvalor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnum1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnum2);
            this.groupBox1.Controls.Add(this.btndividir);
            this.groupBox1.Location = new System.Drawing.Point(279, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PUNTO 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtvalor);
            this.groupBox2.Controls.Add(this.btnvalor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 106);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PUNTO 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnopera3);
            this.groupBox3.Location = new System.Drawing.Point(12, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 87);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PUNTO 3";
            // 
            // btnopera3
            // 
            this.btnopera3.Location = new System.Drawing.Point(82, 19);
            this.btnopera3.Name = "btnopera3";
            this.btnopera3.Size = new System.Drawing.Size(152, 23);
            this.btnopera3.TabIndex = 0;
            this.btnopera3.Text = "OPERACION";
            this.btnopera3.UseVisualStyleBackColor = true;
            this.btnopera3.Click += new System.EventHandler(this.btnopera3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtnombre);
            this.groupBox4.Controls.Add(this.btnopera4);
            this.groupBox4.Location = new System.Drawing.Point(279, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 87);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PUNTO 4";
            // 
            // btnopera4
            // 
            this.btnopera4.Location = new System.Drawing.Point(76, 38);
            this.btnopera4.Name = "btnopera4";
            this.btnopera4.Size = new System.Drawing.Size(152, 23);
            this.btnopera4.TabIndex = 1;
            this.btnopera4.Text = "OPERACION";
            this.btnopera4.UseVisualStyleBackColor = true;
            this.btnopera4.Click += new System.EventHandler(this.btnopera4_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(76, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(152, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Solo se admite nombre sin numeros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "NOMBRE";
            // 
            // frmlabnetpractica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 242);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmlabnetpractica2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnopera3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnopera4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
    }
}

