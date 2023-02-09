using BusinessDos.Interfaces.Repositories;
using BusinessDos.Interfaces.Services;
using BusinessDos.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public static class PersistenceDependencyInjection
    {
        public static IServiceCollection AddPersistenceRegistrations(this IServiceCollection services)
        {
            services.AddTransient<IJobRepository, JobRepository>();
           
            return services;
        }
    }
}
