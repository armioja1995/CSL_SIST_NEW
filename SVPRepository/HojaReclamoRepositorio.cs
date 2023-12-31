﻿using Interfaces;
using Microsoft.Win32;
using SVPDomain;
using SVPDomain.ClasesNew;
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

        public List<HojaReclamoList> AllHojaReclamo()
        {
            var result = from p in entidad.ListadoHojaReclamoAll_SP()
                         select new HojaReclamoList
                         {
                             v_IdHojaReclamo = p.v_IdHojaReclamo,
                             i_CorrelativoReclamo = p.i_CorrelativoReclamo,
                             d_fechaR = p.d_fechaR.Value,
                             v_IdPaciente = p.v_IdPaciente,
                             Paciente = p.Paciente,
                             //i_Producto = p.i_Producto.Value,
                             //i_Servicio = p.i_Servicio.Value,
                             Prod_Serv = p.Prod_Serv,
                             v_MontoReclamo = p.v_MontoReclamo,
                             v_Descripcion = p.v_Descripcion,
                             Quej_Recl = p.Quej_Recl,
                             v_Pedido = p.v_Pedido,
                             b_FirmaConsumidor = p.b_FirmaConsumidor,
                             d_FechaComunicacionRespuesta = p.d_FechaComunicacionRespuesta.Value,
                             b_FirmaProveedor = p.b_FirmaProveedor,
                             i_IsDeleted = p.i_IsDeleted.Value,
                             i_InsertUserId = p.i_InsertUserId.Value,
                             UsuarioRegistro = p.UsuarioRegistro,
                             d_InsertDate = p.d_InsertDate.Value,
                             UsuarioEdita = p.UsuarioEdita,
                             d_UpdateDate = p.d_UpdateDate.Value,
                             v_ComentaryRegistros = p.v_ComentaryRegistros,

                         };
            return result.ToList();
        }

        public List<HojaReclamoList> ByQueryAll(string query, DateTime? fecha1, DateTime? fecha2)
        {
            var dbQuery = from p in entidad.ListadoHojaReclamoAll_SP()
                         select new HojaReclamoList
                         {
                             v_IdHojaReclamo = p.v_IdHojaReclamo,
                             i_CorrelativoReclamo = p.i_CorrelativoReclamo,
                             d_fechaR = p.d_fechaR.Value,
                             v_IdPaciente = p.v_IdPaciente,
                             Paciente = p.Paciente,
                             i_Producto = p.i_Producto.Value,
                             i_Servicio = p.i_Servicio.Value,
                             Prod_Serv = p.Prod_Serv,
                             v_MontoReclamo = p.v_MontoReclamo,
                             v_Descripcion = p.v_Descripcion,
                             i_Queja = p.i_Queja.Value,
                             i_Reclamo = p.i_Reclamo.Value,
                             Quej_Recl = p.Quej_Recl,
                             v_Pedido = p.v_Pedido,
                             b_FirmaConsumidor = p.b_FirmaConsumidor,
                             //d_FechaComunicacionRespuesta = p.d_FechaComunicacionRespuesta.Value,
                             b_FirmaProveedor = p.b_FirmaProveedor,
                             i_IsDeleted = p.i_IsDeleted.Value,
                             i_InsertUserId = p.i_InsertUserId.Value,
                             UsuarioRegistro = p.UsuarioRegistro,
                             d_InsertDate = p.d_InsertDate.Value,
                             UsuarioEdita = p.UsuarioEdita,
                             //d_UpdateDate = p.d_UpdateDate.Value,
                             v_ComentaryRegistros = p.v_ComentaryRegistros,
                         };

            if (!String.IsNullOrEmpty(query))
                dbQuery = dbQuery.Where(o => o.Paciente.Contains(query) || o.DNI.Contains(query));

            if (fecha1 != null && fecha2 != null)
                dbQuery = dbQuery.Where(o => o.d_fechaR >= fecha1 && o.d_fechaR <= fecha2);

            return dbQuery.ToList();
        }

        public void DeleteHojaReclamo(string _hojaReclamoid)
        {
            var existe = entidad.HojaReclamo.Find(_hojaReclamoid);
            if (existe != null)
            {
                existe.d_UpdateDate = DateTime.Now;
                existe.i_UpdateUserId = 11;

                existe.i_IsDeleted = 1;
                existe.v_ComentaryRegistros = existe.v_ComentaryRegistros
                                                    + "[" + existe.i_CorrelativoReclamo.ToString()
                                                    + "; " + existe.d_fechaR.ToString()
                                                    + "; " + existe.i_Parentesco.ToString()
                                                    + "; " + existe.i_Producto.ToString()
                                                    + "; " + existe.i_Servicio.ToString()
                                                    + "; " + existe.v_MontoReclamo.ToString()
                                                    + "; " + existe.i_Reclamo.ToString()
                                                    + "; " + existe.i_Queja.ToString()
                                                    + "; " + existe.v_Detalle.ToString()
                                                    + "; " + existe.v_Pedido.ToString()
                                                    + "; " + existe.d_FechaComunicacionRespuesta.ToString()
                                                    + "; " + existe.i_IsDeleted.ToString()
                                                    + "; " + existe.d_InsertDate.ToString()
                                                    + "; " + existe.i_UpdateUserId.ToString()
                                                    + "; " + existe.d_UpdateDate.ToString()
                                                    + "]";

                entidad.Entry(existe).State = EntityState.Modified;
                entidad.SaveChanges();
                //entidad.HojaReclamo.Remove(existe);
                //entidad.SaveChanges();
            }
        }

        public HojaReclamo FindHojaReclamo(string id)
        {
            //var result = from p in entidad.HojaReclamo.Include("person") where p.v_IdPaciente == id select p;
            //var result = from p in entidad.HojaReclamo where p.v_IdPaciente == id select p;

            var result = entidad.HojaReclamo.Find(id);

            return result;
        }

        public void UpdateHojaReclamo(HojaReclamo _hojaReclamo)
        {
            _hojaReclamo.d_UpdateDate = DateTime.Now;
            _hojaReclamo.i_UpdateUserId = 11;

            _hojaReclamo.i_IsDeleted = 0;
            _hojaReclamo.v_ComentaryRegistros = _hojaReclamo.v_ComentaryRegistros 
                                                + "[" + _hojaReclamo.i_CorrelativoReclamo.ToString() 
                                                + "; " + _hojaReclamo.d_fechaR.ToString()
                                                + "; " + _hojaReclamo.i_Parentesco.ToString()
                                                + "; " + _hojaReclamo.i_Producto.ToString()
                                                + "; " + _hojaReclamo.i_Servicio.ToString()
                                                + "; " + _hojaReclamo.v_MontoReclamo.ToString()
                                                + "; " + _hojaReclamo.i_Reclamo.ToString()
                                                + "; " + _hojaReclamo.i_Queja.ToString()
                                                + "; " + _hojaReclamo.v_Detalle.ToString()
                                                + "; " + _hojaReclamo.v_Pedido.ToString()
                                                + "; " + _hojaReclamo.d_FechaComunicacionRespuesta.ToString()
                                                + "; " + _hojaReclamo.i_IsDeleted.ToString()
                                                + "; " + _hojaReclamo.d_InsertDate.ToString()
                                                + "; " + _hojaReclamo.i_UpdateUserId.ToString()
                                                + "; " + _hojaReclamo.d_UpdateDate.ToString()
                                                + "]";

            entidad.Entry(_hojaReclamo).State = EntityState.Modified;
            entidad.SaveChanges();


        }

        
    }
}
