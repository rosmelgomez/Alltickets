using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Negocio
{
    public class NEntradasVenta
    {
        DEntradasVenta dEntradasVenta=new DEntradasVenta();
        public NEntradasVenta() { }

        public String Registrar(EntradasVenta entradaVenta)
        {
            
                Entrada entrada = dEntradasVenta.PrecioParcial(entradaVenta.IdEntrada);
                entradaVenta.PrecioParcial = entrada.Precio * entradaVenta.CantidadEntrada;

                return dEntradasVenta.Registrar(entradaVenta);
           
            
        }
        
        public List<EntradasVenta> ListarEntradasVentas(int idVenta) { return dEntradasVenta.ListarEntradasVentas(idVenta); }
        



    }
}
