using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPago
    {
        DPago dPago = new DPago();
        public NPago() { }
        
        public bool VerificarExistencia() { return dPago.VerificarExistencia(); }
       
        public String Registrar(Pago pago)
        {
            return dPago.Registrar(pago);
        }

        public List<Pago> ListarPagos()
        {
           return dPago.ListarPagos();
        }

    }
}
