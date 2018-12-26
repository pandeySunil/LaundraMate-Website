using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class Code
    {
        public int Id { get; set; }
        public Nullable<int> CustomerId { get; set; }

        public string DeviceCode { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}