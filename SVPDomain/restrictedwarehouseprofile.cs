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
    
    public partial class restrictedwarehouseprofile
    {
        public int i_SystemUserId { get; set; }
        public string v_WarehouseId { get; set; }
        public int i_NodeId { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        public virtual warehouse warehouse { get; set; }
    }
}
