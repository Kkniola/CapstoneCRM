using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class Location
    {
        [Display(Name = "Location ID")] 
        public int LocationID { get; set; }
        [Display(Name = "Company Name")]
        public int CompanyID { get; set; }
        [Display(Name = "Address 1")] 
        public string LocationAddress1 { get; set; }
        [Display(Name = "Address 2")] 
        public string LocationAddress2 { get; set; }
        [Display(Name = "City")] 
        public string LocationCity { get; set; }
        [Display(Name = "State")] 
        public string StateID { get; set; }
        [Display(Name = "Country")] 
        public string Country { get; set; }
        [Display(Name = "Phone Number")] 
        public string MainPhone { get; set; }

        //Navigation
        
        public State State { get; set; }
       public Company Company { get; set; }
    }
}
