using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    /// <summary>
    /// Projection of JobLoad for UI binding, including the unit’s plate.
    /// </summary>
    public class LoadView
    {
        public int JobLoadId { get; set; }
        public int JobId { get; set; }
        public int UnitId { get; set; }
        public string UnitPlate { get; set; }
        public decimal Weight { get; set; }
        public decimal Volume { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
    }
}
