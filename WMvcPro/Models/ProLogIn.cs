using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WMvcPro.Models
{
    public class ProLogIn
    {

        [Display(Name = "LogInId")]
        public int LogInId { get; set; }

        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}