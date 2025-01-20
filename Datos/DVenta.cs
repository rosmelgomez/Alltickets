using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVenta
    {
        public DVenta() { }

        public int Registrar(Venta venta)
        {
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    context.Venta.Add(venta);
                    context.SaveChanges();
                    int IdVenta = venta.IdVenta;
                    return IdVenta;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int ComprobarDni( String Dni)
        {
            Cliente cliente = null;
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    cliente = context.Cliente.Where(a => a.Dni.Equals(Dni)).FirstOrDefault();
                    context.SaveChanges();
                }
                if(cliente != null) { return cliente.IdCliente; }else return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public List<Venta> ListarVentas()
        {
            List<Venta> ventas= new List<Venta>();
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                   ventas= context.Venta.ToList();  
                    return ventas;
                }
            }
            catch (Exception ex)
            {
                return ventas;
            }

        }
    }
}
