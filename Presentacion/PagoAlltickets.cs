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
    public partial class PagoAlltickets : Form
    {
        NPago nPago = new NPago();
        public PagoAlltickets()
        {
            InitializeComponent();
            MostraPagos(nPago.ListarPagos());
        }
        private void MostraPagos(List<Pago> pagos)
        {
            dgvPago.DataSource = new List<Pago>();
            dgvPago.DataSource = pagos;
        }

        private void btAgregarPago_Click(object sender, EventArgs e)
        {
           bool Comprobarpago=cbPago.SelectedItem ==null;
           bool comprobarmoneda=cbMoneda.SelectedItem == null;
            if (Comprobarpago || comprobarmoneda)
            {
                MessageBox.Show("vuelva a intentarlo");
            }
            Pago pago=new Pago() { 
             MedioPago=cbPago.Texts,
             TipoMoneda=cbMoneda.Texts,
            };
            String Mensaje = nPago.Registrar(pago);
            MessageBox.Show(Mensaje);
            MostraPagos(nPago.ListarPagos());
        }

        private void dgvPago_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
