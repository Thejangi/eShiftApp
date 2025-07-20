using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Business operations around Customer: registration, authentication, lookup.
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// Registers a new customer (hashes password, stores record).
        /// </summary>
        void Register(Customer customer, string plainTextPassword);

        /// <summary>
        /// Attempts login; returns the authenticated Customer or null if invalid.
        /// </summary>
        Customer Login(string email, string plainTextPassword);

        /// <summary>
        /// Retrieves a customer by ID (null if not found).
        /// </summary>
        Customer GetById(int customerId);

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        IEnumerable<Customer> GetAll();

        /// <summary>
        /// Updates an existing customer; if plainTextPassword is non-null/non-empty, re-hashes it.
        /// </summary>
        void Update(Customer customer, string plainTextPassword = null);

        /// <summary>
        /// Deletes the customer with the given ID.
        /// </summary>
        void Delete(int customerId);

    }
}
