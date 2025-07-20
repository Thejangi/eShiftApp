using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    /// <summary>
    /// CRUD operations for Job entities.
    /// </summary>
    public interface IJobRepository
    {
        void Add(Job job);
        void Update(Job job);
        void Delete(int jobId);
        Job GetById(int jobId);
        IEnumerable<Job> GetAll();
    }
}
