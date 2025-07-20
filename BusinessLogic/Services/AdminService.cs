using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System.Security.Cryptography;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Implements IAdminService: registration, authentication, and full CRUD operations.
    /// </summary>
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repo;

        public AdminService()
        {
            _repo = new AdminRepository();
        }

        /// <summary>
        /// Registers a new admin (hashes password before storing).
        /// </summary>
        public void Register(Admin admin, string plainTextPassword)
        {
            admin.PasswordHash = HashPassword(plainTextPassword);
            _repo.Add(admin);
        }

        /// <summary>
        /// Attempts login; returns the authenticated Admin or null if invalid.
        /// </summary>
        public Admin Login(string username, string plainTextPassword)
        {
            var admin = _repo.GetAll()
                .FirstOrDefault(a => a.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (admin == null)
                return null;

            return VerifyPassword(plainTextPassword, admin.PasswordHash)
                ? admin
                : null;
        }

        /// <summary>
        /// Retrieves all admin accounts.
        /// </summary>
        public IEnumerable<Admin> GetAll() => _repo.GetAll();

        /// <summary>
        /// Retrieves a single Admin by its ID.
        /// </summary>
        public Admin GetById(int adminId) => _repo.GetById(adminId);

        /// <summary>
        /// Updates an existing admin; re-hashes password if provided.
        /// </summary>
        public void Update(Admin admin, string plainTextPassword = null)
        {
            if (!string.IsNullOrEmpty(plainTextPassword))
                admin.PasswordHash = HashPassword(plainTextPassword);

            _repo.Update(admin);
        }

        /// <summary>
        /// Deletes the admin with the given ID.
        /// </summary>
        public void Delete(int adminId) => _repo.Delete(adminId);

        // -------------------------------------------------
        // Private helpers for password hashing and checking
        // -------------------------------------------------
        private byte[] HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
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
