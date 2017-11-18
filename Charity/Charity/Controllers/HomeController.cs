using Charity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var advRep = new AdvRepository();
            var advList = advRep.GetAll();

            return View(advList);
        }

        public ActionResult Adv()
        {
            return View();
        }

        public ActionResult Profile()
        {


            return View();
        }

        public ActionResult AddAdv()
        {


            return View();
        }
    }
}