using LaundraMateWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaundraMateWebApi.Controllers
{
    public class OrderHistoryApiController : ApiController
    {
        private LoundraMateDbEntities1 db;
        public OrderHistoryApiController()
        {

            db = new LoundraMateDbEntities1();
        }
        // GET api/values
        public IEnumerable<OrderHistoryModel> Get(Customer custormer)
        {
            List<OrderHistoryModel> orderHistoryModel = new List<OrderHistoryModel>();
            var orderTable = db.OrderTables.Where(s=>s.CustId == custormer.Id).ToList();
            foreach (var o in orderTable) {

                orderHistoryModel.Add(new OrderHistoryModel {
                    Id = o.Id,

                });
            }

            return orderHistoryModel;
        }
    }
}
