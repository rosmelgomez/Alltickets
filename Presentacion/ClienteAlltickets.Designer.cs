namespace Presentacion
{
    partial class ClienteAlltickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteAlltickets));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCumpleaños = new System.Windows.Forms.DateTimePicker();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btSalir = new ALLTICKETS.Diseño.ButtonDiseño();
            this.btAgregar = new ALLTICKETS.Diseño.ButtonDiseño();
            this.tbTelefono = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbCorreo = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbApellido = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbNombre = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbDni = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // dtpCumpleaños
            // 
            this.dtpCumpleaños.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCumpleaños.Location = new System.Drawing.Point(1, 290);
            this.dtpCumpleaños.Name = "dtpCumpleaños";
            this.dtpCumpleaños.Size = new System.Drawing.Size(315, 27);
            this.dtpCumpleaños.TabIndex = 11;
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(333, 48);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(537, 370);
            this.dgvCliente.TabIndex = 14;
            this.dgvCliente.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCliente_DataError);
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
            this.btSalir.Location = new System.Drawing.Point(91, 398);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(150, 40);
            this.btSalir.TabIndex = 13;
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
            this.btAgregar.Location = new System.Drawing.Point(91, 339);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(150, 40);
            this.btAgregar.TabIndex = 12;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.TextColor = System.Drawing.Color.White;
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.tbTelefono.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbTelefono.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbTelefono.BorderRadius = 10;
            this.tbTelefono.BorderSize = 2;
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTelefono.Location = new System.Drawing.Point(115, 217);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.Multiline = false;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbTelefono.PasswordChar = false;
            this.tbTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTelefono.PlaceholderText = "";
            this.tbTelefono.Size = new System.Drawing.Size(201, 31);
            this.tbTelefono.TabIndex = 10;
            this.tbTelefono.Texts = "";
            this.tbTelefono.UnderlinedStyle = false;
            // 
            // tbCorreo
            // 
            this.tbCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.tbCorreo.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbCorreo.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbCorreo.BorderRadius = 10;
            this.tbCorreo.BorderSize = 2;
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCorreo.Location = new System.Drawing.Point(115, 178);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCorreo.Multiline = false;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbCorreo.PasswordChar = false;
            this.tbCorreo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbCorreo.PlaceholderText = "";
            this.tbCorreo.Size = new System.Drawing.Size(201, 31);
            this.tbCorreo.TabIndex = 9;
            this.tbCorreo.Texts = "";
            this.tbCorreo.UnderlinedStyle = false;
            // 
            // tbApellido
            // 
            this.tbApellido.BackColor = System.Drawing.SystemColors.Window;
            this.tbApellido.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbApellido.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbApellido.BorderRadius = 10;
            this.tbApellido.BorderSize = 2;
            this.tbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbApellido.Location = new System.Drawing.Point(115, 133);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellido.Multiline = false;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbApellido.PasswordChar = false;
            this.tbApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbApellido.PlaceholderText = "";
            this.tbApellido.Size = new System.Drawing.Size(201, 31);
            this.tbApellido.TabIndex = 8;
            this.tbApellido.Texts = "";
            this.tbApellido.UnderlinedStyle = false;
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
            this.tbNombre.Location = new System.Drawing.Point(115, 89);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Multiline = false;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNombre.PasswordChar = false;
            this.tbNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNombre.PlaceholderText = "";
            this.tbNombre.Size = new System.Drawing.Size(201, 31);
            this.tbNombre.TabIndex = 7;
            this.tbNombre.Texts = "";
            this.tbNombre.UnderlinedStyle = false;
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
            this.tbDni.Location = new System.Drawing.Point(115, 48);
            this.tbDni.Margin = new System.Windows.Forms.Padding(4);
            this.tbDni.Multiline = false;
            this.tbDni.Name = "tbDni";
            this.tbDni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbDni.PasswordChar = false;
            this.tbDni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDni.PlaceholderText = "";
            this.tbDni.Size = new System.Drawing.Size(201, 31);
            this.tbDni.TabIndex = 6;
            this.tbDni.Texts = "";
            this.tbDni.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(787, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 49);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 26);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ingrese un nuevo Cliente";
            // 
            // ClienteAlltickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dtpCumpleaños);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClienteAlltickets";
            this.Text = "ClienteAlltickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
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
        private ALLTICKETS.Diseño.TextBoxDiseño tbDni;
        private ALLTICKETS.Diseño.TextBoxDiseño tbNombre;
        private ALLTICKETS.Diseño.TextBoxDiseño tbApellido;
        private ALLTICKETS.Diseño.TextBoxDiseño tbCorreo;
        private ALLTICKETS.Diseño.TextBoxDiseño tbTelefono;
        private System.Windows.Forms.DateTimePicker dtpCumpleaños;
        private ALLTICKETS.Diseño.ButtonDiseño btAgregar;
        private ALLTICKETS.Diseño.ButtonDiseño btSalir;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}