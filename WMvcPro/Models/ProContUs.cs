using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WMvcPro.Models
{
    public class ProContUs
    {
        [Display(Name = "ContactId")]
        public int ContactId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Message")]
        public string Message { get; set; }

    }

}