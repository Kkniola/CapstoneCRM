using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class ActivityTask
    {
        [Display(Name = "Task ID")] 
        public int ActivityTaskID { get; set; }
        //public string Call { get; set; }

        //public string Meeting { get; set; }
        //public string Email { get; set; }

        [Display(Name = "Description")] 
        public string TaskDescription { get; set; }


        public ICollection<Activity> Activities{ get; set; }
    }
}
