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
    
    public partial class Triaje
    {
        public string v_TriajeId { get; set; }
        public string v_ServicioId { get; set; }
        public Nullable<decimal> dec_Peso { get; set; }
        public Nullable<decimal> dec_Talla { get; set; }
        public Nullable<decimal> dec_IMC { get; set; }
        public Nullable<decimal> dec_IndiceCintura { get; set; }
        public Nullable<decimal> dec_Temperatura { get; set; }
        public Nullable<decimal> dec_PerimetroCadera { get; set; }
        public Nullable<decimal> dec_PerimetroAbdominal { get; set; }
        public Nullable<int> i_PresionSistolica { get; set; }
        public Nullable<int> i_PresionDiastolica { get; set; }
        public Nullable<int> i_FrecResp { get; set; }
        public Nullable<int> i_FrecCard { get; set; }
        public Nullable<int> dec_SaturacionOxigeno { get; set; }
        public string v_ConclusionesTriaje { get; set; }
        public Nullable<System.DateTime> d_FechaInsercion { get; set; }
        public Nullable<int> i_UsuarioInsertaId { get; set; }
        public Nullable<System.DateTime> d_FechaActualizacion { get; set; }
        public Nullable<int> i_UsuarioActualizaId { get; set; }
        public Nullable<bool> i_EsEliminado { get; set; }
    
        public virtual Servicio Servicio { get; set; }
    }
}
