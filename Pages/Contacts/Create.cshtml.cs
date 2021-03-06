using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;
using Microsoft.EntityFrameworkCore;

namespace CapstoneSalesCRM.Pages.Contacts
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
        ViewData["LocationName"] = new SelectList(_context.Location, "LocationName", "LocationName");
        ViewData["RoleID"] = new SelectList(_context.Role, "RoleID", "RoleDescription");
        ViewData["StateID"] = new SelectList(_context.State, "StateID", "StateName");
        ViewData["SourceID"] = new SelectList(_context.Source, "SourceID", "SourceDescription");

            return Page();
        }

        [BindProperty]
        public Contact Contact { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Contact.LocationID = (await _context.Location
                .ToListAsync()).Where(loc => loc.LocationName == Contact.Location.LocationName).Select(loc => loc.LocationID).FirstOrDefault();

            Contact.Location = null;




            _context.Contact.Add(Contact);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
