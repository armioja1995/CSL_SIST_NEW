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
    
    public partial class history
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public history()
        {
            this.typeofeep = new HashSet<typeofeep>();
            this.workstationdangers = new HashSet<workstationdangers>();
        }
    
        public string v_HistoryId { get; set; }
        public string v_PersonId { get; set; }
        public Nullable<System.DateTime> d_StartDate { get; set; }
        public Nullable<System.DateTime> d_EndDate { get; set; }
        public string v_Organization { get; set; }
        public string v_TypeActivity { get; set; }
        public Nullable<int> i_GeografixcaHeight { get; set; }
        public string v_workstation { get; set; }
        public byte[] b_RubricImage { get; set; }
        public byte[] b_FingerPrintImage { get; set; }
        public string t_RubricImageText { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public Nullable<int> i_TypeOperationId { get; set; }
        public Nullable<int> i_TrabajoActual { get; set; }
        public string v_FechaUltimaMamo { get; set; }
        public string v_FechaUltimoPAP { get; set; }
        public string v_ResultadoMamo { get; set; }
        public string v_ResultadosPAP { get; set; }
        public Nullable<int> i_SoloAnio { get; set; }
        public string v_ActividadEmpresa { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<typeofeep> typeofeep { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workstationdangers> workstationdangers { get; set; }
        public virtual person person { get; set; }
    }
}