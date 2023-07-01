using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entidades
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string ApePat { get; set; }
        public string ApeMat { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNac { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Boolean Estado { get; set; }
        public string Foto { get; set; }
        public String CódQR { get; set; }

        public String Nombres_Mama { get; set; }
        public String Apellidos_Mama { get; set; }
        public String DNI_Mama { get; set; }

        public String Nombres_Papa { get; set; }
        public String Apellidos_Papa { get; set; }
        public String DNI_Papa { get; set; }


        public HttpPostedFileBase FotoFile { get; set; }
        //Nombre Completo
        public string NombreCompleto
        {
            get
            {
                return ApePat + " " + ApeMat + ", " + Nombres;
            }
        }

        public string NombreCompletoMama
        {
            get
            {
                return Apellidos_Mama + " " + ", " + Nombres_Mama;
            }
        }
        public string NombreCompletoPapa
        {
            get
            {
                return Apellidos_Papa + " " + ", " + Nombres_Papa;
            }
        }

        //FK
        public Grado Grado { get; set; }
        public Int32 IdGrado { get; set; }

        public Seccion Seccion { get; set; }
        public Int32 IdSeccion { get; set; }

        //colección para guardar asistencia
        public ICollection<AsistenciaAl> AsistenciaAl { get; set; }

        public Alumno()
        {
            this.AsistenciaAl = new HashSet<AsistenciaAl>();
        }
    }
}
