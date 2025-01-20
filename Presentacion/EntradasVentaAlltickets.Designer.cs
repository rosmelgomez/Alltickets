namespace Presentacion
{
    partial class EntradasVentaAlltickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradasVentaAlltickets));
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalir = new ALLTICKETS.Diseño.ButtonDiseño();
            this.btAgregar = new ALLTICKETS.Diseño.ButtonDiseño();
            this.tbCantEntrada = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbIdEntrada = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(348, 45);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(429, 268);
            this.dgvVenta.TabIndex = 37;
            this.dgvVenta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvVenta_DataError);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cantidad Entrada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id Entrada:";
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
            this.btSalir.Location = new System.Drawing.Point(82, 245);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(170, 40);
            this.btSalir.TabIndex = 36;
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
            this.btAgregar.Location = new System.Drawing.Point(63, 180);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(220, 40);
            this.btAgregar.TabIndex = 35;
            this.btAgregar.Text = "AGREGAR ENTRADA";
            this.btAgregar.TextColor = System.Drawing.Color.White;
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbCantEntrada
            // 
            this.tbCantEntrada.BackColor = System.Drawing.SystemColors.Window;
            this.tbCantEntrada.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbCantEntrada.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbCantEntrada.BorderRadius = 10;
            this.tbCantEntrada.BorderSize = 2;
            this.tbCantEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbCantEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCantEntrada.Location = new System.Drawing.Point(169, 107);
            this.tbCantEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantEntrada.Multiline = false;
            this.tbCantEntrada.Name = "tbCantEntrada";
            this.tbCantEntrada.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbCantEntrada.PasswordChar = false;
            this.tbCantEntrada.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbCantEntrada.PlaceholderText = "";
            this.tbCantEntrada.Size = new System.Drawing.Size(155, 31);
            this.tbCantEntrada.TabIndex = 34;
            this.tbCantEntrada.Texts = "";
            this.tbCantEntrada.UnderlinedStyle = false;
            // 
            // tbIdEntrada
            // 
            this.tbIdEntrada.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdEntrada.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbIdEntrada.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbIdEntrada.BorderRadius = 10;
            this.tbIdEntrada.BorderSize = 2;
            this.tbIdEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbIdEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIdEntrada.Location = new System.Drawing.Point(169, 68);
            this.tbIdEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.tbIdEntrada.Multiline = false;
            this.tbIdEntrada.Name = "tbIdEntrada";
            this.tbIdEntrada.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbIdEntrada.PasswordChar = false;
            this.tbIdEntrada.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbIdEntrada.PlaceholderText = "";
            this.tbIdEntrada.Size = new System.Drawing.Size(155, 31);
            this.tbIdEntrada.TabIndex = 33;
            this.tbIdEntrada.Texts = "";
            this.tbIdEntrada.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(708, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 49);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 26);
            this.label3.TabIndex = 44;
            this.label3.Text = "Escoja uno o mas Entradas";
            // 
            // EntradasVentaAlltickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tbCantEntrada);
            this.Controls.Add(this.tbIdEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EntradasVentaAlltickets";
            this.Text = "EntradasVentaAlltickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVenta;
        private ALLTICKETS.Diseño.ButtonDiseño btSalir;
        private ALLTICKETS.Diseño.ButtonDiseño btAgregar;
        private ALLTICKETS.Diseño.TextBoxDiseño tbCantEntrada;
        private ALLTICKETS.Diseño.TextBoxDiseño tbIdEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}