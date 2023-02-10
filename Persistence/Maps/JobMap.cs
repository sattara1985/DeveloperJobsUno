using BusinessDos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Persistence.Maps
{
    public class JobMap : IEntityTypeConfiguration<Job>
    { 
        public void Configure(EntityTypeBuilder<Job>builder)
        {
            builder.HasKey(x=> x.IdJob);//llave primaria
            builder.Property(x => x.JobTitle)
                //.HasMaxLength(200) determinar tamaño maximo en bd datos
                .IsRequired();
        }
    }
}
