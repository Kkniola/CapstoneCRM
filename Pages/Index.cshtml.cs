using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        //public void OnGet() { }

        private readonly CapstoneSalesCRMContext _db;

        public IndexModel(CapstoneSalesCRMContext db)
        {
            _db = db;
        }

        [BindProperty]
        public List<Contact> ContactUserList { get; set; }
        public List<Activity> ActivityList { get; set; }
        public IList<Location> Locations { get; set; }
        public List<Contact> Contact { get; set; }
        public List<Company> Companies { get; set; }
        public List<Activity> IncompleteActivities { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            ContactUserList = await _db.Contact
                .Include(c => c.Location)
                .Include(c => c.Role)
                .OrderByDescending(c => c.DateCreated)
                .Take(10).ToListAsync();

            Contact = await _db.Contact
                .OrderBy(c => c.DateCreated)
                .ToListAsync();

            Companies = await _db.Company
                .ToListAsync();


            Locations = await _db.Location
              .Include(c => c.Company)
              .ToListAsync();

            IncompleteActivities = await _db.Activity
                .Include(c => c.ActivityTask)
                .Where(c => c.Status == ActivityStatus.Incomplete)
                .ToListAsync();


            ActivityList = await _db.Activity
                .Include(c => c.ActivityTask)
                .Where( c => c.Status == ActivityStatus.Incomplete)
                .Where(c => c.DateScheduled >= DateTime.Now)
                .OrderBy(c => c.DateScheduled)
                .Take(10).ToListAsync();

            //foreach (Contact contact in ContactUserList)
            //{
            //    contact.Company = Locations.FirstOrDefault(l => l.LocationID == contact.LocationID).Company;
            //}


            return Page();
        }
    }
}
