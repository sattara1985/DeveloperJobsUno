using BusinessDos.Interfaces.Services;
using BusinessDos.Services;
using Microsoft.Extensions.DependencyInjection;


namespace BusinessDos
{
    public static class BusinessDependencyInjection
    {
        public static IServiceCollection AddBusinessRegistrations(this IServiceCollection services)
        {
            services.AddTransient<IJobService, JobService>();
            services.AddTransient<ICandidateService, CandidateService>();
            return services;
        }
    }

}
