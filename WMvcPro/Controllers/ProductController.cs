using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMvcPro.Models;
using WMvcPro.ViewModel;

namespace WMvcPro.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProInd()
        {
           ProductClient product = new ProductClient();
           ViewBag.listproducts = product.ProfdAll();

            return View();
        }

        public ActionResult ProDet()
        {
            ProductClient product = new ProductClient();
            ViewBag.listproducts = product.ProfdAll();

            return View();
        }

        [HttpGet]
        public ActionResult ProCre()
        {
            return View("ProCre");
        }

        [HttpPost]
        public ActionResult ProCre(ProductViewModel pro)
        {
            ProductClient CC = new ProductClient();
            CC.ProCre(pro.product);
            return RedirectToAction("ProInd");
        }

        public ActionResult ProDel(int id)
        {
            ProductClient CC = new ProductClient();
            CC.ProDel(id);
            return RedirectToAction("ProInd");
        }

        [HttpGet]
        public ActionResult ProEdt(int? id)
        {
            ProductClient prod = new ProductClient();
            ProductViewModel productView = new ProductViewModel();
            productView.product = prod.ProfdById(id);
            return View("ProEdt", productView);
        }

        [HttpPost]
        public ActionResult ProEdt(ProductViewModel productView)
        {
            ProductClient CC = new ProductClient();
            CC.ProEdt(productView.product);
            return RedirectToAction("ProInd");
        }

    }
}