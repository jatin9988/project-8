using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WMvcPro.Models
{
    public class Product
    {
        [Display(Name = "ProductId")]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        public string ProductDes { get; set; }

        [Display(Name = "List Price")]
        public string ListPrice { get; set; }

        [Display(Name = "Seller Name")]
        public string SellerName { get; set; }

        [Display(Name = "Seller MobileNo")]
        public string SellerMobileNo { get; set; }

        [Display(Name = "Seller Email")]
        public string SellerEmail { get; set; }

    }
}