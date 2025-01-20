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
    public partial class InterfazAlltickets : Form
    {
        public InterfazAlltickets(bool ConfirmarJefe)
        {
            InitializeComponent();
            //activa el btRegistrarVendedor para agregar a otro vendedor
            //pero si no es jefe lo bloque y no podra registrar vendedor
            btRegistrarVendedor.Enabled= ConfirmarJefe;
        }
        private void btRegistrarCliente_Click(object sender, EventArgs e)
        {
         ClienteAlltickets clienteAlltickets = new ClienteAlltickets("");
            clienteAlltickets.Show();
        }
        private void btRegistrarEntrada_Click(object sender, EventArgs e)
        {
            EntradaAlltickets entradaAlltickets = new EntradaAlltickets();
            entradaAlltickets.Show();
        }

        private void btRegistraVenta_Click(object sender, EventArgs e)
        {
            VentaAlltickets ventaAlltickets= new VentaAlltickets();
            ventaAlltickets.Show();
        }

        private void bdReportes_Click(object sender, EventArgs e)
        {
            ReportesAlltickets reportesAlltickets=new ReportesAlltickets();
            reportesAlltickets.Show();
        }

        private void btRegistrarVendedor_Click(object sender, EventArgs e)
        {
            VendedorAltickets vendedorAltickets = new VendedorAltickets();
            vendedorAltickets.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
