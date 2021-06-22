using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;

namespace CapstoneSalesCRM.Pages.Locations
{
    public class CreateModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public CreateModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyID"] = new SelectList(_context.Company, "CompanyID", "CompanyName");
        ViewData["StateID"] = new SelectList(_context.Set<State>(), "StateID", "StateName");
            return Page();
        }

        [BindProperty]
        public Location Location { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Location.Add(Location);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
