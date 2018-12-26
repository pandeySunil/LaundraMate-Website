using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class StoresModel
    {
        public List<Store> Stores { get; set; }
        public string Message { get; set; }
        public bool Status{get;set;}
    }
}