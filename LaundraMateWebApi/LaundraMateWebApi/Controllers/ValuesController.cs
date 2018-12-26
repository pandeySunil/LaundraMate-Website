using LaundraMateWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaundraMateWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private LoundraMateDbEntities1 db;
        public ValuesController() {

            db = new LoundraMateDbEntities1();
        }
        // GET api/values
        public IEnumerable<Customer> Get()
        {
            return db.Customers;
        }

        // GET api/values/5
        public Customer Get(int id)
        {

            Customer customer = db.Customers.FirstOrDefault(s => s.Id == id);
            return customer;
        }

        // POST api/values
        public CustomerRegistrationModel Post(Customer customer)
        {
            CustomerRegistrationModel customerRegistrationModel = new CustomerRegistrationModel();
            if (customer != null) {
                if(db!=null&& db.Customers != null)
                {
                    customer.Id = Convert.ToInt32(db.Customers.Count())+1;
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    customerRegistrationModel.Customer = customer;
                    customerRegistrationModel.Status = true;
                    customerRegistrationModel.Message = "User is registered";
                    return customerRegistrationModel;
                }
                
            }
            return customerRegistrationModel;

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
