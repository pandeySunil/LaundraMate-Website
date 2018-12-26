using LaundraMateWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaundraMateWebApi.Controllers
{
    public class StoresController : ApiController
    {
        private LoundraMateDbEntities1 db;
        public StoresController() {
            db = new LoundraMateDbEntities1();
        }
        public StoresModel Get()
        {
            if (db != null && db.Stores != null)
            {
                var stores = db.Stores.ToList();
                StoresModel storesModel = new StoresModel()
                {
                    Stores = db.Stores.ToList(),
                    Message = "List of stores are sucessfully populated",
                    Status = true

                    
                };
                return storesModel;

            }

         else{
                StoresModel storesModel = new StoresModel()
                {
                    Status = false,
                    Message = "List of stores could not be loaded"
                };
                return storesModel;

            }
            
        }
    }
}
