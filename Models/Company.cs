using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class Company
    {
        [Display(Name = "Company ID")]
        public int CompanyID { get; set; } 
         
        [Display(Name="Company Name")]
        public string CompanyName { get; set; }



        [Display(Name = "Industry ID")]
        public int IndustryID { get; set; }
        [Display(Name = "Website")]
        public string Website { get; set; }
        [Display(Name = "LinkedIn")] 
        public string LinkedIn { get; set; }
        [Display(Name = "Facebook")]
        public string Facebook { get; set; }
        [Display(Name = "Preferred Contact Method")]

        //navigation

        public ICollection<Location> Locations { get; set; }
        public Industry Industry { get; set; }

    }
}
