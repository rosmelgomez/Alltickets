using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEntrada
    {
        public DEntrada() { }
        public String Registrar(Entrada entrada)
        {

            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    context.Entrada.Add(entrada);
                    context.SaveChanges();
                    return "se registro correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public List<Entrada> ListarEntradas() {
             List<Entrada>entradas = null;
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    entradas= context.Entrada.ToList();
                    return entradas;
                }
            }
            catch (Exception ex)
            {
                return entradas;
            }
         }
        public List<object>  ListarTotalEntradasVendidas()
        {
            List<object> Lista  = new List<object>();
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    var resultados = context.Entrada
                       .Join(
                            context.EntradasVenta,
                            en => en.IdEntrada,
                            ev => ev.IdEntrada,
                            (en, ev) => new
                            {
                                IdEntrada = en.IdEntrada,
                                CantidadEntrada = ev.CantidadEntrada
                            })
                        .GroupBy(a => a.IdEntrada)
                        .Select(b => new
                        {
                            IdEntrada = b.Key,
                            Cantidad = b.Sum(x => x.CantidadEntrada)
                        }).ToList();
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
