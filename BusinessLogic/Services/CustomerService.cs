using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Implements ICustomerService, encapsulating password hashing
    /// and credential checks, while deferring persistence to repositories.
    /// </summary>
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService()
        {
            _repo = new CustomerRepository();
        }

        public void Register(Customer customer, string plainTextPassword)
        {
            // Hash the password before saving
            customer.PasswordHash = HashPassword(plainTextPassword);
            _repo.Add(customer);
        }

        public Customer Login(string email, string plainTextPassword)
        {
            // Look up by email
            var customer = _repo
                .GetAll()
                .FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            if (customer == null) return null;

            // Verify the hash
            if (VerifyPassword(plainTextPassword, customer.PasswordHash))
                return customer;

            return null;
        }

        public Customer GetById(int customerId)
        {
            return _repo.GetById(customerId);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repo.GetAll();
        }

        public void Update(Customer customer, string plainTextPassword = null)
        {
            // If a new password was provided, re‐hash it; otherwise keep existing hash
            if (!string.IsNullOrEmpty(plainTextPassword))
            {
                customer.PasswordHash = HashPassword(plainTextPassword);
            }
            _repo.Update(customer);
        }

        public void Delete(int customerId)
        {
            _repo.Delete(customerId);
        }

        // -----------------------------
        // Private helpers for hashing
        // -----------------------------

        private byte[] HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPassword(string password, byte[] storedHash)
        {
            var hash = HashPassword(password);
            if (hash.Length != storedHash.Length) return false;
            for (int i = 0; i < hash.Length; i++)
                if (hash[i] != storedHash[i]) return false;
            return true;
        }
    }
}
