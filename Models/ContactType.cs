using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class ContactType
    {
        [Display(Name = "Contact Type ID")] 
        public string ContactTypeID { get; set; }
        [Display(Name = "Contact Type")] 
        public string ContactTypeDescription { get; set; }
    
        //public ICollection<Contact> Contacts { get; set; }
    }

}
