using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaundraMateWebApi.Models;
using LaundraMateWebApi.ViewModels;

namespace LaundraMateWebApi.Controllers
{
    public class HomeController : Controller
    {
        private LoundraMateDbEntities1 db;
        public HomeController() {
            db = new LoundraMateDbEntities1();

        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(AdminLoginModel adminLogin) {
            if (adminLogin != null) {
                
                var admin = db.Admins.FirstOrDefault(s => s.UserName == adminLogin.UserName);
                if (admin != null && admin.Password != null)
                {
                    if (admin.Password == adminLogin.Password)
                    {
                        var customerList = db.Customers;
                        return View(customerList);
                       // return View("AdminLogin");
                    }
                }
                return View("Index");
            }

            return View("Index");
        }
        [HttpPost]
        public ActionResult Login(LoginModel loginCredentials)
        {
            
            if (db!=null&&db.Customers!=null&&loginCredentials != null)
            {
                Customer customer;
                if (loginCredentials.MobileNo != 0)
                {
                    customer = db.Customers.FirstOrDefault(s => s.MobileNo == loginCredentials.MobileNo);
                    if (customer != null) {
                        if (customer.Password == loginCredentials.Password)
                        {
                            loginCredentials.Message = "The User is sucessfully logged in";
                            loginCredentials.Status = true;
                            loginCredentials.Id = customer.Id;
                            loginCredentials.EmailId = customer.EmailId;
                            loginCredentials.Name = customer.UserName;
                            return Json(loginCredentials);
                        }
                    }
                }
                else {
                    customer = db.Customers.FirstOrDefault(s => s.EmailId == loginCredentials.EmailId);
                    if (customer != null)
                    {
                        if (customer.Password == loginCredentials.Password)
                        {
                            loginCredentials.Message = "The User is sucessfully logged in";
                            loginCredentials.Status = true;
                            loginCredentials.Id = customer.Id;
                            loginCredentials.Name = customer.UserName;
                            loginCredentials.MobileNo = (double)customer.MobileNo;
                            return Json(loginCredentials);
                        }
                    }
                }
                
            }

            loginCredentials.Message = "Please enter correct credentials ";
            loginCredentials.Status = false;
            return Json(loginCredentials);
        }
 
        public ActionResult Details(Customer cust) {
            CustomerDetailsModel CustomerDetailObject = new CustomerDetailsModel();
            if (cust != null && db != null && db.Customers != null) {
                CustomerDetailObject.SelectedCustomer = db.Customers.FirstOrDefault(s => s.Id == cust.Id);
                var OrderList = db.OrderTables.Where(s => s.CustId == cust.Id).ToList();
                List<OrderHistoryModel> OrderHistoryModelList = new List<OrderHistoryModel>(); 
                foreach (var o in OrderList) {
                    var h = new OrderHistoryModel() { CustAddress = GetCustomerAddress(o.CustAddressId),
                        StoreAddress = GetStoreAddress(o.StoreId),
                        DeliveryTime = o.DeliveryTime,
                        OrderDate = o.OrderDate,
                        OrderDesc = o.OrderDesc,
                        OrderWeight = Convert.ToDecimal(o.OrderWt),
                        PaymentMode = o.PaymentMode,
                        Orderstatus = o.OrderStaus,
                        MachineCode = o.MachineCode,
                        

                    };
                    OrderHistoryModelList.Add(h);
                }
                CustomerDetailObject.orderHistories = OrderHistoryModelList;

            }

            return View("CustomerDetail", CustomerDetailObject);


        }
        private string GetCustomerAddress(int? Id) {
            string CustomerAddress;
            if (Id != null)
            {
                var AddressObject = db.Addresses.FirstOrDefault(a => a.Id == Id);
                CustomerAddress = AddressObject.Name + " " + AddressObject.AddressLine1 + " " + AddressObject.AddressLine2 + " " +
                     AddressObject.Area + " " +
                    AddressObject.City + " " + AddressObject.State + " " + AddressObject.PinCode;
                return CustomerAddress;
            }
            CustomerAddress = string.Empty;
                return CustomerAddress;
        }

        private string GetStoreAddress(int? Id)
        {
            string CustomerAddress;
            if (Id != null)
            {
                var AddressObject = db.Stores.FirstOrDefault(a => a.Id == Id);
                CustomerAddress = AddressObject.Longitude + " " + AddressObject.AddressLine1 + " " + AddressObject.AddressLine2 + " " +
                     AddressObject.Area + " " +
                    AddressObject.City + " " + AddressObject.State + " " + AddressObject.PinCode+" "+ AddressObject.ContactNo+" "+ 
                    AddressObject.Latitude+" "+ AddressObject.PinCode+" "+ AddressObject.ContactNo;
                return CustomerAddress;
            }
            CustomerAddress = string.Empty;
            return CustomerAddress;
        }
    }
}
