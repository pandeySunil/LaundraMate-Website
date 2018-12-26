using LaundraMateWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LaundraMateWebApi.Controllers
{
    public class MachineOperationController : Controller
    {
        private LoundraMateDbEntities1 db;
        // GET: MachineOperation
        public MachineOperationController() {
            db = new LoundraMateDbEntities1();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MachineStatusUpdate(MachineOperationModel machineOperationModel) {

            if (db != null && db.Customers != null && machineOperationModel.EmailId != null && machineOperationModel.Password!=null)
            {
                var customer = db.Customers.FirstOrDefault(s => s.EmailId == machineOperationModel.EmailId);
                if (customer.Password == machineOperationModel.Password)
                {
                    machineOperationModel.ValidLogedInUserFlag = true;
                    var validMachine = db.WashinMachines.FirstOrDefault(s => s.MachineId == machineOperationModel.MachineCode);
                    if (validMachine != null)
                    {
                        validMachine.Status = true;
                        db.SaveChanges();
                        machineOperationModel.ValidLogedInUserFlag = true;
                        machineOperationModel.SucessFlag = true;
                         return Json(machineOperationModel);
                        //return Json(Newtonsoft.Json.JsonConvert.SerializeObject(machineOperationModel));
                    }
                    else
                    {
                        machineOperationModel.SucessFlag = false;
                    }
                }
            }
            else
            {
                machineOperationModel.ValidLogedInUserFlag = false;
            }

            // return machineOperationModel;

            // return Json(Newtonsoft.Json.JsonConvert.SerializeObject(machineOperationModel));
            return Json(machineOperationModel);
        }
       
    }
    }
            
        
    
