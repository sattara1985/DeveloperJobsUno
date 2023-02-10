using BusinessDos.Entities;
using System.Collections.Generic;
using BusinessDos.Services;


namespace BusinessDos.Interfaces.Services
{
    public interface IJobService
    {
        List<Job> GetJobs();
        Job CreateJob(Job job);
    }
}
