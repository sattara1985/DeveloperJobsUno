using BusinessDos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Maps
{
    public class JobMap : IEntityTypeConfiguration<Job>
    { 
        public void Configure(EntityTypeBuilder<Job>builder)
        {
            builder.Property(t => t.JobTitle)
                
                .IsRequired();
        }
    }
}
