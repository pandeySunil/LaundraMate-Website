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
    using System;
    using System.Collections.Generic;
    
    public partial class Store
    {
        public int Id { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Area { get; set; }
        public Nullable<long> ContactNo { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<long> PinCode { get; set; }
    }
}
