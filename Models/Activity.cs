using CapstoneSalesCRM.Pages.Activities;
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
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        [MyDate(ErrorMessage = "Invalid date")]
        public DateTime? DateScheduled { get; set; }
        [Display(Name = "Date Created")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        [MyDate(ErrorMessage = "Invalid date")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [Display(Name = "Who To Notify")]
        public string WhoToNotify { get; set; }
        [Display(Name = "How To Notify")]
        public string HowToNotify { get; set; }
        [Display(Name = "Notes")]
        public string Notes { get; set; }
        [Display(Name = "Status")]
        [EnumDataType(typeof(ActivityStatus))]
        public ActivityStatus Status { get; set; }
        [Display(Name = "Date Completed")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        [MyDate(ErrorMessage = "Invalid date")]
        public DateTime? DateCompleted { get; set; }


        //navigation

        public Contact Contact { get; set; }
        public ActivityTask ActivityTask { get; set; }


        //public User Users { get; set; }
    }

    public enum ActivityStatus
    {
        Complete,
        Incomplete
    }
}
