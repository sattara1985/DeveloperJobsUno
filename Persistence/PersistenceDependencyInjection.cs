using BusinessDos.Interfaces.Repositories;
using BusinessDos.Interfaces.Services;
using BusinessDos.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public static class PersistenceDependencyInjection
    {
        public static IServiceCollection AddPersistenceRegistrations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DeveloperJobsDbContext>(optionsAction: options =>
            options.UseSqlServer(configuration.GetConnectionString(name: "DefaultConnection")));
            services.AddTransient<IJobRepository, JobRepository>();
           
            return services;
        }
    }
}
