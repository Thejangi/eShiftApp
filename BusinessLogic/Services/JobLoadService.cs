using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities.Models;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Implements IJobLoadService by delegating to IJobLoadRepository.
    /// </summary>
    public class JobLoadService : IJobLoadService
    {
        private readonly IJobLoadRepository _repo;

        public JobLoadService()
        {
            _repo = new JobLoadRepository();
        }

        public IEnumerable<JobLoad> GetAll()
            => _repo.GetAll();

        public JobLoad GetById(int jobLoadId)
            => _repo.GetById(jobLoadId);

        public void Create(JobLoad load)
            => _repo.Add(load);

        public void Update(JobLoad load)
            => _repo.Update(load);

        public void Delete(int jobLoadId)
            => _repo.Delete(jobLoadId);
    }
}
