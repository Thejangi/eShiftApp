using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace DataAccess.Interfaces
{
    /// <summary>
    /// CRUD operations for JobLoad entities.
    /// </summary>
    public interface IJobLoadRepository
    {
        void Add(JobLoad jobLoad);
        void Update(JobLoad jobLoad);
        void Delete(int jobLoadId);
        JobLoad GetById(int jobLoadId);
        IEnumerable<JobLoad> GetAll();
    }
}
