using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVenta
    {
        DVenta dVenta=new DVenta();
        public NVenta() { }
        public int ComprobarDni(String Dni)
        {
            return dVenta.ComprobarDni(Dni);
        }
        public int Registrar(String Dni,Venta venta)
        {
          venta.IdCliente = dVenta.ComprobarDni(Dni);
          venta.IdVendedor = DVendedor.vendedor.IdVendedor;
          return dVenta.Registrar(venta);
        }
        public List<Venta> ListarVentas()
        {
            return dVenta.ListarVentas();
        }

        
    }
}
