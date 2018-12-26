using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public double MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }

    }
}