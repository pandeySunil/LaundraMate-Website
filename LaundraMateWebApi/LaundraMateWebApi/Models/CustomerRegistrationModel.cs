using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class CustomerRegistrationModel
    {
       public Customer Customer { get; set; }
         public bool Status { get; set; }
       public  string Message { get; set; }
        public List<Address> Addresses { get; set; }
    }
}