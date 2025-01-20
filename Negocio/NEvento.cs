using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEvento
    {
        DEvento DEvento=new DEvento();
        public NEvento() { }
        public string Registrar(Evento evento)
        {
            return DEvento.Registrar(evento);
        }

        public List<Evento> ListarEventos()
        {
            return DEvento.ListarEventos();
        }
        public List<object> ListarEventosMontoGenerado()
        {
            return DEvento.ListarEventosMontosGenerado();
        }
    }
}
