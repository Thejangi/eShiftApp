using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    /// <summary>
    /// The combination of lorry, driver, assistant, and container.
    /// </summary>
    public class TransportUnit
    {
        public int UnitId { get; set; }             // Primary key
        public string LorryPlate { get; set; }      // License plate #
        public string DriverName { get; set; }     
        public string AssistantName { get; set; }
        public string ContainerId { get; set; }     // Internal container iddentifier
    }
}
