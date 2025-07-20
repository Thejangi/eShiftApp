using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace DataAccess.Interfaces
{
    /// <summary>
    /// CRUD operations for TransportUnit entities.
    /// </summary>
    public interface ITransportUnitRepository
    {
        void Add(TransportUnit unit);
        void Update(TransportUnit unit);
        void Delete(int unitId);
        TransportUnit GetById(int unitId);
        IEnumerable<TransportUnit> GetAll();
    }
}
