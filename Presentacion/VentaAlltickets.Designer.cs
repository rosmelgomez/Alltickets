namespace Presentacion
{
    partial class VentaAlltickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaAlltickets));
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.btSalir = new ALLTICKETS.Diseño.ButtonDiseño();
            this.btAgregar = new ALLTICKETS.Diseño.ButtonDiseño();
            this.tbMetodoPago = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbDni = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAgregarPago = new ALLTICKETS.Diseño.ButtonDiseño();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(337, 51);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(512, 351);
            this.dgvVenta.TabIndex = 29;
            this.dgvVenta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvVenta_DataError);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.SteelBlue;
            this.btSalir.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btSalir.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btSalir.BorderRadius = 10;
            this.btSalir.BorderSize = 0;
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.White;
            this.btSalir.Location = new System.Drawing.Point(64, 304);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(225, 40);
            this.btSalir.TabIndex = 28;
            this.btSalir.Text = "SALIR";
            this.btSalir.TextColor = System.Drawing.Color.White;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgregar.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btAgregar.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btAgregar.BorderRadius = 10;
            this.btAgregar.BorderSize = 0;
            this.btAgregar.FlatAppearance.BorderSize = 0;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Location = new System.Drawing.Point(64, 184);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(225, 40);
            this.btAgregar.TabIndex = 27;
            this.btAgregar.Text = "ESCOGER ENTRADA";
            this.btAgregar.TextColor = System.Drawing.Color.White;
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbMetodoPago
            // 
            this.tbMetodoPago.BackColor = System.Drawing.SystemColors.Window;
            this.tbMetodoPago.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbMetodoPago.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbMetodoPago.BorderRadius = 10;
            this.tbMetodoPago.BorderSize = 2;
            this.tbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbMetodoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMetodoPago.Location = new System.Drawing.Point(130, 112);
            this.tbMetodoPago.Margin = new System.Windows.Forms.Padding(4);
            this.tbMetodoPago.Multiline = false;
            this.tbMetodoPago.Name = "tbMetodoPago";
            this.tbMetodoPago.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbMetodoPago.PasswordChar = false;
            this.tbMetodoPago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMetodoPago.PlaceholderText = "";
            this.tbMetodoPago.Size = new System.Drawing.Size(201, 31);
            this.tbMetodoPago.TabIndex = 22;
            this.tbMetodoPago.Texts = "";
            this.tbMetodoPago.UnderlinedStyle = false;
            // 
            // tbDni
            // 
            this.tbDni.BackColor = System.Drawing.SystemColors.Window;
            this.tbDni.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbDni.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbDni.BorderRadius = 10;
            this.tbDni.BorderSize = 2;
            this.tbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDni.Location = new System.Drawing.Point(131, 72);
            this.tbDni.Margin = new System.Windows.Forms.Padding(4);
            this.tbDni.Multiline = false;
            this.tbDni.Name = "tbDni";
            this.tbDni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbDni.PasswordChar = false;
            this.tbDni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDni.PlaceholderText = "";
            this.tbDni.Size = new System.Drawing.Size(201, 31);
            this.tbDni.TabIndex = 21;
            this.tbDni.Texts = "";
            this.tbDni.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Metodo Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dni Cliente:";
            // 
            // btAgregarPago
            // 
            this.btAgregarPago.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgregarPago.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btAgregarPago.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btAgregarPago.BorderRadius = 10;
            this.btAgregarPago.BorderSize = 0;
            this.btAgregarPago.FlatAppearance.BorderSize = 0;
            this.btAgregarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarPago.ForeColor = System.Drawing.Color.White;
            this.btAgregarPago.Location = new System.Drawing.Point(64, 242);
            this.btAgregarPago.Name = "btAgregarPago";
            this.btAgregarPago.Size = new System.Drawing.Size(225, 40);
            this.btAgregarPago.TabIndex = 30;
            this.btAgregarPago.Text = "AGREGAR PAGO";
            this.btAgregarPago.TextColor = System.Drawing.Color.White;
            this.btAgregarPago.UseVisualStyleBackColor = false;
            this.btAgregarPago.Click += new System.EventHandler(this.btAgregarPago_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Realizar una Venta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(759, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 49);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // VentaAlltickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAgregarPago);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tbMetodoPago);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentaAlltickets";
            this.Text = "VentaAlltickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenta;
        private ALLTICKETS.Diseño.ButtonDiseño btSalir;
        private ALLTICKETS.Diseño.ButtonDiseño btAgregar;
        private ALLTICKETS.Diseño.TextBoxDiseño tbMetodoPago;
        private ALLTICKETS.Diseño.TextBoxDiseño tbDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ALLTICKETS.Diseño.ButtonDiseño btAgregarPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}