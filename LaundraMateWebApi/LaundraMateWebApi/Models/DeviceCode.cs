//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaundraMateWebApi.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class DeviceCode
    {
        public int Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        
        public string DeviceCode1 { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}