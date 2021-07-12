using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;

namespace CapstoneSalesCRM.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public IndexModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }
        public string CompIDSort { get; set; }
        public string CompNameSort { get; set; }
        public string CurrentFilter { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            CompIDSort = String.IsNullOrEmpty(sortOrder) ? "Cont_ID" : "";
            CompNameSort = sortOrder == "CompName_Asc_Sort" ? " CompName_Desc_Sort" : " CompName_Asc_Sort";
            CurrentFilter = searchString;

            IQueryable<Company> comp = from s in _context.Company select s;

            if (!String.IsNullOrEmpty(searchString))
                comp = comp.Where(s => s.CompanyName.Contains(searchString));
            switch (sortOrder)
            {
                case "Comp_ID":
                    comp = comp.OrderByDescending(s => s.CompanyID);
                    break;
                case " CompName_Asc_Sort":
                    comp = comp.OrderBy(s => s.CompanyName);
                    break;
                case " LName_Desc_Sort":
                    comp = comp.OrderByDescending(s => s.CompanyName);
                    break;
                default:
                    comp = comp.OrderBy(s => s.CompanyID);
                    break;
            }
            Company = await comp.AsNoTracking()
                .Include(c => c.Industry)
                .OrderBy(c => c.CompanyName)
                .ToListAsync();
        }
    }
}
