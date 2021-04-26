using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimeOffManagement.Models;

namespace TimeOffManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Entity Framework Functions
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeOffType> TimeOffTypes { get; set; }
        public DbSet<TimeOffAllocation> TimeOffAllocations { get; set; }
        public DbSet<TimeOffHistory> TimeOffHistories { get; set; }
        public DbSet<TimeOffManagement.Models.TimeOffTypeVM> DetailsTimeOffTypeVM { get; set; }

    }
}
