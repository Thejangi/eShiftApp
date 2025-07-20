using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    /// <summary>
    /// A single transport operation for a customer.
    /// </summary>
    public class Job
    {
        public int JobId { get; set; }              // Primary key
        public int CustomerId { get; set; }         // FK to Customer.CustomerId
        public JobStatus Status { get; set; }       // Pending, Accepted, Rejected, etc
        public DateTime CreatedDate { get; set; }   // Timestamp of request
        public Customer Customer { get; set; }      // navigation property (requires ORM)
    }

    /// <summary>
    /// Possible states for a transport job.
    /// </summary>
    
    public enum JobStatus
    {
        Pending,
        Accepted,
        Rejected,
        InProgress,
        Completed
    }
}
