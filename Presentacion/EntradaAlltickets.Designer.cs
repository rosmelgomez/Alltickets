namespace Presentacion
{
    partial class EntradaAlltickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaAlltickets));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.buttonAgregarEvento = new ALLTICKETS.Diseño.ButtonDiseño();
            this.btSalir = new ALLTICKETS.Diseño.ButtonDiseño();
            this.btAgregarEntrada = new ALLTICKETS.Diseño.ButtonDiseño();
            this.tbCantidad = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbPrecio = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbIdEvento = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "IdEvento:";
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Location = new System.Drawing.Point(346, 54);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.Size = new System.Drawing.Size(430, 314);
            this.dgvEntrada.TabIndex = 29;
            this.dgvEntrada.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEntrada_DataError);
            // 
            // buttonAgregarEvento
            // 
            this.buttonAgregarEvento.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAgregarEvento.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.buttonAgregarEvento.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAgregarEvento.BorderRadius = 10;
            this.buttonAgregarEvento.BorderSize = 0;
            this.buttonAgregarEvento.FlatAppearance.BorderSize = 0;
            this.buttonAgregarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarEvento.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarEvento.Location = new System.Drawing.Point(88, 252);
            this.buttonAgregarEvento.Name = "buttonAgregarEvento";
            this.buttonAgregarEvento.Size = new System.Drawing.Size(211, 40);
            this.buttonAgregarEvento.TabIndex = 28;
            this.buttonAgregarEvento.Text = "AGREGAR EVENTO";
            this.buttonAgregarEvento.TextColor = System.Drawing.Color.White;
            this.buttonAgregarEvento.UseVisualStyleBackColor = false;
            this.buttonAgregarEvento.Click += new System.EventHandler(this.buttonAgregarEvento_Click);
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
            this.btSalir.Location = new System.Drawing.Point(88, 316);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(211, 40);
            this.btSalir.TabIndex = 27;
            this.btSalir.Text = "SALIR";
            this.btSalir.TextColor = System.Drawing.Color.White;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAgregarEntrada
            // 
            this.btAgregarEntrada.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgregarEntrada.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btAgregarEntrada.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btAgregarEntrada.BorderRadius = 10;
            this.btAgregarEntrada.BorderSize = 0;
            this.btAgregarEntrada.FlatAppearance.BorderSize = 0;
            this.btAgregarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarEntrada.ForeColor = System.Drawing.Color.White;
            this.btAgregarEntrada.Location = new System.Drawing.Point(88, 196);
            this.btAgregarEntrada.Name = "btAgregarEntrada";
            this.btAgregarEntrada.Size = new System.Drawing.Size(211, 40);
            this.btAgregarEntrada.TabIndex = 26;
            this.btAgregarEntrada.Text = "AGREGAR ENTRADA";
            this.btAgregarEntrada.TextColor = System.Drawing.Color.White;
            this.btAgregarEntrada.UseVisualStyleBackColor = false;
            this.btAgregarEntrada.Click += new System.EventHandler(this.btAgregarEntrada_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.tbCantidad.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbCantidad.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbCantidad.BorderRadius = 10;
            this.tbCantidad.BorderSize = 2;
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCantidad.Location = new System.Drawing.Point(114, 142);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantidad.Multiline = false;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbCantidad.PasswordChar = false;
            this.tbCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbCantidad.PlaceholderText = "";
            this.tbCantidad.Size = new System.Drawing.Size(201, 31);
            this.tbCantidad.TabIndex = 22;
            this.tbCantidad.Texts = "";
            this.tbCantidad.UnderlinedStyle = false;
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.tbPrecio.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbPrecio.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbPrecio.BorderRadius = 10;
            this.tbPrecio.BorderSize = 2;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPrecio.Location = new System.Drawing.Point(114, 98);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrecio.Multiline = false;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPrecio.PasswordChar = false;
            this.tbPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPrecio.PlaceholderText = "";
            this.tbPrecio.Size = new System.Drawing.Size(201, 31);
            this.tbPrecio.TabIndex = 21;
            this.tbPrecio.Texts = "";
            this.tbPrecio.UnderlinedStyle = false;
            // 
            // tbIdEvento
            // 
            this.tbIdEvento.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdEvento.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbIdEvento.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbIdEvento.BorderRadius = 10;
            this.tbIdEvento.BorderSize = 2;
            this.tbIdEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbIdEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIdEvento.Location = new System.Drawing.Point(114, 57);
            this.tbIdEvento.Margin = new System.Windows.Forms.Padding(4);
            this.tbIdEvento.Multiline = false;
            this.tbIdEvento.Name = "tbIdEvento";
            this.tbIdEvento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbIdEvento.PasswordChar = false;
            this.tbIdEvento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbIdEvento.PlaceholderText = "";
            this.tbIdEvento.Size = new System.Drawing.Size(201, 31);
            this.tbIdEvento.TabIndex = 20;
            this.tbIdEvento.Texts = "";
            this.tbIdEvento.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(702, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 49);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ingrese una Nueva Entrada";
            // 
            // EntradaAlltickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEntrada);
            this.Controls.Add(this.buttonAgregarEvento);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregarEntrada);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbIdEvento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "EntradaAlltickets";
            this.Text = "EntradaAlltickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ALLTICKETS.Diseño.ButtonDiseño btSalir;
        private ALLTICKETS.Diseño.ButtonDiseño btAgregarEntrada;
        private ALLTICKETS.Diseño.TextBoxDiseño tbCantidad;
        private ALLTICKETS.Diseño.TextBoxDiseño tbPrecio;
        private ALLTICKETS.Diseño.TextBoxDiseño tbIdEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private ALLTICKETS.Diseño.ButtonDiseño buttonAgregarEvento;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}