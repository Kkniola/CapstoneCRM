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

namespace CapstoneSalesCRM.Pages.Contacts
{
    public class EditModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public EditModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contact Contact { get; set; }
        public List<Location> Locations { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contact
                .Include(c => c.Location)
                .Include(c => c.Role)
                .Include(c => c.State)
                .Include(c => c.Source).FirstOrDefaultAsync(m => m.ContactID == id);

            Locations = await _context.Location
                .Include(c => c.Company)
                .ToListAsync();

            Contact.Company = Locations.FirstOrDefault(l => l.LocationID == Contact.LocationID).Company;

            if (Contact == null)
            {
                return NotFound();
            }
           ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationName");
           ViewData["RoleID"] = new SelectList(_context.Role, "RoleID", "RoleDescription");
           ViewData["StateID"] = new SelectList(_context.State, "StateID", "StateName");
            ViewData["SourceID"] = new SelectList(_context.Source, "SourceID", "SourceDescription");
            ViewData["CompanyName"] = new SelectList(_context.Company, "CompanyName", "CompanyName");
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

            _context.Attach(Contact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(Contact.ContactID))
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

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.ContactID == id);
        }
    }
}
