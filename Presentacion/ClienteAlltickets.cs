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
    public partial class ClienteAlltickets : Form
    {
        NCliente nCliente=new NCliente();
        
        public ClienteAlltickets(String dniCliente)
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarClientes());
            tbDni.Texts=dniCliente;
        }

        private void MostrarClientes(List<Cliente> cliente)
        {
            dgvCliente.DataSource = new List<Cliente>();
            dgvCliente.DataSource = cliente;
            
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (tbDni.Texts==""||tbNombre.Texts==""||tbApellido.Texts==""||tbCorreo.Texts==""
            ||tbTelefono.Texts=="")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
           
            //obtenemos la edad
            int edad = 0;
            if (DateTime.Now.Month <= dtpCumpleaños.Value.Month)
            {
                if (DateTime.Now.Day < dtpCumpleaños.Value.Day) { edad = (DateTime.Now.Year - dtpCumpleaños.Value.Year) - 1; }
                else { edad = (DateTime.Now.Year - dtpCumpleaños.Value.Year); }
            }
            else { edad = DateTime.Now.Year - dtpCumpleaños.Value.Year; }

            //verificar si el mayor de edad
            if (edad >= 18)
            {
                Cliente cliente = new Cliente()
                {
                    Dni=tbDni.Texts,
                    Nombre=tbNombre.Texts,
                    Apellido=tbApellido.Texts,
                    Correo=tbCorreo.Texts,
                    Telefono=tbTelefono.Texts,
                    FechaNacimiento=dtpCumpleaños.Value
                };
                //verifica un Dni repetido
                String MensajeCliente = nCliente.Registrar(cliente);
                MessageBox.Show(MensajeCliente);
            }
            else { MessageBox.Show("Tu edad es de:" + " " + edad + "  " + "años, todavia eres menor de edad"); return; }
            MostrarClientes(nCliente.ListarClientes());
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
