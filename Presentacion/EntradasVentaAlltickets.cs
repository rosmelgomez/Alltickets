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
    public partial class EntradasVentaAlltickets : Form
    {
        NEntradasVenta nEntradasVenta=new NEntradasVenta();
        int IdVentaTemp;

        public EntradasVentaAlltickets(int idVenta)
        {
            InitializeComponent();
            IdVentaTemp = idVenta;
            MostraVentaEntrada(nEntradasVenta.ListarEntradasVentas(IdVentaTemp));
            btSalir.Enabled = false;
        }
        
        private void MostraVentaEntrada(List<EntradasVenta> entradasVentas)
        {
            dgvVenta.DataSource = new List<EntradasVenta>();
            dgvVenta.DataSource=entradasVentas;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (tbIdEntrada.Texts == "" || tbCantEntrada.Texts == "")
            {
                MessageBox.Show("");
                return;
            }
            EntradasVenta entradasVenta = new EntradasVenta() {
                IdVenta = IdVentaTemp,
                IdEntrada = int.Parse(tbIdEntrada.Texts),
                CantidadEntrada = int.Parse(tbCantEntrada.Texts),
                PrecioParcial = 0
            };
            String mensaje= nEntradasVenta.Registrar(entradasVenta);
            MessageBox.Show(mensaje);
            MostraVentaEntrada(nEntradasVenta.ListarEntradasVentas(IdVentaTemp));
            tbIdEntrada.Texts = ""; tbCantEntrada.Texts = "";
            btSalir.Enabled = true;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            VentaAlltickets ventaAlltickets = new VentaAlltickets();
            ventaAlltickets.Show();
            this.Close();
        }

        private void dgvVenta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
