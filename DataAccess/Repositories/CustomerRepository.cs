using System;
using System.Collections.Generic;
using System.Data;
using Entities.Models;
using DataAccess.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    /// <summary>
    /// ADO.NET implementation of ICustomerRepository for MySQL.
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// Inserts a new Customer record and assigns its generated ID.
        /// </summary>
        public void Add(Customer customer)
        {
            // Acquire a configured connection from the factory
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();  // Open the database connection

                using (var cmd = conn.CreateCommand())
                {
                    // Parameterized INSERT statement to prevent SQL injection
                    cmd.CommandText = @"
                        INSERT INTO Customer (Name, Email, PasswordHash)
                        VALUES (@Name, @Email, @PasswordHash);
                        SELECT LAST_INSERT_ID();";

                    // Bind property values to SQL parameters
                    cmd.AddParameter("@Name", customer.Name);
                    cmd.AddParameter("@Email", customer.Email);
                    cmd.AddParameter("@PasswordHash", customer.PasswordHash);

                    // ExecuteScalar returns the new auto-increment key
                    customer.CustomerId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Updates an existing Customer record identified by CustomerId.
        /// </summary>
        public void Update(Customer customer)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    // Parameterized UPDATE statement
                    cmd.CommandText = @"
                        UPDATE Customer
                           SET Name         = @Name,
                               Email        = @Email,
                               PasswordHash = @PasswordHash
                         WHERE CustomerId   = @Id;";

                    cmd.AddParameter("@Name", customer.Name);
                    cmd.AddParameter("@Email", customer.Email);
                    cmd.AddParameter("@PasswordHash", customer.PasswordHash);
                    cmd.AddParameter("@Id", customer.CustomerId);

                    cmd.ExecuteNonQuery();  // Execute update
                }
            }
        }

        /// <summary>
        /// Deletes the Customer record with the specified ID.
        /// </summary>
        public void Delete(int customerId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    // DELETE statement with parameter for safety
                    cmd.CommandText = "DELETE FROM Customer WHERE CustomerId = @Id;";
                    cmd.AddParameter("@Id", customerId);
                    cmd.ExecuteNonQuery();  // Execute deletion
                }
            }
        }

        /// <summary>
        /// Retrieves a single Customer by its ID, or null if not found.
        /// </summary>
        public Customer GetById(int customerId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    // SELECT statement to fetch one record
                    cmd.CommandText = @"
                        SELECT CustomerId, Name, Email, PasswordHash
                          FROM Customer
                         WHERE CustomerId = @Id;";
                    cmd.AddParameter("@Id", customerId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;  // No matching record
                        }

                        // Determine ordinal for each column once
                        int idOrd = reader.GetOrdinal("CustomerId");
                        int nameOrd = reader.GetOrdinal("Name");
                        int emailOrd = reader.GetOrdinal("Email");

                        // Map columns to object properties
                        return new Customer
                        {
                            CustomerId = reader.GetInt32(idOrd),
                            Name = reader.GetString(nameOrd),
                            Email = reader.GetString(emailOrd),
                            PasswordHash = (byte[])reader["PasswordHash"]
                        };
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves all Customer records as a list.
        /// </summary>
        public IEnumerable<Customer> GetAll()
        {
            var list = new List<Customer>();

            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    // SELECT statement to fetch all records
                    cmd.CommandText = @"
                        SELECT CustomerId, Name, Email, PasswordHash
                          FROM Customer;";

                    using (var reader = cmd.ExecuteReader())
                    {
                        // Read each row and map to a new Customer object
                        while (reader.Read())
                        {
                            int idOrd = reader.GetOrdinal("CustomerId");
                            int nameOrd = reader.GetOrdinal("Name");
                            int emailOrd = reader.GetOrdinal("Email");

                            list.Add(new Customer
                            {
                                CustomerId = reader.GetInt32(idOrd),
                                Name = reader.GetString(nameOrd),
                                Email = reader.GetString(emailOrd),
                                PasswordHash = (byte[])reader["PasswordHash"]
                            });
                        }
                    }
                }
            }

            return list;  // Return the list of Customers
        }
    }
}
