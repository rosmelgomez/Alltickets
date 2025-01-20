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
    public partial class EventoAlltickets : Form
    {
        NEvento nEvento = new NEvento();  
        public EventoAlltickets()
        {
            InitializeComponent();
            MostarEventos(nEvento.ListarEventos());
        }

        private void MostarEventos(List<Evento> eventos)
        {
            dgvEvento.DataSource = new List<Evento>();
            dgvEvento.DataSource = eventos;

        }
        private void btAgregarEvento_Click(object sender, EventArgs e)
        {
            if (tbNombre.Texts==""||tbLugar.Texts=="") {
                MessageBox.Show("ingrese todos los campos");
                return;
            }
            if (dtpFecha.Value> DateTime.Now)
            {
                Evento evento = new Evento()
                {
                    Nombre = tbNombre.Texts,
                    LugarEvento = tbLugar.Texts,
                    FechaEvento=dtpFecha.Value,
                };
                String Mensaje = nEvento.Registrar(evento);
                MessageBox.Show(Mensaje);
            }
            else {
                MessageBox.Show("La fecha no puede ser anterior a la fecha actual");
                return; }
            MostarEventos(nEvento.ListarEventos());
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEvento_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
