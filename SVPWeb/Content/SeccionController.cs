using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

//using SVPDomain;
//using SVPRepository;
//using Interfaces;
//using Validators.AlumnoValidators;

namespace SVPWeb.Content
{
    public class SeccionController : Controller
    {
        //private InterfaceSeccion repository;
        ////private SeccionValidators validator;

        //public SeccionController(InterfaceSeccion repository/*, SeccionValidators validator*/)
        //{
        //    this.repository = repository;
        //    //this.validator = validator;
        //}

        //// GET: Sección
        //public ActionResult Index(string query)
        //{
        //    var datos = repository.ByQueryAll(query);
        //    return View("Index", datos);
        //}

        //// GET: Sección/Details/5
        //public ActionResult Details(int id)
        //{
        //    var data = repository.FindSeccion(id);
        //    return View("Details", data);
        //}

        //// GET: Sección/Create
        //public ActionResult Create()
        //{
        //    return View("Create");
        //}

        //[HttpPost]
        //public ActionResult Create(Seccion seccion)
        //{
        //    //validator.Execute(seccion);
        //    //validator.errors.ToList().ForEach(x => ModelState.AddModelError(x.Key, x.Value));

        //    if (ModelState.IsValid)
        //    {
        //        repository.AddSeccion(seccion);
        //        TempData["UpdateSuccess"] = "Se Guardó Correctamente";
        //        return RedirectToAction("Index");
        //    }

        //    return View("Create", seccion);
        //}

        //// GET: Sección/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var data = repository.FindSeccion(id);
        //    if (data == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View("Edit", data);
        //}

        //[HttpPost]
        //public ActionResult Edit(Seccion seccion)
        //{
        //    //validator.Execute(seccion);
        //    //validator.errors.ToList().ForEach(x => ModelState.AddModelError(x.Key, x.Value));

        //    if (ModelState.IsValid)
        //    {
        //        repository.UpdateSeccion(seccion);
        //        TempData["UpdateSuccess"] = "Se actualizo correctamente";
        //        return RedirectToAction("Index");
        //    }
        //    var data = repository.FindSeccion(seccion.Id);
        //    return View("Edit", data);
        //}

        //// GET: Sección/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    repository.DeleteSeccion(id);
        //    TempData["UpdateSuccess"] = "Se Eliminó Correctamente";
        //    return RedirectToAction("Index");
        //}
    }
}
