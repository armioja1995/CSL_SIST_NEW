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
    
    public partial class ListadoHojaReclamoAll_SP_Result
    {
        public string v_IdHojaReclamo { get; set; }
        public Nullable<int> i_CorrelativoReclamo { get; set; }
        public Nullable<System.DateTime> d_fechaR { get; set; }
        public string v_IdPaciente { get; set; }
        public string Paciente { get; set; }
        public string DNI { get; set; }
        public Nullable<bool> i_Producto { get; set; }
        public Nullable<bool> i_Servicio { get; set; }
        public string Prod_Serv { get; set; }
        public string v_MontoReclamo { get; set; }
        public string v_Descripcion { get; set; }
        public string v_Pedido { get; set; }
        public byte[] b_FirmaConsumidor { get; set; }
        public Nullable<System.DateTime> d_FechaComunicacionRespuesta { get; set; }
        public byte[] b_FirmaProveedor { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public string UsuarioRegistro { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public string UsuarioEdita { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ComentaryRegistros { get; set; }
        public Nullable<bool> i_Queja { get; set; }
        public Nullable<bool> i_Reclamo { get; set; }
        public string Quej_Recl { get; set; }
    }
}
