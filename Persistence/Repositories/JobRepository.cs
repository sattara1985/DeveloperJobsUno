
using System;
using System.Collections.Generic;
using BusinessDos.Entities;
using BusinessDos.Interfaces.Repositories;

namespace Persistence.Repositories
{
    public class JobRepository :IJobRepository
        {
        public List<Job> GetJobs()
        {
            return new List<Job>
            {
                new Job{IdJob = 1, JobTitle = "test job 1"},
                new Job{IdJob = 2, JobTitle = "test job 2"}
            };
        }
    }
}
