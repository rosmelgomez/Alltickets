using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class NCliente
    {
        DCliente dCliente=new DCliente();
        public NCliente() { }
        
        public String Registrar(Cliente cliente)
        {
            if (dCliente.Existe(cliente.Dni))
            {
                return "Existe cliente, registra otro";
            }else
            {
                return dCliente.Registrar(cliente);
            }
        }

        public List<Cliente> ListarClientes()
        {
            return dCliente.ListarClientes();
        }

    }
}
