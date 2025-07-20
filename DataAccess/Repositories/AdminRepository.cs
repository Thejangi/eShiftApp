using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    /// <summary>
    /// ADO.NET implementation of IAdminRepository for MySQL.
    /// </summary>
    public class AdminRepository : IAdminRepository
    {
        public void Add(Admin admin)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO Admin (Username, Email, PasswordHash)
                        VALUES (@Username, @Email, @PasswordHash);
                        SELECT LAST_INSERT_ID();";
                    cmd.AddParameter("@Username", admin.Username);
                    cmd.AddParameter("@Email", admin.Email);
                    cmd.AddParameter("@PasswordHash", admin.PasswordHash);

                    admin.AdminId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void Update(Admin admin)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        UPDATE Admin
                           SET Username     = @Username,
                               Email        = @Email,
                               PasswordHash = @PasswordHash
                         WHERE AdminId      = @Id;";
                    cmd.AddParameter("@Username", admin.Username);
                    cmd.AddParameter("@Email", admin.Email);
                    cmd.AddParameter("@PasswordHash", admin.PasswordHash);
                    cmd.AddParameter("@Id", admin.AdminId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Signature matches IAdminRepository.Delete(int)
        public void Delete(int adminId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Admin WHERE AdminId = @Id;";
                    cmd.AddParameter("@Id", adminId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Admin GetById(int adminId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT AdminId, Username, Email, PasswordHash
                          FROM Admin
                         WHERE AdminId = @Id;";
                    cmd.AddParameter("@Id", adminId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        int idOrd = reader.GetOrdinal("AdminId");
                        int userOrd = reader.GetOrdinal("Username");
                        int emailOrd = reader.GetOrdinal("Email");

                        return new Admin
                        {
                            AdminId = reader.GetInt32(idOrd),
                            Username = reader.GetString(userOrd),
                            Email = reader.GetString(emailOrd),
                            PasswordHash = (byte[])reader["PasswordHash"]
                        };
                    }
                }
            }
        }

        public IEnumerable<Admin> GetAll()
        {
            var list = new List<Admin>();

            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT AdminId, Username, Email, PasswordHash
                          FROM Admin;";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idOrd = reader.GetOrdinal("AdminId");
                            int userOrd = reader.GetOrdinal("Username");
                            int emailOrd = reader.GetOrdinal("Email");

                            list.Add(new Admin
                            {
                                AdminId = reader.GetInt32(idOrd),
                                Username = reader.GetString(userOrd),
                                Email = reader.GetString(emailOrd),
                                PasswordHash = (byte[])reader["PasswordHash"]
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
