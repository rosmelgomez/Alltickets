//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.EntradasVenta = new HashSet<EntradasVenta>();
        }
    
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int IdPago { get; set; }
        public int IdVendedor { get; set; }
        public decimal PrecioTotal { get; set; }
        public int CantidadTotalEntrada { get; set; }
        public System.DateTime FechaCompra { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntradasVenta> EntradasVenta { get; set; }
        public virtual Pago Pago { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}
