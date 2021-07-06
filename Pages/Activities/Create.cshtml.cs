using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;
using System.ComponentModel.DataAnnotations;

namespace CapstoneSalesCRM.Pages.Activities
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
        ViewData["ActivityTaskID"] = new SelectList(_context.ActivityTask, "ActivityTaskID", "TaskDescription");
        ViewData["ContactID"] = new SelectList(_context.Contact, "ContactID", "LastName");
            return Page();
        }

        [BindProperty]
        public Activity Activity { get; set; }



        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Activity.Add(Activity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }

    public class MyDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)// Return a boolean value: true == IsValid, false != IsValid
        {
            DateTime d = Convert.ToDateTime(value);
            return d >= DateTime.Now; //Dates Greater than or equal to today are valid (true)

        }
    }
}
