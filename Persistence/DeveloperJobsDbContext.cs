using BusinessDos.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Persistence
{
    public class DeveloperJobsDbContext: DbContext
    {
        public DeveloperJobsDbContext(DbContextOptions options):base(options) 
        { 
            
        }
        public DbSet<Job>Jobs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

    }
}
