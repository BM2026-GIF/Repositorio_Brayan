namespace ProyectoExamen1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.picVehiculo = new System.Windows.Forms.PictureBox();
            this.btnVerResumen = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "AutoRent HN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cliente ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI/Identidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de vehiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vehiculo Seleccionado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(260, 315);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(260, 351);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(248, 22);
            this.txtDni.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(260, 388);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(248, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Items.AddRange(new object[] {
            "Turismo",
            "SUV",
            "Pickup"});
            this.cmbVehiculo.Location = new System.Drawing.Point(260, 433);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(248, 24);
            this.cmbVehiculo.TabIndex = 9;
            // 
            // picVehiculo
            // 
            this.picVehiculo.Location = new System.Drawing.Point(571, 334);
            this.picVehiculo.Name = "picVehiculo";
            this.picVehiculo.Size = new System.Drawing.Size(146, 123);
            this.picVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVehiculo.TabIndex = 10;
            this.picVehiculo.TabStop = false;
            // 
            // btnVerResumen
            // 
            this.btnVerResumen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerResumen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerResumen.Location = new System.Drawing.Point(133, 524);
            this.btnVerResumen.Name = "btnVerResumen";
            this.btnVerResumen.Size = new System.Drawing.Size(186, 57);
            this.btnVerResumen.TabIndex = 11;
            this.btnVerResumen.Text = "IR AL SEGUNDO FORMULARIO";
            this.btnVerResumen.UseVisualStyleBackColor = false;
            this.btnVerResumen.Click += new System.EventHandler(this.btnVerResumen_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(404, 524);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(176, 57);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVerResumen);
            this.Controls.Add(this.picVehiculo);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "VENTANA PRINCIPAL";
            ((System.ComponentModel.ISupportInitialize)(this.picVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.PictureBox picVehiculo;
        private System.Windows.Forms.Button btnVerResumen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

