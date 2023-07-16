using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace Casgem_CodeFirstProject.Controllers
{

    public class LoginController : Controller
    {
        TravelContext travelContext = new TravelContext();
        [HttpGet]
     
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
          
            var user = travelContext.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                Session["usertravel"] = user.Username.ToString();
                return RedirectToAction("Index", "Admin_About");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}