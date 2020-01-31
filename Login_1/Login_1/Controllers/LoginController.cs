using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_1.Models;

namespace Login_1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult showDetails(UserNameAndPassword credentials)
        {
           
            using (Entities db = new Entities())
            {
                var val = db.tbl_login.Where(m => m.Username == credentials.Username && m.password == credentials.password).FirstOrDefault();
                if(val!=null)
                {
                    Session["UserName"] = credentials.Username;
                    return RedirectToAction("Home","Home");
                }
                else
                {
                    credentials.LoginErrorMSg = "UserName and password is Wrong";
                    TempData["Alert"] = credentials.LoginErrorMSg;
                    return RedirectToAction("Index", "Login");
                }
            }
        }

        public ActionResult LogoutSession()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}