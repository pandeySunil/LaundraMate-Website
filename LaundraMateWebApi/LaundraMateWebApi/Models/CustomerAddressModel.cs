using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class CustomerAddressModel
    {
        public int CustomerId { get; set; }
        public Address Address { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}