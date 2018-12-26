using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class OrderModel
    {
        public OrderTable Orders { get; set;}
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}