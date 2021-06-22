using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapstoneSalesCRM.Data;
using CapstoneSalesCRM.Models;

namespace CapstoneSalesCRM.Pages.States
{
    public class IndexModel : PageModel
    {
        private readonly CapstoneSalesCRM.Data.CapstoneSalesCRMContext _context;

        public IndexModel(CapstoneSalesCRM.Data.CapstoneSalesCRMContext context)
        {
            _context = context;
        }

        public IList<State> State { get;set; }

        public async Task OnGetAsync()
        {
            State = await _context.State.ToListAsync();
        }
    }
}
