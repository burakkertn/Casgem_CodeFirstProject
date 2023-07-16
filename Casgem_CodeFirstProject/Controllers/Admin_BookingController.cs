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
    public class Admin_BookingController : Controller
    {
        
        TravelContext travelContext = new TravelContext();
        // GET: Admin_Guide
        public ActionResult Index()
        {
            var values = travelContext.Bookings.ToList();
            return View(values);
        }
       

       

        public ActionResult DeleteBooking(int id)
        {
            var values =travelContext.Bookings.Find(id);
            travelContext.Bookings.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

      

     
    }
}