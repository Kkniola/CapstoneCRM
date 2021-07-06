using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class Role
    {
        [Display(Name = "Role")] 
        public int RoleID { get; set; }
        [Display(Name = "Description")] 
        public string RoleDescription { get; set; }

        public ICollection<Contact> Contacts { get; set; }

    }
}
