using BusinessDos.Entities;
using BusinessDos.Interfaces.Services;
using System.Collections.Generic;

namespace BusinessDos.Services
{
    public class CandidateService : ICandidateService
    {
        public List<Candidate> GetCandidates()
        {
            return new List<Candidate>
            {
                new Candidate{IdCandidate = 1, Email = "tsdhjds@yahoo.es"},
                new Candidate{IdCandidate = 2, Email = "dkfjdkfj@dsdsd.com.co.co"}
            };
        }

    }
}
