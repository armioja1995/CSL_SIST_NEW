using SVPDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface PersonInterface
    {
        IEnumerable<person> AllPerson();

        List<person> ByQueryAll(string query, int activo);

        void AddPerson(person trabajador);

        person FindPerson(string v_IdPerson);

        person FindPersonByDni(string dni);

        void UpdatePerson(person person);

        void DeletePerson(string v_IdPerson);

        int DniIgual(string dni, string v_IdPerson);

        List<person> AllPersons();
    }
}
