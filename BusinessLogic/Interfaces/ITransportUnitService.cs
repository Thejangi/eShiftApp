using System;
using System.Collections.Generic;
using Entities.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Business operations around TransportUnit: creation, updates, deletion, retrieval.
    /// </summary>
    public interface ITransportUnitService
    {
        void Create(TransportUnit unit);
        void Update(TransportUnit unit);
        void Delete(int unitId);
        TransportUnit GetById(int unitId);
        IEnumerable<TransportUnit> GetAll();
    }
}
