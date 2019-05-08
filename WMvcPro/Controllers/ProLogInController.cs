using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMvcPro.Models;
using WMvcPro.ViewModel;

namespace WMvcPro.Controllers
{
    public class ProLogInController : Controller
    {
        // GET: ProLogIn
        public ActionResult ProLgIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProLgIn(ProLgInViewModel pro)
        {
            ProLogInCli CC = new ProLogInCli();
            ProLogIn logIn = CC.ProLogCre(pro.proLogIn);
            if (logIn == null)
            {
                TempData["Error"] = "Invalid UserName and Password.";
                Session["USERID"] = null;
                return RedirectToAction("ProLgIn", "ProLogIn");
            }
            else
            {
                Session["USERID"] = logIn.LogInId;
                return RedirectToAction("ProInd", "Product");
            }
        }

        public ActionResult LogOut()
        {
            Session["USERID"] = null;
            return RedirectToAction("HomePage", "Home");
        }

    }
}