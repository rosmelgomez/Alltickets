using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVendedor
    {
        DVendedor dVendedor=new DVendedor();
        public NVendedor() { }
        
        public bool Acceso(String Usuario,String Contraseña)
        {
            return dVendedor.Acceso(Usuario,Contraseña);
        }

        public bool VerificarJefe() { return dVendedor.VerificarJefe(); }

        public String Registrar(Vendedor vendedor)
        {
            if (dVendedor.Existe(vendedor.Dni))
            {
                return "existe Vendedor";
            }
            else
            {
                if (vendedor.Ocupacion != "Jefe")
                {
                    vendedor.IdJefe = DVendedor.vendedor.IdVendedor;
                }
                return dVendedor.Registrar(vendedor);
            }
        }

        public List<Vendedor> ListarVendedor() { return dVendedor.ListarVendedor(); }

        public List<object> ListarJefeMontoGeneradoSubordinado() {
        
            return dVendedor.ListarJefeMontoGeneradoSubordinado();
        }
    }
}
