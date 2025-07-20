using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    /// <summary>
    /// CRUD operations for Customer entities.
    /// </summary>
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
        Customer GetById(int customerId);
        IEnumerable<Customer> GetAll();
    }
}
