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
    
    public partial class DigitalContactCenter
    {
        public string v_DigitalContactCenterId { get; set; }
        public string v_PersonId { get; set; }
        public Nullable<int> i_MedioMkt { get; set; }
        public Nullable<System.DateTime> d_FechaCita { get; set; }
        public string v_ProtocolId { get; set; }
        public string v_MotivoConsulta { get; set; }
        public Nullable<int> i_MetodoPago { get; set; }
        public Nullable<int> i_EstadoAtencion { get; set; }
        public string v_ServiceId { get; set; }
        public string v_MotivoEliminación { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public byte[] b_ComprobanteDep { get; set; }
        public string v_DCCIdReAgenda { get; set; }
        public string v_Comentarios { get; set; }
    
        public virtual DigitalContactCenter DigitalContactCenter1 { get; set; }
        public virtual DigitalContactCenter DigitalContactCenter2 { get; set; }
        public virtual person person { get; set; }
        public virtual service service { get; set; }
    }
}
