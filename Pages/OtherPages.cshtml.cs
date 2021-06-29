using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CapstoneSalesCRM.Pages
{
    //[Authorize(Roles = "Administrator")]
    public class OtherPagesModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
