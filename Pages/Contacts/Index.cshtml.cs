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
    public class IndexModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public IndexModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get; set; }

        public string ContIDSort { get; set; }
        public string LNameSort { get; set; }
        public string FNameSort { get; set; }
        public string CurrentFilter { get; set; }


        public IList<Location> Locations { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            //Moved to bottom to include in other "await"
            //Contact = await _context.Contact
            //.Include(c => c.Location)
            //.Include(c => c.Role)
            //.Include(c => c.State)
            //.OrderBy(c => c.LastName)
            //.ToListAsync();


            ContIDSort = String.IsNullOrEmpty(sortOrder) ? "Cont_ID" : "";
            LNameSort = sortOrder == "LName_Asc_Sort" ? " LName_Desc_Sort" : " LName_Asc_Sort";
            FNameSort = sortOrder == "FName_Asc_Sort" ? " FName_Desc_Sort" : " FName_Asc_Sort";
            CurrentFilter = searchString;

            IQueryable<Contact> cont = from s in _context.Contact select s;

            if (!String.IsNullOrEmpty(searchString))
                cont = cont.Where(s => s.LastName.Contains(searchString) || s.FirstName.Contains(searchString));
            switch (sortOrder)
            {
                case "Cont_ID":
                    cont = cont.OrderByDescending(s => s.ContactID);
                    break;
                case " LName_Asc_Sort":
                    cont = cont.OrderBy(s => s.LastName);
                    break;
                case " LName_Desc_Sort":
                    cont = cont.OrderByDescending(s => s.LastName);
                    break;
                case " FName_Asc_Sort":
                    cont = cont.OrderBy(s => s.FirstName);
                    break;
                case " FName_Desc_Sort":
                    cont = cont.OrderByDescending(s => s.FirstName);
                    break;
                default:
                    cont = cont.OrderBy(s => s.ContactID);
                    break;
            }
            Contact = await cont.AsNoTracking()
            .Include(c => c.Location)
            .Include(c => c.Role)
            .Include(c => c.State)
            .OrderBy(c => c.LastName)
            .ToListAsync();

            Locations = await _context.Location
              .Include(c => c.Company)
              .ToListAsync();

            foreach (Contact contact in Contact)
            {
                contact.Company = Locations.FirstOrDefault(l => l.LocationID == contact.LocationID).Company;
            }

        }
    }
}

