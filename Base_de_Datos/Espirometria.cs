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
    
    public partial class Espirometria
    {
        public string v_EspirometriaId { get; set; }
        public string v_ServicioId { get; set; }
        public string v_FVC { get; set; }
        public string v_VEF1 { get; set; }
        public string v_VEFCVF { get; set; }
        public string v_ConclusionesEspirometria { get; set; }
        public Nullable<System.DateTime> d_FechaInsercion { get; set; }
        public Nullable<int> i_UsuarioInsertaId { get; set; }
        public Nullable<System.DateTime> d_FechaActualizacion { get; set; }
        public Nullable<int> i_UsuarioActualizaId { get; set; }
        public Nullable<bool> i_EsEliminado { get; set; }
    
        public virtual Servicio Servicio { get; set; }
    }
}
