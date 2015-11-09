using DayOffManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionCongés.Controllers
{
    public class MemberController : Controller
    {
        public void Index()
        {
            using (var db = new DayOffManagerContext())
            {
                db.Teams.Add(new Team { Name = "PORC", CreatedDate = DateTime.Now, Active = true });
                db.SaveChanges();
            }
            //return View();
        }
    }
}
