using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPago
    {
        public DPago() { }

        public bool VerificarExistencia()
        {
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    List <Pago> pagos = null;
                    pagos= context.Pago.ToList();
                    context.SaveChanges();
                    if (pagos != null) { return true; }
                    else { return false; }
                }
            }catch (Exception ex){return false;}
        }

        public String Registrar(Pago pago)
        {

            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    context.Pago.Add(pago);
                    context.SaveChanges();
                    return "Se registro correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<Pago> ListarPagos() {
            List<Pago> pagos = new List<Pago>();
            try
            {
                using (var context = new ALLTICKETSEntities())
                {
                    pagos=context.Pago.ToList();
                    return pagos;
                }
            }
            catch (Exception ex)
            {
                return pagos;
            }
        }

    }
}
