﻿using SVPDomain;
using SVPDomain.ClasesNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface HojaReclamoInterface
    {
        void AddHojaReclamo(HojaReclamo _hojaReclamo);

        void UpdateAlumno(HojaReclamo _hojaReclamo);

        void DeleteAlumno(string _hojaReclamoid);

        List<HojaReclamoList> AllHojaReclamo();

        List<HojaReclamoList> ByQueryAll(string query, DateTime? fecha1, DateTime? fecha2);

        HojaReclamo FindHojaReclamo(string id);
    }
}
