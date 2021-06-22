using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;

namespace CapstoneSalesCRM.Pages.ActivityTasks
{
    public class DetailsModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public DetailsModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        public ActivityTask ActivityTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ActivityTask = await _context.ActivityTask.FirstOrDefaultAsync(m => m.ActivityTaskID == id);

            if (ActivityTask == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
