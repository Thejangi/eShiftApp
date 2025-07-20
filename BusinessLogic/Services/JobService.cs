using System;
using System.Collections.Generic;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Implements IJobService, deferring persistence to IJobRepository.
    /// </summary>
    public class JobService : IJobService
    {
        private readonly IJobRepository _repo;

        public JobService()
        {
            _repo = new JobRepository();
        }

        public void Create(Job job)
        {
            // Potential business-rule checks could go here
            _repo.Add(job);
        }

        public void Update(Job job)
        {
            // e.g. validate status transitions
            _repo.Update(job);
        }

        public void Delete(int jobId)
        {
            _repo.Delete(jobId);
        }

        public Job GetById(int jobId)
        {
            return _repo.GetById(jobId);
        }

        public IEnumerable<Job> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
