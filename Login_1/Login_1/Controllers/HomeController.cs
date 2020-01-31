using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_1.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Login_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            using (Entities db = new Entities())
            {
                var joblist = db.JobRoles.ToList();
                SelectList list = new SelectList(joblist,"JobId", "JobRole1");
                ViewBag.JobRoles = list;

            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult InputDetails(UserDetails userDetails)
        {
            using(Entities db = new Entities())
            {
                var val = db.interviewees.Where(m => m.Mail == userDetails.Mail).FirstOrDefault();
                if (val == null)
                {
                    var data = new interviewee
                    {
                        Mail = userDetails.Mail,
                        PhoneNumber = userDetails.PhoneNumber,
                        JobID=userDetails.JobId
                    };
                    db.interviewees.Add(data);
                    db.SaveChanges();
                    return RedirectToAction("Contact", "Home");
                }
                else
                {
                    userDetails.IntervieweeErrorMsg = "Mail ID is Alredy Exist";
                    TempData["alertMessage"] = userDetails.IntervieweeErrorMsg;
                    return RedirectToAction("Home", "Home", userDetails);
                }

            }
     
            
        }
    }
}