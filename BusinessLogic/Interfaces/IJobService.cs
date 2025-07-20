using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Business operations around Job: creation, updates, deletion, retrieval.
    /// </summary>
    public interface IJobService
    {
        /// <summary>
        /// Retrieves all jobs.
        /// </summary>
        IEnumerable<Job> GetAll();

        /// <summary>
        /// Retrieves a single job by ID (null if not found).
        /// </summary>
        Job GetById(int jobId);

        /// <summary>
        /// Creates a new job.
        /// </summary>
        void Create(Job job);

        /// <summary>
        /// Updates an existing job.
        /// </summary>
        void Update(Job job);

        /// <summary>
        /// Deletes the job with the given ID.
        /// </summary>
        void Delete(int jobId);
    }
}
