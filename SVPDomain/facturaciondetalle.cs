//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVPDomain
{
    using System;
    using System.Collections.Generic;
    
    public partial class facturaciondetalle
    {
        public string v_FacturacionDetalleId { get; set; }
        public string v_FacturacionId { get; set; }
        public string v_ServicioId { get; set; }
        public Nullable<decimal> d_Monto { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        public virtual facturacion facturacion { get; set; }
    }
}
