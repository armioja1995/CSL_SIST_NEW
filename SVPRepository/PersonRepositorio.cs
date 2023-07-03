using Interfaces;
using SVPDomain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVPRepository
{
    public class PersonRepositorio : PersonInterface
    {
        SigesoftDesarrollo_2Entities entidad;

        public PersonRepositorio(SigesoftDesarrollo_2Entities _entidad)
        {
            this.entidad = _entidad;
        }

        public void AddPerson(person trabajador)
        {
            entidad.person.Add(trabajador);
            entidad.SaveChanges();
        }

        public IEnumerable<person> AllPerson()
        {
            //var result = from p in entidad.person.Include("Cargo") select p;
            var result = from p in entidad.person select p;
            return result.ToList();
        }

        public List<person> AllPersons()
        {
            var query = from a in entidad.person select a;
            return query.ToList();
        }

        public List<person> ByQueryAll(string query, int activo)
        {
            var dbQuery = (from p in entidad.person select p);
            if (!String.IsNullOrEmpty(query))
                dbQuery = dbQuery.Where(o => o.v_FirstName.Contains(query) || o.v_FirstLastName.Contains(query) || o.v_SecondLastName.Contains(query) || o.v_DocNumber.Contains(query));

            if (activo != null)
                dbQuery = dbQuery.Where(o => o.i_IsDeleted == activo);

            return dbQuery.ToList();
        }

        public void DeletePerson(string v_IdPerson)
        {
            var existe = entidad.person.Find(v_IdPerson);
            if (existe != null)
            {
                entidad.person.Remove(existe);
                entidad.SaveChanges();
            }
        }

        public int DniIgual(string dni, string v_IdPerson)
        {
            return (from p in entidad.person where p.v_DocNumber == dni && p.v_PersonId != v_IdPerson select p).Count();
        }

        public person FindPerson(string v_IdPerson)
        {
            var result = from p in entidad.person where p.v_PersonId == v_IdPerson select p;
            return result.FirstOrDefault();
        }

        public person FindPersonByDni(string dni)
        {
            var query = from p in entidad.person
                        where p.v_DocNumber == dni && p.i_IsDeleted == 0
                        select p;
            return query.SingleOrDefault();
        }

        public void UpdatePerson(person person)
        {
            entidad.Entry(person).State = EntityState.Modified;

            entidad.SaveChanges();
        }
    }
}
