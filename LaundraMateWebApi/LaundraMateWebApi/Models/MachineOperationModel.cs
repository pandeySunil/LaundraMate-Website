using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundraMateWebApi.Models
{
    public class MachineOperationModel
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string MachineCode { get; set;}
        public bool ValidLogedInUserFlag { get; set; }
        public bool MachingBusyFlag { get; set; }
        public bool SucessFlag { get; set; }
    }
}