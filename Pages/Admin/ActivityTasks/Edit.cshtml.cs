using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;

namespace CapstoneSalesCRM.Pages.ActivityTasks
{
    public class EditModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public EditModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            _context.Attach(ActivityTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityTaskExists(ActivityTask.ActivityTaskID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ActivityTaskExists(int id)
        {
            return _context.ActivityTask.Any(e => e.ActivityTaskID == id);
        }
    }
}
