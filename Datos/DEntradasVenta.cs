using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEntradasVenta
    {
        public DEntradasVenta() { }

        public String Registrar(EntradasVenta entradasVenta)
        {
            try
            {
                if (CantidadEntrada(entradasVenta) > 0&& evento(entradasVenta.IdEntrada).FechaEvento>DateTime.Now)
                {
                    if (entradasVenta.CantidadEntrada < CantidadEntrada(entradasVenta))
                    {
                        using (var context = new ALLTICKETSEntities())
                        {
                            context.EntradasVenta.Add(entradasVenta);
                            context.SaveChanges();
                        }
                        ModificarVenta(entradasVenta.IdVenta);
                        ModificarEntrada(entradasVenta);
                        return "Se registro Correctamente";
                    }
                    else { return "Solo hay: " + CantidadEntrada(entradasVenta).ToString(); }
                }
                else { return "no hay stock de la entrada"; }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public Entrada PrecioParcial(int idEntrada)
        {
            Entrada entrada = null;
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    entrada = context.Entrada.Find(idEntrada);
                    return entrada;
                }
            }
            catch (Exception ex)
            {
                return entrada;
            }

        }

        private void ModificarVenta(int IdVenta)
        {
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    Venta venta = context.Venta.Find(IdVenta);
                    if (venta != null)
                    {
                        //consigo la cantido total y modifico
                        int CanTotalEntrada = context.EntradasVenta.Where(e => e.IdVenta.Equals(IdVenta)).Sum(e => e.CantidadEntrada);
                        venta.CantidadTotalEntrada = CanTotalEntrada;
                        //consigo la suma total del precio y modifico
                        decimal PrecioTotal = context.EntradasVenta.Where(e => e.IdVenta.Equals(IdVenta)).Sum(e => e.PrecioParcial);
                        venta.PrecioTotal = PrecioTotal;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }


        }

        private int CantidadEntrada(EntradasVenta entradasVenta)
        {
            int aux = 0;
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    Entrada entrada = context.Entrada.Find(entradasVenta.IdEntrada);
                    if (entrada != null)
                    {
                        aux = entrada.Cantidad;
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                return aux;
            }

        }

        private Evento evento(int idEntrada) {
            Evento evento = new Evento();
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    Entrada entrada = context.Entrada.Find(idEntrada);
                    evento = context.Evento.Find(entrada.IdEvento);
                    context.SaveChanges();
                }
                return evento;
            }
            catch (Exception ex)
            {
                return evento;
            }
        }

        private void ModificarEntrada(EntradasVenta entradasVenta)
        {
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    Entrada entrada = context.Entrada.Find(entradasVenta.IdEntrada);
                    if (entrada != null)
                    {
                        entrada.Cantidad = entrada.Cantidad - entradasVenta.CantidadEntrada;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public List<EntradasVenta> ListarEntradasVentas(int idVenta)
        {
            List<EntradasVenta> entradasVentas = new List<EntradasVenta>();
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    entradasVentas = context.EntradasVenta.Where(a=>a.IdVenta.Equals(idVenta)).ToList();
                    return entradasVentas;
                }
            }
            catch (Exception ex)
            {
                return entradasVentas;
            }
        }

        
    }
}
