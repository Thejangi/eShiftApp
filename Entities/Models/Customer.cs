using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    /// <summary>
    /// Represents a registered e-Shift customer.
    /// </summary>
    public class Customer
    {
        public int CustomerId { get; set; }         // Primary key
        public string Name { get; set; }            // Full name
        public string Email { get; set; }           // Must be unique
        public byte[] PasswordHash { get; set; }    // Hashed password
    }
}
