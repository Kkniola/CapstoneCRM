using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapstoneSalesCRM.Models;

namespace CapstoneSalesCRM.Data
{
    public class CapstoneSalesCRMContext : DbContext
    {
        public CapstoneSalesCRMContext (DbContextOptions<CapstoneSalesCRMContext> options)
            : base(options)
        {
        }

        public DbSet<CapstoneSalesCRM.Models.Contact> Contact { get; set; }

        public DbSet<CapstoneSalesCRM.Models.Company> Company { get; set; }

        public DbSet<CapstoneSalesCRM.Models.Role> Role { get; set; }

        public DbSet<CapstoneSalesCRM.Models.Source> Source { get; set; }

        public DbSet<CapstoneSalesCRM.Models.Activity> Activity { get; set; }

        public DbSet<CapstoneSalesCRM.Models.ActivityTask> ActivityTask { get; set; }

        public DbSet<CapstoneSalesCRM.Models.ContactType> ContactType { get; set; }

        public DbSet<CapstoneSalesCRM.Models.Industry> Industry { get; set; }

        public DbSet<CapstoneSalesCRM.Models.Location> Location { get; set; }

        public DbSet<CapstoneSalesCRM.Models.State> State { get; set; }
    }
}
