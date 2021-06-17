using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class Source
    {
        [Display(Name = "Source ID")] 
        public int SourceID { get; set; }
        [Display(Name = "Description")] 
        public string SourceDescription { get; set; }

        //navigation //ICollection deals with larger areas that relate to multiple tables
        public ICollection<Contact> Contacts { get; set; }
    }
}
