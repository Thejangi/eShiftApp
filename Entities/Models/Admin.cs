using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    /// <summary>
    /// Represents an administrator with elevated privileges.
    /// </summary>
    public class Admin
    {
        public int AdminId { get; set; }            // Primary key
        public string Username { get; set; }        // Unique login name

        public string Email { get; set; }           // Email Address
        public byte[] PasswordHash { get; set; }    // Hashed Password
    }
}
