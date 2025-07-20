using System;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// Business operations around Admin: registration, authentication, 
    /// and full CRUD.
    /// </summary>
    public interface IAdminService
    {
        /// <summary>Registers a new admin 
        /// (hashes password, stores record).
        /// </summary>
        void Register(Admin admin, string plainTextPassword);

        /// <summary>
        /// Attempts login; returns the authenticated 
        /// Admin or null if invalid.
        /// </summary>
        Admin Login(string username, string plainTextPassword);

        /// <summary>
        /// Returns all admins.
        /// </summary>
        IEnumerable<Admin> GetAll();

        /// <summary>
        /// Returns one admin by ID (null if not found).
        /// </summary>
        Admin GetById(int adminId);

        /// <summary>
        /// Updates an existing admin; 
        /// re-hashes password if provided.
        /// </summary>
        void Update(Admin admin, string plainTextPassword = null);

        /// <summary>
        /// Deletes the admin with the given ID.
        /// </summary>
        void Delete(int adminId);

    }
}
