using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class AdminLoginModel
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "Please enter Username.")]
        public string UserName { get; set; }
        public long MobileNo {get;set;}
        [Required(ErrorMessage = "Please enter password.")]
        public string Password { get; set; }
    }
}