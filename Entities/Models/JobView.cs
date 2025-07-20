using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    /// <summary>
    /// Flattened view of Job + its Customer name, for data‐grid binding.
    /// </summary>
    public class JobView
    {
        public int JobId { get; set; }
        public JobStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Customer { get; set; }
    }
}
