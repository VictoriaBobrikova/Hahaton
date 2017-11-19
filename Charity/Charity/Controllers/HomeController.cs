using Charity.Models.PostModels;
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

        public ActionResult Adv(int id)
        {
            var advRep = new AdvRepository();
            var adv = advRep.GetAdvById(id);
            return View(adv);
        }

        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult AddAdv(AdvPostModel model)
        {
            var advRepository = new AdvRepository();
            var newAdvId = advRepository.AddNewAdv(model);

            return RedirectToAction("Adv", new { id = newAdvId });
        }
    }
}