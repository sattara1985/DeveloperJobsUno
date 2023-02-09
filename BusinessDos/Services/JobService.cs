using BusinessDos.Entities;
using BusinessDos.Interfaces.Services;
using System.Collections.Generic;

namespace BusinessDos.Services
{
    public class JobService : IJobService
    {
        public new  List<Job> GetJobs()
        {
            return new List<Job> 
            { 
                new Job{IdJob = 1, JobTitle = "test job 1"},
                new Job{IdJob = 2, JobTitle = "test job 2"}
            };
            
        }
    }
}
