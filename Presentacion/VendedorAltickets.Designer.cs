namespace Presentacion
{
    partial class VendedorAltickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendedorAltickets));
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOcupacion = new ALLTICKETS.Diseño.ComboBoxDiseño();
            this.tbContraseña = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.btSalir = new ALLTICKETS.Diseño.ButtonDiseño();
            this.btAgregar = new ALLTICKETS.Diseño.ButtonDiseño();
            this.tbUsuario = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbApellido = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbNombre = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbDni = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Location = new System.Drawing.Point(364, 47);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.Size = new System.Drawing.Size(482, 369);
            this.dgvVendedor.TabIndex = 29;
            this.dgvVendedor.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvVendedor_DataError);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ocupacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dni:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña:";
            // 
            // cbOcupacion
            // 
            this.cbOcupacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbOcupacion.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbOcupacion.BorderSize = 2;
            this.cbOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbOcupacion.ForeColor = System.Drawing.Color.DimGray;
            this.cbOcupacion.IconColor = System.Drawing.Color.SteelBlue;
            this.cbOcupacion.Items.AddRange(new object[] {
            "Jefe",
            "Subordinado"});
            this.cbOcupacion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbOcupacion.ListTextColor = System.Drawing.Color.DimGray;
            this.cbOcupacion.Location = new System.Drawing.Point(132, 178);
            this.cbOcupacion.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbOcupacion.Name = "cbOcupacion";
            this.cbOcupacion.Padding = new System.Windows.Forms.Padding(2);
            this.cbOcupacion.Size = new System.Drawing.Size(200, 30);
            this.cbOcupacion.TabIndex = 32;
            this.cbOcupacion.Texts = "Seleciona";
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.tbContraseña.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbContraseña.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbContraseña.BorderRadius = 10;
            this.tbContraseña.BorderSize = 2;
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbContraseña.Location = new System.Drawing.Point(132, 255);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tbContraseña.Multiline = false;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbContraseña.PasswordChar = false;
            this.tbContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbContraseña.PlaceholderText = "";
            this.tbContraseña.Size = new System.Drawing.Size(201, 31);
            this.tbContraseña.TabIndex = 31;
            this.tbContraseña.Texts = "";
            this.tbContraseña.UnderlinedStyle = false;
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
            this.btSalir.Location = new System.Drawing.Point(106, 365);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(150, 40);
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
            this.btAgregar.Location = new System.Drawing.Point(106, 305);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(150, 40);
            this.btAgregar.TabIndex = 27;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.TextColor = System.Drawing.Color.White;
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.tbUsuario.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbUsuario.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.tbUsuario.BorderRadius = 10;
            this.tbUsuario.BorderSize = 2;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.Location = new System.Drawing.Point(132, 216);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.Multiline = false;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbUsuario.PasswordChar = false;
            this.tbUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbUsuario.PlaceholderText = "";
            this.tbUsuario.Size = new System.Drawing.Size(201, 31);
            this.tbUsuario.TabIndex = 25;
            this.tbUsuario.Texts = "";
            this.tbUsuario.UnderlinedStyle = false;
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
            this.tbApellido.Location = new System.Drawing.Point(132, 132);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellido.Multiline = false;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbApellido.PasswordChar = false;
            this.tbApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbApellido.PlaceholderText = "";
            this.tbApellido.Size = new System.Drawing.Size(201, 31);
            this.tbApellido.TabIndex = 23;
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
            this.tbNombre.Location = new System.Drawing.Point(132, 88);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Multiline = false;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNombre.PasswordChar = false;
            this.tbNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNombre.PlaceholderText = "";
            this.tbNombre.Size = new System.Drawing.Size(201, 31);
            this.tbNombre.TabIndex = 22;
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
            this.tbDni.Location = new System.Drawing.Point(132, 47);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(766, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 49);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ingrese nuevo Empleado";
            // 
            // VendedorAltickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 444);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbOcupacion);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvVendedor);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VendedorAltickets";
            this.Text = "VendedorAltickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendedor;
        private ALLTICKETS.Diseño.ButtonDiseño btSalir;
        private ALLTICKETS.Diseño.ButtonDiseño btAgregar;
        private ALLTICKETS.Diseño.TextBoxDiseño tbUsuario;
        private ALLTICKETS.Diseño.TextBoxDiseño tbApellido;
        private ALLTICKETS.Diseño.TextBoxDiseño tbNombre;
        private ALLTICKETS.Diseño.TextBoxDiseño tbDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private ALLTICKETS.Diseño.TextBoxDiseño tbContraseña;
        private ALLTICKETS.Diseño.ComboBoxDiseño cbOcupacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}