namespace labNetPractica1
{
    partial class FrmlabNetPractica1
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
            this.txtcantpasajeros = new System.Windows.Forms.TextBox();
            this.gpxtransporte = new System.Windows.Forms.GroupBox();
            this.btndetenerse = new System.Windows.Forms.Button();
            this.listtransportes = new System.Windows.Forms.ListBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnavanzar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTransporte = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpxtransporte.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Pasajeros";
            // 
            // txtcantpasajeros
            // 
            this.txtcantpasajeros.Location = new System.Drawing.Point(136, 58);
            this.txtcantpasajeros.Name = "txtcantpasajeros";
            this.txtcantpasajeros.Size = new System.Drawing.Size(297, 20);
            this.txtcantpasajeros.TabIndex = 1;
            this.txtcantpasajeros.TextChanged += new System.EventHandler(this.txtcantpasajeros_TextChanged);
            this.txtcantpasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantpasajerostaxi_KeyPress);
            // 
            // gpxtransporte
            // 
            this.gpxtransporte.Controls.Add(this.groupBox1);
            this.gpxtransporte.Controls.Add(this.listtransportes);
            this.gpxtransporte.Controls.Add(this.btnagregar);
            this.gpxtransporte.Controls.Add(this.label2);
            this.gpxtransporte.Controls.Add(this.cboTransporte);
            this.gpxtransporte.Controls.Add(this.label1);
            this.gpxtransporte.Controls.Add(this.txtcantpasajeros);
            this.gpxtransporte.Location = new System.Drawing.Point(12, 12);
            this.gpxtransporte.Name = "gpxtransporte";
            this.gpxtransporte.Size = new System.Drawing.Size(736, 298);
            this.gpxtransporte.TabIndex = 6;
            this.gpxtransporte.TabStop = false;
            this.gpxtransporte.Text = "Agregar Transporte";
            // 
            // btndetenerse
            // 
            this.btndetenerse.Location = new System.Drawing.Point(6, 48);
            this.btndetenerse.Name = "btndetenerse";
            this.btndetenerse.Size = new System.Drawing.Size(149, 23);
            this.btndetenerse.TabIndex = 18;
            this.btndetenerse.Text = "DETENERSE";
            this.btndetenerse.UseVisualStyleBackColor = true;
            this.btndetenerse.Click += new System.EventHandler(this.btndetenerse_Click);
            // 
            // listtransportes
            // 
            this.listtransportes.FormattingEnabled = true;
            this.listtransportes.Location = new System.Drawing.Point(10, 123);
            this.listtransportes.Name = "listtransportes";
            this.listtransportes.Size = new System.Drawing.Size(550, 160);
            this.listtransportes.TabIndex = 19;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(136, 84);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(297, 23);
            this.btnagregar.TabIndex = 18;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnavanzar
            // 
            this.btnavanzar.Location = new System.Drawing.Point(6, 19);
            this.btnavanzar.Name = "btnavanzar";
            this.btnavanzar.Size = new System.Drawing.Size(149, 23);
            this.btnavanzar.TabIndex = 17;
            this.btnavanzar.Text = "AVANZAR";
            this.btnavanzar.UseVisualStyleBackColor = true;
            this.btnavanzar.Click += new System.EventHandler(this.btnavanzar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Transporte";
            // 
            // cboTransporte
            // 
            this.cboTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransporte.FormattingEnabled = true;
            this.cboTransporte.Location = new System.Drawing.Point(136, 31);
            this.cboTransporte.Name = "cboTransporte";
            this.cboTransporte.Size = new System.Drawing.Size(297, 21);
            this.cboTransporte.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnavanzar);
            this.groupBox1.Controls.Add(this.btndetenerse);
            this.groupBox1.Location = new System.Drawing.Point(566, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 78);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Transporte";
            // 
            // FrmlabNetPractica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 322);
            this.Controls.Add(this.gpxtransporte);
            this.Name = "FrmlabNetPractica1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gpxtransporte.ResumeLayout(false);
            this.gpxtransporte.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantpasajeros;
        private System.Windows.Forms.GroupBox gpxtransporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTransporte;
        private System.Windows.Forms.Button btnavanzar;
        private System.Windows.Forms.Button btndetenerse;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListBox listtransportes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

