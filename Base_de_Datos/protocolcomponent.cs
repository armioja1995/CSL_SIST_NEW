//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base_de_Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class protocolcomponent
    {
        public string v_ProtocolComponentId { get; set; }
        public string v_ProtocolId { get; set; }
        public string v_ComponentId { get; set; }
        public Nullable<float> r_Price { get; set; }
        public Nullable<int> i_OperatorId { get; set; }
        public Nullable<int> i_Age { get; set; }
        public Nullable<int> i_GenderId { get; set; }
        public Nullable<int> i_GrupoEtarioId { get; set; }
        public Nullable<int> i_IsConditionalId { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public Nullable<int> i_IsConditionalIMC { get; set; }
        public Nullable<decimal> r_Imc { get; set; }
        public Nullable<int> i_IsAdditional { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        public virtual component component { get; set; }
        public virtual protocol protocol { get; set; }
    }
}