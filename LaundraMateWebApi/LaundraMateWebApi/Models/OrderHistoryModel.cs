using System;

namespace LaundraMateWebApi.Models
{
    public class OrderHistoryModel
    {
        public int Id { get; set; }
        public string CustAddress { get; set; }
        public string StoreAddress { get; set; }
        public Nullable<System.TimeSpan> PickUpTime { get; set; }
        public Nullable<System.TimeSpan> DeliveryTime { get; set; }
        public Nullable<DateTime> OrderDate { get; set; }
        public string OrderDesc { get; set; }
        public decimal OrderWeight { get; set; }
        public string PaymentMode { get; set; }
        public string Orderstatus { get; set; }
        public string MachineCode { get; set; }
        public string VendorComment { get; set; }
    }
}