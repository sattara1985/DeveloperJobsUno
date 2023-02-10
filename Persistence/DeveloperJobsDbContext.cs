using BusinessDos.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class DeveloperJobsDbContext: DbContext
    {
        public DeveloperJobsDbContext(DbContextOptions options):base(options) 
        { 
            
        }
        public DbSet<Job>Jobs { get; set; }

    }
}
