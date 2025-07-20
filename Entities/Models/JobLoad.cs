using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    /// <summary>
    /// A subset of a Job, representing one container load.
    /// </summary>
    public class JobLoad
    {
        public int JobLoadId { get; set; }             // Primary key
        public int JobId { get; set; }              // FK to Job.JobId
        public int UnitId { get; set; }             // Fk to TransportUnit.UnitId

        public decimal Weight { get; set; }           // Weight in kg
        public decimal Volume { get; set; }           // Volume in m³
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
    }
}
