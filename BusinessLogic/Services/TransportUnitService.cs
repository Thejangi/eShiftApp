using System;
using System.Collections.Generic;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Implements ITransportUnitService, deferring persistence to ITransportUnitRepository.
    /// </summary>
    public class TransportUnitService : ITransportUnitService
    {
        private readonly ITransportUnitRepository _repo;

        public TransportUnitService()
        {
            _repo = new TransportUnitRepository();
        }

        public void Create(TransportUnit unit)
        {
            _repo.Add(unit);
        }

        public void Update(TransportUnit unit)
        {
            _repo.Update(unit);
        }

        public void Delete(int unitId)
        {
            _repo.Delete(unitId);
        }

        public TransportUnit GetById(int unitId)
        {
            return _repo.GetById(unitId);
        }

        public IEnumerable<TransportUnit> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
