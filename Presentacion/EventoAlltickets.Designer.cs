namespace Presentacion
{
    partial class EventoAlltickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventoAlltickets));
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btSalir = new ALLTICKETS.Diseño.ButtonDiseño();
            this.btAgregarEvento = new ALLTICKETS.Diseño.ButtonDiseño();
            this.tbLugar = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbNombre = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvento
            // 
            this.dgvEvento.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Location = new System.Drawing.Point(329, 45);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.Size = new System.Drawing.Size(430, 251);
            this.dgvEvento.TabIndex = 39;
            this.dgvEvento.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEvento_DataError);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lugar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nombre:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFecha.Location = new System.Drawing.Point(110, 150);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(140, 22);
            this.dtpFecha.TabIndex = 40;
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
            this.btSalir.Location = new System.Drawing.Point(91, 267);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(150, 40);
            this.btSalir.TabIndex = 37;
            this.btSalir.Text = "SALIR";
            this.btSalir.TextColor = System.Drawing.Color.White;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAgregarEvento
            // 
            this.btAgregarEvento.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgregarEvento.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btAgregarEvento.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btAgregarEvento.BorderRadius = 10;
            this.btAgregarEvento.BorderSize = 0;
            this.btAgregarEvento.FlatAppearance.BorderSize = 0;
            this.btAgregarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarEvento.ForeColor = System.Drawing.Color.White;
            this.btAgregarEvento.Location = new System.Drawing.Point(74, 201);
            this.btAgregarEvento.Name = "btAgregarEvento";
            this.btAgregarEvento.Size = new System.Drawing.Size(211, 40);
            this.btAgregarEvento.TabIndex = 36;
            this.btAgregarEvento.Text = "AGREGAR EVENTO";
            this.btAgregarEvento.TextColor = System.Drawing.Color.White;
            this.btAgregarEvento.UseVisualStyleBackColor = false;
            this.btAgregarEvento.Click += new System.EventHandler(this.btAgregarEvento_Click);
            // 
            // tbLugar
            // 
            this.tbLugar.BackColor = System.Drawing.SystemColors.Window;
            this.tbLugar.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbLugar.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbLugar.BorderRadius = 10;
            this.tbLugar.BorderSize = 2;
            this.tbLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbLugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLugar.Location = new System.Drawing.Point(100, 97);
            this.tbLugar.Margin = new System.Windows.Forms.Padding(4);
            this.tbLugar.Multiline = false;
            this.tbLugar.Name = "tbLugar";
            this.tbLugar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbLugar.PasswordChar = false;
            this.tbLugar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLugar.PlaceholderText = "";
            this.tbLugar.Size = new System.Drawing.Size(201, 31);
            this.tbLugar.TabIndex = 34;
            this.tbLugar.Texts = "";
            this.tbLugar.UnderlinedStyle = false;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.tbNombre.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbNombre.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbNombre.BorderRadius = 10;
            this.tbNombre.BorderSize = 2;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNombre.Location = new System.Drawing.Point(100, 56);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Multiline = false;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNombre.PasswordChar = false;
            this.tbNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNombre.PlaceholderText = "";
            this.tbNombre.Size = new System.Drawing.Size(201, 31);
            this.tbNombre.TabIndex = 33;
            this.tbNombre.Texts = "";
            this.tbNombre.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(674, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 49);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ingrese un Nuevo Evento";
            // 
            // EventoAlltickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(783, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvEvento);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregarEvento);
            this.Controls.Add(this.tbLugar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "EventoAlltickets";
            this.Text = "EventoAlltickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvento;
        private ALLTICKETS.Diseño.ButtonDiseño btSalir;
        private ALLTICKETS.Diseño.ButtonDiseño btAgregarEvento;
        private ALLTICKETS.Diseño.TextBoxDiseño tbLugar;
        private ALLTICKETS.Diseño.TextBoxDiseño tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}