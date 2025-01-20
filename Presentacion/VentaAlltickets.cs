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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class VentaAlltickets : Form
    {
        NVenta nVenta =new NVenta();
        NPago nPago = new NPago();
        public VentaAlltickets()
        {
            InitializeComponent();
            MostraVenta(nVenta.ListarVentas());
            
        }

        private void MostraVenta(List<Venta> ventas)
        {
            dgvVenta.DataSource = new List<Venta>();
            dgvVenta.DataSource = ventas;
        }
        
        private void btAgregar_Click(object sender, EventArgs e)
        {
           
            if (tbDni.Texts == "" || tbMetodoPago.Texts == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            if (nPago.VerificarExistencia() != true)
            {
                MessageBox.Show("Registrar al menos una Forma de pago");
                return;
            }
            if (nVenta.ComprobarDni(tbDni.Texts) > 0)
            {
                
                Venta venta = new Venta
                {
                    IdPago = int.Parse(tbMetodoPago.Texts),
                    PrecioTotal = 0,
                    CantidadTotalEntrada = 0,
                    FechaCompra = DateTime.Now
                };
                int ComprobarVenta = nVenta.Registrar(tbDni.Texts,venta);
                if (ComprobarVenta>0) {
                    EntradasVentaAlltickets entradasVentaAlltickets = new EntradasVentaAlltickets(ComprobarVenta);
                    entradasVentaAlltickets.Show();
                    this.Close();
                 } else { MessageBox.Show("Sucedio un error"); return; };
            }
            else
            {
                ClienteAlltickets clienteAlltickets = new ClienteAlltickets(tbDni.Texts);
                clienteAlltickets.Show();
            }
            tbDni.Texts = ""; tbMetodoPago.Texts = "";
            MostraVenta(nVenta.ListarVentas());
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVenta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btAgregarPago_Click(object sender, EventArgs e)
        {
            PagoAlltickets pagoAlltickets = new PagoAlltickets();
            pagoAlltickets.Show();
        }

     
    }
}
