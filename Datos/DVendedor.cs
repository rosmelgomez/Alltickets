using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVendedor
    {
        public DVendedor() {}

        public static Vendedor vendedor;

        public bool Acceso(String Usuario, String Contraseña)
        {
            try
            {
                 vendedor = null;
                using (var context = new ALLTICKETSEntities())
                {
                    vendedor = context.Vendedor.Where(a => a.Usuario.Equals(Usuario)&& a.Contraseña.Equals(Contraseña)).FirstOrDefault() ;
                }
                if (vendedor != null) { return true; }
                else return false;
            }
            catch (Exception ex)
            {
                    return false;
            }
        }
        
        public bool Existe(String DniVendedor)
        {
            try
            {
                Vendedor vendedor = null;
                using (var context = new ALLTICKETSEntities())
                {
                    vendedor = context.Vendedor.FirstOrDefault(a => a.Dni.Equals(DniVendedor));
                    context.SaveChanges();
                }
                if (vendedor != null) { return true; }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool VerificarJefe()
        {
            if (vendedor.IdJefe==null){return true;}
            else{return false;}
        }

        public String Registrar(Vendedor vendedor)
        {

            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    context.Vendedor.Add(vendedor);
                    context.SaveChanges();
                    return "El nuevo trabajador fue registrado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<Vendedor> ListarVendedor()
        {
            List<Vendedor> vendedores = null;
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    vendedores = context.Vendedor.ToList();
                }
                return vendedores;
            }
            catch (Exception ex)
            {
                return vendedores;
            }

        }

        public List<object> ListarJefeMontoGeneradoSubordinado()
        {
            List<object> Lista = new List<object>();
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    var resultados = context.Vendedor
                       .Join(
                            context.Vendedor,
                            je => je.IdVendedor,
                            sb => sb.IdJefe,
                            (je, sb) => new
                            {
                                Jefe = je,
                                Subordinado= sb,
                            })
                       .Join(
                         context.Venta,
                         ve=>ve.Subordinado.IdVendedor,
                         ven => ven.IdVendedor,
                         (ve, ven) => new
                         {
                             Id =ve.Jefe.IdVendedor,
                             Nombre =ve.Jefe.Nombre,
                             Apellido =ve.Jefe.Apellido,
                             PrecioVenta=ven.PrecioTotal
                         })
                        .GroupBy(a =>new { a.Id,a.Nombre, a.Apellido})
                        .Select(b => new
                        {
                            Id = b.Key.Id,
                            Nombre = b.Key.Nombre,
                            Apellido=b.Key.Apellido,
                            Cantidad = b.Sum(x => x.PrecioVenta)
                        })
                        .ToList();
                    Lista = resultados.Cast<object>().ToList();
                    return Lista;
                }
            }
            catch (Exception ex)
            {
                return Lista;
            }


        }

    }
}
