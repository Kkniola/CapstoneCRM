using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class Activity
    {
        [Display(Name = "Activity ID")]
        public int ActivityID { get; set; }
        [Display(Name = "Task ID")]
        public int ActivityTaskID { get; set; }
        [Display(Name = "Contact ID")]
        public int ContactID { get; set; }
        [Display(Name = "Date Scheduled")]
        public DateTime? DateScheduled { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        //public int UserID { get; set; }
        [Display(Name = "Who To Notify")]
        public string WhoToNotify { get; set; }
        [Display(Name = "How To Notify")]
        public string HowToNotify { get; set; }
        [Display(Name = "Notes")]
        public string Notes { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
        [Display(Name = "Date Completed")]
        public DateTime? DateCompleted { get; set; }


        //navigation

        public Contact Contact { get; set; }
        public ActivityTask ActivityTask { get; set; }


        //public User Users { get; set; }
    }
}
