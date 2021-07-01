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
    public class IndexModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public IndexModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }
        public IList<Location> Locations{ get; set; }

        public async Task OnGetAsync()
        {

            Contact = await _context.Contact
                .Include(c => c.Location)
                .Include(c => c.Role)
                .Include(c => c.State).ToListAsync();

            Locations = await _context.Location
                .Include(c => c.Company)
                .ToListAsync();
            
            foreach(Contact contact in Contact)
            {
                contact.Company = Locations.FirstOrDefault(l => l.LocationID == contact.LocationID).Company;
            }
                
        }
    }
}
