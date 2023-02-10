using BusinessDos.Entities;
using BusinessDos.Interfaces.Repositories;
using BusinessDos.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace BusinessDos.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService (IJobRepository jobRepository) 
        {
            _jobRepository = jobRepository;
        }
        public List<Job> GetJobs()
        {
            return _jobRepository.GetJobs();

        }

        public Job CreateJob(Job job)
        {
            return _jobRepository.CreateJob(job);
        }

    }
}
