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
    
    public partial class adultomayor
    {
        public string v_AdultoMayorId { get; set; }
        public string v_PersonId { get; set; }
        public string v_NombreCuidador { get; set; }
        public string v_EdadCuidador { get; set; }
        public string v_DniCuidador { get; set; }
        public string v_MedicamentoFrecuente { get; set; }
        public string v_InicioRS { get; set; }
        public string v_NroPs { get; set; }
        public string v_FechaUR { get; set; }
        public string v_RC { get; set; }
        public string v_Parto { get; set; }
        public string v_Prematuro { get; set; }
        public string v_Aborto { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ReaccionAlergica { get; set; }
        public string v_DescripciónAntecedentes { get; set; }
        public string v_FlujoVaginal { get; set; }
        public string v_ObservacionesEmbarazo { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        public virtual person person { get; set; }
    }
}
