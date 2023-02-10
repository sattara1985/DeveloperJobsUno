using BusinessDos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDos.Interfaces.Repositories
{
    public interface IJobRepository
    {
        List<Job> GetJobs();
        Job CreateJob(Job job);
    }
}
