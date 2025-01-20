using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public DCliente() { }

        public bool Existe(String DniCliente) {
            try
            {
                Cliente cliente = null;
                using (var context = new ALLTICKETSEntities())
                {
                     cliente = context.Cliente.FirstOrDefault(a=>a.Dni.Equals(DniCliente));
                    context.SaveChanges();
                }
                if (cliente != null) { return true; }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        public String Registrar(Cliente cliente) {

            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                    return "El cliente fue registrado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<Cliente> ListarClientes() {

            List<Cliente> clientes = new List<Cliente>();
            List<Cliente> clientesAux = new List<Cliente>();
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    clientes = context.Cliente.ToList();
                 
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }

        }
    }
}
