using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entidades
{
    public class Ambiente
    {
        public Int32 IdAmbiente { get; set; }
        public String Nombre { get; set; }
        public String Ubicacion { get; set; }
        public string Foto { get; set; }
        public HttpPostedFileBase FotoFile { get; set; }
        public String Descripcion { get; set; }
    }
}
