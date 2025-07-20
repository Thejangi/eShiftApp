using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Business operations around JobLoad: CRUD and lookup.
    /// </summary>
    public interface IJobLoadService
    {
        /// <summary>Returns all JobLoad records.</summary>
        IEnumerable<JobLoad> GetAll();

        /// <summary>Fetch a single JobLoad by its ID (null if missing).</summary>
        JobLoad GetById(int jobLoadId);

        /// <summary>Creates a new JobLoad record.</summary>
        void Create(JobLoad load);

        /// <summary>Updates an existing JobLoad.</summary>
        void Update(JobLoad load);

        /// <summary>Deletes the JobLoad with the given ID.</summary>
        void Delete(int jobLoadId);
    }
}
