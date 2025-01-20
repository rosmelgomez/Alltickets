using Datos;
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
    public partial class VendedorAltickets : Form
    {
        NVendedor nVendedor =new NVendedor();
        public VendedorAltickets()
        {
            InitializeComponent();
            MostrarVendedor(nVendedor.ListarVendedor());
        }
        private void MostrarVendedor(List<Vendedor>vendedores) {
            dgvVendedor.DataSource = new List<Vendedor>();
            dgvVendedor.DataSource = vendedores;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            bool Comprobar = cbOcupacion.SelectedItem == null;
            if (tbDni.Texts == "" || tbNombre.Texts == "" || tbApellido.Texts == "" || tbUsuario.Texts == ""
            || tbContraseña.Texts == "" || Comprobar)
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            //
            Vendedor vendedor = new Vendedor() { 
              Dni= tbDni.Texts,
              Nombre= tbNombre.Texts,
              Apellido= tbApellido.Texts,
              Ocupacion=cbOcupacion.Texts,
              Usuario= tbUsuario.Texts,
              Contraseña= tbContraseña.Texts,
            };
            String Mensaje = nVendedor.Registrar(vendedor);
            MessageBox.Show(Mensaje);
            MostrarVendedor(nVendedor.ListarVendedor());
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVendedor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
