using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public class Industry
    {
        [Display(Name = "Industry ID")] 
        public int IndustryID { get; set; }
        [Display(Name = "Industry Description")] 
        public string Description { get; set; }

        public ICollection<Company> Companies{ get; set; }
    }
}
