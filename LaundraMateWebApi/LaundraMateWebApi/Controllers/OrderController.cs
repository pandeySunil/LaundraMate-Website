using LaundraMateWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaundraMateWebApi.Controllers
{
    public class OrderController : Controller
    {
        private LoundraMateDbEntities1 db;
        // GET: Order
        public OrderController() {

            db = new LoundraMateDbEntities1();
        }
        [HttpPost]
        public ActionResult AddressSave(CustomerAddressModel customerAddressModel) {
            
            
            if (customerAddressModel != null&& customerAddressModel.Address!=null)
            {
                customerAddressModel.Address.Id = Convert.ToInt32(db.Addresses.Count()) + 1;
                db.Addresses.Add(customerAddressModel.Address);
                customerAddressModel.Status = true;
                customerAddressModel.Message = "Address is saved properly";
                db.SaveChanges();


            }
            else {
                customerAddressModel.Address = new Address();
                customerAddressModel.Status = false;
                customerAddressModel.Message = "Address could not be saved";
            }
            return Json(customerAddressModel);

        }
        [HttpPost]
        public ActionResult AddressDeactivate(CustomerAddressModel customerAddressModel)
        {


            if (customerAddressModel != null && customerAddressModel.Address != null)
            {
                customerAddressModel.Address.Id = Convert.ToInt32(db.Addresses.Count()) + 1;
                db.Addresses.Add(customerAddressModel.Address);
                customerAddressModel.Status = true;
                customerAddressModel.Message = "Address is saved properly";
                db.SaveChanges();


            }
            else
            {
                customerAddressModel.Address = new Address();
                customerAddressModel.Status = false;
                customerAddressModel.Message = "Address could not be saved";
            }
            return Json(customerAddressModel);

        }
        [HttpPost]
        public ActionResult GetAddress(Customer customer) {
            CustomerAddressReturnModel customerAddress = new CustomerAddressReturnModel();

            if (customer != null && customer.Id > 0)
            {
                if (db != null && db.Addresses != null)
                {
                    customerAddress.CustomerId = customer.Id;
                    customerAddress.Addresses = db.Addresses.Where(w => w.CustomerId == customer.Id).ToList();
                    customerAddress.Status = true;
                    customerAddress.Message = "Customer address are loaded properly";
                    return Json(customerAddress);
                }
                else {
                    customerAddress.Status = false;
                    customerAddress.Message = "Customer address are not loaded properly";
                    return Json(customerAddress);
                }
               
            }

            return Json(customerAddress);
        }
            
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveOrder(OrderModel orderModel) {

            if (orderModel != null && db != null&& orderModel.Orders!=null)
            {
                orderModel.Orders.Id = Convert.ToInt32(db.OrderTables.Count()) + 1;
                db.OrderTables.Add(orderModel.Orders);
                db.SaveChanges();
                orderModel.Message = "Order is placed properly";
                orderModel.Status = true;
            }
            else {
                orderModel.Orders = new OrderTable();
                orderModel.Message = "Order is not placed properly";
                orderModel.Status = false;
            }
            return Json(orderModel);
        }
    }
}