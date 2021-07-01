using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;

namespace CapstoneSalesCRM.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public DetailsModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        //public Activity Activities { get; set; }
        
        public List<Activity> Activity { get; set; }
        public IList<Location> Locations { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contact
                .Include(c => c.Location)
                .Include(c => c.Role)
                .Include(c => c.State).FirstOrDefaultAsync(m => m.ContactID == id);

            Activity = await _context.Activity
                .Include(c => c.ActivityTask)
                .Where(m => m.ContactID == id)
                .ToListAsync();

            Locations = await _context.Location
                .Include(c => c.Company)
                .ToListAsync();

                Contact.Company = Locations.FirstOrDefault(l => l.LocationID == Contact.LocationID).Company;
          

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
