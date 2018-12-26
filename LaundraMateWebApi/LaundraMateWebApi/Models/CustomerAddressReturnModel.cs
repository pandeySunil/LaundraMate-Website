using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class CustomerAddressReturnModel
    {
        public int CustomerId { get; set; }
        public List<Address> Addresses { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}