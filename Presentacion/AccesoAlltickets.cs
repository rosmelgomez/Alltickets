using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class AccesoAlltickets : Form
    {
        NVendedor vendedor=new NVendedor();
        public AccesoAlltickets()
        {
            InitializeComponent();
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Texts == "" || tbContraseña.Texts == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            bool ComprobarAcceso = vendedor.Acceso(tbUsuario.Texts, tbContraseña.Texts);
            if (ComprobarAcceso)
            {
                MessageBox.Show("Acceso correcto");
                tbUsuario.Texts = ""; tbContraseña.Texts = "";
                InterfazAlltickets interfazAlltickets= new InterfazAlltickets(vendedor.VerificarJefe());
                interfazAlltickets.Show();
            }
            else {
                MessageBox.Show("Acceso denegado, comprueba tus datos");
                tbUsuario.Texts = ""; tbContraseña.Texts = "";
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
