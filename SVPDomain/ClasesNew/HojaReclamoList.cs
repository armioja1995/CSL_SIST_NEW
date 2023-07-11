using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVPDomain.ClasesNew
{
    public class HojaReclamoList
    {
        public string v_IdHojaReclamo { get; set; }
        public int? i_CorrelativoReclamo { get; set; }
        public DateTime? d_fechaR { get; set; }
        public string v_IdPaciente { get; set; }
        public string Paciente { get; set; }
        public string DNI { get; set; }
        public bool? i_Producto { get; set; }
        public bool? i_Servicio { get; set; }
        public string Prod_Serv { get; set; }
        public string v_MontoReclamo { get; set; }
        public string v_Descripcion { get; set; }
        public bool? i_Queja { get; set; }
        public bool i_Reclamo { get; set; }
        public string Quej_Recl { get; set; }
        public string v_Pedido { get; set; }
        public byte[] b_FirmaConsumidor { get; set; }
        public DateTime? d_FechaComunicacionRespuesta { get; set; }

        public byte[] b_FirmaProveedor { get; set; }
        public int i_IsDeleted { get; set; }
        public int i_InsertUserId { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? d_InsertDate { get; set; }
        public string UsuarioEdita { get; set; }
        public DateTime? d_UpdateDate { get; set; }
        public string v_ComentaryRegistros { get; set; }
    }
}
