namespace Presentacion
{
    partial class PagoAlltickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoAlltickets));
            this.btAgregarPago = new ALLTICKETS.Diseño.ButtonDiseño();
            this.dgvPago = new System.Windows.Forms.DataGridView();
            this.btSalir = new ALLTICKETS.Diseño.ButtonDiseño();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPago = new ALLTICKETS.Diseño.ComboBoxDiseño();
            this.cbMoneda = new ALLTICKETS.Diseño.ComboBoxDiseño();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btAgregarPago.Location = new System.Drawing.Point(116, 147);
            this.btAgregarPago.Name = "btAgregarPago";
            this.btAgregarPago.Size = new System.Drawing.Size(170, 40);
            this.btAgregarPago.TabIndex = 38;
            this.btAgregarPago.Text = "AGREGAR PAGO";
            this.btAgregarPago.TextColor = System.Drawing.Color.White;
            this.btAgregarPago.UseVisualStyleBackColor = false;
            this.btAgregarPago.Click += new System.EventHandler(this.btAgregarPago_Click);
            // 
            // dgvPago
            // 
            this.dgvPago.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPago.Location = new System.Drawing.Point(350, 41);
            this.dgvPago.Name = "dgvPago";
            this.dgvPago.Size = new System.Drawing.Size(438, 207);
            this.dgvPago.TabIndex = 37;
            this.dgvPago.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPago_DataError);
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
            this.btSalir.Location = new System.Drawing.Point(116, 210);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(170, 40);
            this.btSalir.TabIndex = 36;
            this.btSalir.Text = "SALIR";
            this.btSalir.TextColor = System.Drawing.Color.White;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tipo Moneda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Metodo Pago";
            // 
            // cbPago
            // 
            this.cbPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPago.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbPago.BorderSize = 2;
            this.cbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPago.ForeColor = System.Drawing.Color.DimGray;
            this.cbPago.IconColor = System.Drawing.Color.SteelBlue;
            this.cbPago.Items.AddRange(new object[] {
            "Tarjeta Debito",
            "Tarjeta Credito",
            "Yape",
            "Plin"});
            this.cbPago.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPago.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPago.Location = new System.Drawing.Point(142, 57);
            this.cbPago.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPago.Name = "cbPago";
            this.cbPago.Padding = new System.Windows.Forms.Padding(2);
            this.cbPago.Size = new System.Drawing.Size(200, 30);
            this.cbPago.TabIndex = 39;
            this.cbPago.Texts = "Selecione Pago";
            // 
            // cbMoneda
            // 
            this.cbMoneda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMoneda.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbMoneda.BorderSize = 2;
            this.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMoneda.ForeColor = System.Drawing.Color.DimGray;
            this.cbMoneda.IconColor = System.Drawing.Color.SteelBlue;
            this.cbMoneda.Items.AddRange(new object[] {
            "Soles",
            "Dolares"});
            this.cbMoneda.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMoneda.ListTextColor = System.Drawing.Color.DimGray;
            this.cbMoneda.Location = new System.Drawing.Point(143, 101);
            this.cbMoneda.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Padding = new System.Windows.Forms.Padding(2);
            this.cbMoneda.Size = new System.Drawing.Size(200, 30);
            this.cbMoneda.TabIndex = 40;
            this.cbMoneda.Texts = "Selecione Moneda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(701, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 49);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ingrese una Nueva Foma de Pago";
            // 
            // PagoAlltickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.cbPago);
            this.Controls.Add(this.btAgregarPago);
            this.Controls.Add(this.dgvPago);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PagoAlltickets";
            this.Text = "PagoAlltickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ALLTICKETS.Diseño.ButtonDiseño btAgregarPago;
        private System.Windows.Forms.DataGridView dgvPago;
        private ALLTICKETS.Diseño.ButtonDiseño btSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ALLTICKETS.Diseño.ComboBoxDiseño cbPago;
        private ALLTICKETS.Diseño.ComboBoxDiseño cbMoneda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}