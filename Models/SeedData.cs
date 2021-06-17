using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CapstoneSalesCRM.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneSalesCRM.Models
{
    public static class SeedData
    {


        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CapstoneSalesCRMContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CapstoneSalesCRMContext>>()))
            {
                // Look for any movies.
                if (context.State.Any())
                {
                    return;   // DB has been seeded
                }

                context.State.AddRange(
                    new State
                    {
                        StateID = "AL",
                        StateName = "Alabama",

                    },

                    new State
                    {
                        StateID = "AK",
                        StateName = "Alaska",
                    },

                    new State
                    {
                        StateID = "AL",
                        StateName = "Alabama",
                    },

                    new State
                    {
                        StateID = "AZ",
                        StateName = "Arizona",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}