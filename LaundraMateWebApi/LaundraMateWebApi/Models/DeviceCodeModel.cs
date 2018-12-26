using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class DeviceCodeModel
    {

        public Code DeviceCode { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}