using BusinessDos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDos.Interfaces.Services
{
    public interface ICandidateService
    {
        List<Candidate> GetCandidates();

    }
}
