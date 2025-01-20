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
    public partial class ReportesAlltickets : Form
    {
        NEntrada nEntrada=new NEntrada();
        NEvento nEvento = new NEvento();
        NVendedor nVendedor = new NVendedor();
        public ReportesAlltickets()
        {
            InitializeComponent();
        }

        private void MostrarReporte(List<object> ListaReporte)
        {
            dgvReporte.DataSource= ListaReporte;
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            MostrarReporte(nEntrada.ListarTotalEntradasVendidas());
        }

        private void btReporte2_Click(object sender, EventArgs e)
        {
            MostrarReporte(nEvento.ListarEventosMontoGenerado());
        }

        private void btReporte3_Click(object sender, EventArgs e)
        {
            MostrarReporte(nVendedor.ListarJefeMontoGeneradoSubordinado());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    

}
