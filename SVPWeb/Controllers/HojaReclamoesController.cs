using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Interfaces;
using PagedList;
using SVPDomain;

namespace SVPWeb.Controllers
{
    public class HojaReclamoesController : Controller
    {
        private HojaReclamoInterface _HojaReclamo;
        private PersonInterface _Person;

        public HojaReclamoesController(HojaReclamoInterface HojaReclamo, PersonInterface Person)
        {
            this._HojaReclamo = HojaReclamo;
            this._Person = Person;
        }

        public ActionResult Index(string query = "", DateTime? fecha1 = null, DateTime? fecha2 = null, int? page = null)
        {
            page = (page ?? 1);
            var datos = _HojaReclamo.ByQueryAll(query, fecha1, fecha2);
            return View(datos.ToPagedList((int)page, 15));
        }

        public ActionResult Details(string id)
        {
            var data = _HojaReclamo.FindHojaReclamo(id);
            return View("Details", data);
        }

        public ActionResult Create()
        {
            //ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName");

            //ViewBag.IdTrabajador = _Person.AllPerson();

            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(HojaReclamo hojaReclamo)
        {
            //validator.Execute(justificacionTra);
            //validator.errors.ToList().ForEach(x => ModelState.AddModelError(x.Key, x.Value));
            //if (ModelState.IsValid)
            //{
            _HojaReclamo.AddHojaReclamo(hojaReclamo);
            TempData["UpdateSuccess"] = "Se Guardó Correctamente";

            //if (justificacionTra.DocumentoFile != null)
            //{
            //    var folderCV = "~/Content/Just-Trabajadores";
            //    var fileCV = string.Format("{0}.pdf", "Justificación-" + hojaReclamo.Motivo);
            //    var responseCV = FileHelpers.UploadDoc(hojaReclamo.DocumentoFile, folderCV, fileCV);
            //    if (responseCV)
            //    {
            //        var picCV = string.Format("{0}/{1}", folderCV, fileCV);
            //         hojaReclamo.Documento = picCV;

            //    _HojaReclamo.UpdateJustificacionTra(hojaReclamo);
            //    }
            //}
            return RedirectToAction("Index");
            //}

            //ViewBag.IdTrabajador = intrabajador.AllTrabajador();
            //return View("Create", justificacionTra);
        }

        //public ActionResult Edit(string id)
        //{
        //    ViewBag.trabajador = intrabajador.AllTrabajador();
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var data = repository.FindJustificacionTra(id);
        //    if (data == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View("Edit", data);
        //}

        //[HttpPost]
        //public ActionResult Edit(JustificacionTra justificacionTra)
        //{
        //    validator.Execute(justificacionTra);
        //    validator.errors.ToList().ForEach(x => ModelState.AddModelError(x.Key, x.Value));

        //    if (ModelState.IsValid)
        //    {
        //        if (justificacionTra.DocumentoFile != null)
        //        {
        //            var folderCV = "~/Content/Just-Trabajadores";
        //            var fileCV = string.Format("{0}.pdf", "Justificación-" + justificacionTra.Motivo);
        //            var responseCV = FileHelpers.UploadDoc(justificacionTra.DocumentoFile, folderCV, fileCV);
        //            if (responseCV)
        //            {
        //                var picCV = string.Format("{0}/{1}", folderCV, fileCV);
        //                justificacionTra.Documento = picCV;

        //            }
        //        }
        //        repository.UpdateJustificacionTra(justificacionTra);
        //        TempData["UpdateSuccess"] = "Se actualizó correctamente";
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.IdTrabajador = _Person.AllPerson();
        //    var data = _HojaReclamo.FindHojaReclamo(justificacionTra.Id);
        //    return View("Edit", data);
        //}

        //public ActionResult Delete(string id)
        //{
        //    var user = _HojaReclamo.FindHojaReclamo(id);
        //    _HojaReclamo.DeleteJustificacionTra(id);
        //    TempData["UpdateSuccess"] = "Se eliminó correctamente";
        //    return RedirectToAction("Index");
        //}

        public ActionResult SelectPersona(string dni)
        {
            var modelo = new person();
            if (!string.IsNullOrEmpty(dni))
            {
                var query = _Person.FindPersonByDni(dni);
                modelo = query;
            }
            return PartialView("_SelectPersona", modelo);
        }


        //private SigesoftDesarrollo_2Entities db = new SigesoftDesarrollo_2Entities();

        //// GET: HojaReclamoes
        //public ActionResult Index()
        //{
        //    var hojaReclamo = db.HojaReclamo.Include(h => h.person);
        //    return View(hojaReclamo.ToList());
        //}

        //// GET: HojaReclamoes/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    HojaReclamo hojaReclamo = db.HojaReclamo.Find(id);
        //    if (hojaReclamo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(hojaReclamo);
        //}

        //// GET: HojaReclamoes/Create
        //public ActionResult Create()
        //{
        //    ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName");
        //    return View();
        //}

        //// POST: HojaReclamoes/Create
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        //// más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "v_IdHojaReclamo,i_CorrelativoReclamo,d_fechaR,v_IdPaciente,i_Parentesco,i_Producto,i_Servicio,v_MontoReclamo,v_Descripcion,i_Reclamo,i_Queja,v_Detalle,v_Pedido,b_FirmaConsumidor,d_FechaComunicacionRespuesta,b_FirmaProveedor,i_IsDeleted,i_InsertUserId,d_InsertDate,i_UpdateUserId,d_UpdateDate,v_ComentaryRegistros")] HojaReclamo hojaReclamo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.HojaReclamo.Add(hojaReclamo);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName", hojaReclamo.v_IdPaciente);
        //    return View(hojaReclamo);
        //}

        //// GET: HojaReclamoes/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    HojaReclamo hojaReclamo = db.HojaReclamo.Find(id);
        //    if (hojaReclamo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName", hojaReclamo.v_IdPaciente);
        //    return View(hojaReclamo);
        //}

        //// POST: HojaReclamoes/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        //// más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "v_IdHojaReclamo,i_CorrelativoReclamo,d_fechaR,v_IdPaciente,i_Parentesco,i_Producto,i_Servicio,v_MontoReclamo,v_Descripcion,i_Reclamo,i_Queja,v_Detalle,v_Pedido,b_FirmaConsumidor,d_FechaComunicacionRespuesta,b_FirmaProveedor,i_IsDeleted,i_InsertUserId,d_InsertDate,i_UpdateUserId,d_UpdateDate,v_ComentaryRegistros")] HojaReclamo hojaReclamo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(hojaReclamo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName", hojaReclamo.v_IdPaciente);
        //    return View(hojaReclamo);
        //}

        //// GET: HojaReclamoes/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    HojaReclamo hojaReclamo = db.HojaReclamo.Find(id);
        //    if (hojaReclamo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(hojaReclamo);
        //}

        //// POST: HojaReclamoes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    HojaReclamo hojaReclamo = db.HojaReclamo.Find(id);
        //    db.HojaReclamo.Remove(hojaReclamo);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
