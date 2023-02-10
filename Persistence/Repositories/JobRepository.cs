
using System;
using System.Collections.Generic;
using BusinessDos.Entities;
using BusinessDos.Interfaces.Repositories;

namespace Persistence.Repositories
{

    public class JobRepository :IJobRepository
    {
        private readonly DeveloperJobsDbContext _context;

        public JobRepository(DeveloperJobsDbContext context)
        {
            _context = context;
        }

        public List<Job> GetJobs()
        {
            return new List<Job>
            {
                new Job{IdJob = 1, JobTitle = "test job 1"},
                new Job{IdJob = 2, JobTitle = "test job 2"}
            };
        }

        public Job CreateJob(Job job)
        {
            _context.AddAsync(job);
            _context.SaveChangesAsync();
            return job;
        }
    }
}
