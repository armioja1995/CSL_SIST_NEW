using Interfaces;
using Microsoft.Win32;
using SVPDomain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SVPDomain.ClasesNew.Enums;

namespace SVPRepository
{
    public class HojaReclamoRepositorio : HojaReclamoInterface
    {
        SigesoftDesarrollo_2Entities entidad;

        public HojaReclamoRepositorio(SigesoftDesarrollo_2Entities _entidades)
        {
            this.entidad = _entidades;
        }

        public void AddHojaReclamo(HojaReclamo _hojaReclamo)
        {
            string NewId0 = null;
            try
            {
                _hojaReclamo.d_InsertDate = DateTime.Now;
                //_hojaReclamo.i_InsertUserId = Int32.Parse(ClientSession[2]);
                _hojaReclamo.i_InsertUserId = 11;

                _hojaReclamo.i_IsDeleted = 0;
                _hojaReclamo.v_ComentaryRegistros = "Primer Registro - USUARIO GENERAL";
                //int intNodeId = int.Parse(ClientSession[0]);
                NewId0 = Utils.Utils.GetNewId(9, Utils.Utils.GetNextSecuentialId(9, 366), "LR"); ;
                _hojaReclamo.v_IdHojaReclamo = NewId0;

                entidad.HojaReclamo.Add(_hojaReclamo);
                entidad.SaveChanges();

                Utils.Utils.SaveLog("9", "", "11", LogEventType.CREACION, "LR", "v_IdHojaReclamo=" + NewId0.ToString(), Success.Ok, null);
            }
            catch (Exception ex)
            {
              
                var mensaje = Utils.Utils.ExceptionFormatter(ex);
                Utils.Utils.SaveLog("9", "", "11", LogEventType.CREACION, "LR", "v_IdHojaReclamo=" + NewId0.ToString(), Success.Failed, mensaje);
            }
            //return NewId0;

            
        }

        public List<HojaReclamo> AllHojaReclamo()
        {
            var result = from p in entidad.HojaReclamo select p;
            return result.ToList();
        }

        public List<HojaReclamo> ByQueryAll(string query, DateTime? fecha1, DateTime? fecha2)
        {
            var dbQuery = (from p in entidad.HojaReclamo.Include("person") select p);

            if (!String.IsNullOrEmpty(query))
                dbQuery = dbQuery.Where(o => o.person.v_FirstName.Contains(query) || o.person.v_FirstLastName.Contains(query) || o.person.v_SecondLastName.Contains(query) || o.person.v_DocNumber.Contains(query));

            if (fecha1 != null && fecha2 != null)
                dbQuery = dbQuery.Where(o => o.d_fechaR >= fecha1 && o.d_fechaR <= fecha2);

            return dbQuery.ToList();
        }

        public void DeleteAlumno(string _hojaReclamoid)
        {
            var existe = entidad.HojaReclamo.Find(_hojaReclamoid);
            if (existe != null)
            {
                entidad.HojaReclamo.Remove(existe);
                entidad.SaveChanges();
            }
        }

        public HojaReclamo FindHojaReclamo(string id)
        {
            //var result = from p in entidad.HojaReclamo.Include("person") where p.v_IdPaciente == id select p;
            //var result = from p in entidad.HojaReclamo where p.v_IdPaciente == id select p;

            var result = entidad.HojaReclamo.Find(id);

            return result;
        }

        public void UpdateAlumno(HojaReclamo _hojaReclamo)
        {
            entidad.Entry(_hojaReclamo).State = EntityState.Modified;
            entidad.SaveChanges();
        }

        
    }
}
