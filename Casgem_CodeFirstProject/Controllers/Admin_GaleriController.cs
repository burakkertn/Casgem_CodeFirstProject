﻿using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Casgem_CodeFirstProject.Controllers
{
    public class Admin_GaleriController : Controller
    {
        
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Galleries.ToList();
            return View(values);
        }
        public ActionResult AddGallerie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGallerie(Gallery p)
        {
            travelContext.Galleries.Add(p);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult DeleteGallerie(int id)
        {
            var values =travelContext.Galleries.Find(id);
            travelContext.Galleries.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateGallerie(int id)
        {
            var values = travelContext.Galleries.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateGallerie(Gallery p)
        {
            var values = travelContext.Galleries.Find(p.GalleryID);
            values.GalleryURL = p.GalleryURL;
        

            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}