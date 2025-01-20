using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class NEntrada
    {
        DEntrada dEntrada=new DEntrada();
        public NEntrada() { }
        public String Registrar(Entrada entrada)
        {
            return dEntrada.Registrar(entrada);

        }
        public List<Entrada> ListarEntradas()
        {
            return dEntrada.ListarEntradas();
        }

        public List<object> ListarTotalEntradasVendidas()
        {
          return  dEntrada.ListarTotalEntradasVendidas();
        }
    }
}
