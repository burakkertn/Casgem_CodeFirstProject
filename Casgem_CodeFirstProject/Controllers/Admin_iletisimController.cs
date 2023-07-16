using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Casgem_CodeFirstProject.Controllers
{
    public class Admin_iletisimController : Controller
    {
        
        TravelContext travelContext = new TravelContext();
      
        public ActionResult Index()
        {
            var values = travelContext.Iletisims.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult IletisimUpdate(int id)
        {
            var values = travelContext.Iletisims.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult IletisimUpdate(Iletisim p)
        {
            var values = travelContext.Iletisims.Find(p.IletisimID);
            values.Address = p.Address;
            values.Telefon = p.Telefon;
            values.Mail = p.Mail;
            values.FaceURL = p.FaceURL;
            values.TwitterURL = p.Mail;
            values.InsagramURL = p.InsagramURL;
            values.MailURL = p.MailURL;
            values.LinkedinURL = p.LinkedinURL;

            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}