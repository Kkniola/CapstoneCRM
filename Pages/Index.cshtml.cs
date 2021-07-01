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
        public async Task<IActionResult> OnGetAsync()
        {
            ContactUserList = await _db.Contact.Include(c => c.Location).OrderByDescending(c => c.DateCreated).Take(10).ToListAsync();
            ActivityList = await _db.Activity.Include(c => c.ActivityTask).OrderBy(c => c.DateScheduled).Take(10).ToListAsync();
                
            return Page();
        }
    }
}
