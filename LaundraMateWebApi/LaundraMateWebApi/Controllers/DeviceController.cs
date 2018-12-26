using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaundraMateWebApi.Models;

namespace LaundraMateWebApi.Controllers
{
    public class DeviceController : Controller
    {
         private LoundraMateDbEntities1 db;
        public DeviceController() {
            db = new LoundraMateDbEntities1();
        }
        [HttpPost]
        public ActionResult Index(DeviceCodeModel deviceCodeModel)
        {
            
            if (deviceCodeModel != null &&deviceCodeModel.DeviceCode!=null&& db != null && db.DeviceCodes != null)
            {
                
                //deviceCodeModel.DeviceCode.Id = Convert.ToInt32(db.DeviceCodes.Count()) + 1;
                db.DeviceCodes.Add(new DeviceCode() {DeviceCode1 = deviceCodeModel.DeviceCode.DeviceCode,
                Active = deviceCodeModel.DeviceCode.Active,
                CustomerId = deviceCodeModel.DeviceCode.CustomerId,
                Id = Convert.ToInt32(db.DeviceCodes.Count()) + 1,
                });
                db.SaveChanges();
                deviceCodeModel.Status = true;
                deviceCodeModel.Message = "Device Code is properly saved";
                return Json(deviceCodeModel);

            }
            else {
                deviceCodeModel.DeviceCode = new Code();
                deviceCodeModel.Status = false;
                deviceCodeModel.Message = "Device Code could not be saved properly ";
                return Json(deviceCodeModel);
            }
           
        }
    }
}