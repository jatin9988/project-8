using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMvcPro.Models;
using WMvcPro.ViewModel;

namespace WMvcPro.Controllers
{
    public class ContUsProController : Controller
    {
        // GET: ContactUs
        public ActionResult ProInd()
        {
            ProContUsCli contpro = new ProContUsCli();
            ViewBag.listcontactus = contpro.ProfindAll();

            return View();
        }

        public ActionResult ProCre()
        {
            return View("ProCre");
        }

        [HttpPost]
        public ActionResult ProCre(ProCntUsViewModel pro)
        {
            ProContUsCli CC = new ProContUsCli();
            CC.ProCre(pro.proContUs);
            return RedirectToAction("HomePage", "Home");
        }

    }
}