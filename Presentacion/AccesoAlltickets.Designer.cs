namespace Presentacion
{
    partial class AccesoAlltickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccesoAlltickets));
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.tbContraseña = new ALLTICKETS.Diseño.TextBoxDiseño();
            this.btnAcceso = new ALLTICKETS.Diseño.ButtonDiseño();
            this.btnSalir = new ALLTICKETS.Diseño.ButtonDiseño();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.tbUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.tbUsuario.BorderFocusColor = System.Drawing.Color.Black;
            this.tbUsuario.BorderRadius = 10;
            this.tbUsuario.BorderSize = 3;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.Location = new System.Drawing.Point(95, 342);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.Multiline = false;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbUsuario.PasswordChar = false;
            this.tbUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbUsuario.PlaceholderText = "";
            this.tbUsuario.Size = new System.Drawing.Size(250, 31);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.Texts = "";
            this.tbUsuario.UnderlinedStyle = false;
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.tbContraseña.BorderColor = System.Drawing.Color.Transparent;
            this.tbContraseña.BorderFocusColor = System.Drawing.Color.Black;
            this.tbContraseña.BorderRadius = 10;
            this.tbContraseña.BorderSize = 2;
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbContraseña.Location = new System.Drawing.Point(364, 342);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tbContraseña.Multiline = false;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbContraseña.PasswordChar = true;
            this.tbContraseña.PlaceholderColor = System.Drawing.Color.Black;
            this.tbContraseña.PlaceholderText = "";
            this.tbContraseña.Size = new System.Drawing.Size(250, 31);
            this.tbContraseña.TabIndex = 2;
            this.tbContraseña.Texts = "";
            this.tbContraseña.UnderlinedStyle = false;
            // 
            // btnAcceso
            // 
            this.btnAcceso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAcceso.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnAcceso.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAcceso.BorderRadius = 10;
            this.btnAcceso.BorderSize = 0;
            this.btnAcceso.FlatAppearance.BorderSize = 0;
            this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceso.ForeColor = System.Drawing.Color.Black;
            this.btnAcceso.Location = new System.Drawing.Point(177, 381);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(150, 40);
            this.btnAcceso.TabIndex = 3;
            this.btnAcceso.Text = "INGRESAR";
            this.btnAcceso.TextColor = System.Drawing.Color.Black;
            this.btnAcceso.UseVisualStyleBackColor = false;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 10;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(373, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextColor = System.Drawing.Color.Black;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AccesoAlltickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Name = "AccesoAlltickets";
            this.Text = "AccesoAlltickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ALLTICKETS.Diseño.TextBoxDiseño tbUsuario;
        private ALLTICKETS.Diseño.TextBoxDiseño tbContraseña;
        private ALLTICKETS.Diseño.ButtonDiseño btnAcceso;
        private ALLTICKETS.Diseño.ButtonDiseño btnSalir;
    }
}

