using BusinessDos.Entities;
using BusinessDos.Interfaces.Services;
using BusinessDos.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIUNO.Controllers
{
    [ApiController]
    [Route(template:"[controller]")]
    public class JobsController: ControllerBase
    {
        private readonly IJobService _jobService;
        public JobsController(IJobService jobService) 
        {
            _jobService = jobService;
        }
        public async Task<IActionResult> Get()
        {
            //var jobs:List<Job> = _jobService.GetJobs();
            var jobs = _jobService.GetJobs();
            return  Ok(jobs);
        }
    }
}
