using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace DataAccess.Interfaces
{
    /// <summary>
    /// CRUD operations for Admin entities.
    /// </summary>
    public interface IAdminRepository
    {
        void Add(Admin admin);
        void Update(Admin admin);
        void Delete(int adminId);
        Admin GetById(int adminId);
        IEnumerable<Admin> GetAll();
    }
}
