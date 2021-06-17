using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class State
    {
        [Display(Name = "State ID")] 
        public string StateID { get; set; }
        [Display(Name = "State")] 
        public string StateName { get; set; }
    public ICollection<Contact> Contacts { get; set; }
    public ICollection<Location> Locations { get; set; }
    }
}



