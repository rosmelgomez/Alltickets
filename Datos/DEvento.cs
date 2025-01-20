using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEvento
    {
        public DEvento() { }

        public string Registrar(Evento evento)
        {

            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    context.Evento.Add(evento);
                    context.SaveChanges();
                    return "Evento registrado correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Evento> ListarEventos()
        {

            List<Evento> eventos = null;
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    eventos = context.Evento.ToList();
                }
                return eventos;
            }
            catch (Exception ex)
            {
                return eventos;
            }
        }
        
        public List<object> ListarEventosMontosGenerado()
        {
           List<object> Lista = new List<object>();
           try
           {
               using (var context = new ALLTICKETSEntities())
               {
                   var resultados = context.Evento
                       .Join(
                           context.Entrada,
                           ev => ev.IdEvento,
                           en => en.IdEvento,
                           (ev, en) => new { Evento = ev, Entrada = en })
                       .Join(
                           context.EntradasVenta,
                           enEv => enEv.Entrada.IdEntrada,
                           enV => enV.IdEntrada,
                           (enEv, enV) => new
                           {
                               Codigo = enEv.Evento.IdEvento,
                               Nombre = enEv.Evento.Nombre,
                               Lugar = enEv.Evento.LugarEvento,
                               FechaEvento = enEv.Evento.FechaEvento,
                               PrecioParcial = enV.PrecioParcial,
                           })
                       .Where(r => r.FechaEvento <DateTime.Now)
                       .GroupBy(r => new { r.Codigo, r.Nombre, r.Lugar,r.FechaEvento })
                       .Select(g => new
                       {
                           Codigo = g.Key.Codigo,
                           Nombre = g.Key.Nombre,
                           Lugar = g.Key.Lugar,
                           FechaEvento = g.Key.FechaEvento,
                           SumaTotal = g.Sum(x => x.PrecioParcial)
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
