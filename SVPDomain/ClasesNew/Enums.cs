using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVPDomain.ClasesNew
{
    public class Enums
    {
        public enum LogEventType
        {
            ACCESOSSISTEMA = 1,
            CREACION = 2,
            ACTUALIZACION = 3,
            ELIMINACION = 4,
            EXPORTACION = 5,
            GENERACIONREPORTE = 6,
            PROCESO = 7
        }

        public enum Success
        {
            Failed = 0,
            Ok = 1
        }
    }
}
