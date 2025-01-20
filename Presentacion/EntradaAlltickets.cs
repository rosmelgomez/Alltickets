using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class EntradaAlltickets : Form
    {
        NEntrada nEntrada=new NEntrada();
        public EntradaAlltickets()
        {
            InitializeComponent();
            MostrarEntrada(nEntrada.ListarEntradas());
        }
        private void MostrarEntrada(List<Entrada> entradas) { 
            dgvEntrada.DataSource = new List<Entrada>();
            dgvEntrada.DataSource = entradas;
        }
        private void btAgregarEntrada_Click(object sender, EventArgs e)
        {
            if(tbIdEvento.Texts==""|| tbPrecio.Texts == "" || tbCantidad.Texts == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Entrada entrada = new Entrada() { 
            IdEvento=int.Parse(tbIdEvento.Texts),
            Precio= decimal.Parse(tbPrecio.Texts),
            Cantidad=int.Parse(tbCantidad.Texts)
            };

             string Mensaje= nEntrada.Registrar(entrada);
             MessageBox.Show(Mensaje);
             MostrarEntrada(nEntrada.ListarEntradas());
        }

        private void dgvEntrada_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void buttonAgregarEvento_Click(object sender, EventArgs e)
        {
            EventoAlltickets eventoAlltickets = new EventoAlltickets();
            eventoAlltickets.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
