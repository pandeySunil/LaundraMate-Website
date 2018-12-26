using LaundraMateWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.ViewModels
{
    public class CustomerDetailsModel
    {
       public  Customer SelectedCustomer { get; set; }
       public List<OrderHistoryModel> orderHistories { get; set; }
    }
}