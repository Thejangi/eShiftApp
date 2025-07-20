using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    /// <summary>
    /// ADO.NET implementation of IJobRepository for MySQL.
    /// </summary>
    public class JobRepository : IJobRepository
    {
        public void Add(Job job)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO Job (CustomerId, Status, CreatedDate)
                        VALUES (@CustomerId, @Status, @CreatedDate);
                        SELECT LAST_INSERT_ID();";
                    cmd.AddParameter("@CustomerId", job.CustomerId);
                    cmd.AddParameter("@Status", job.Status.ToString());
                    cmd.AddParameter("@CreatedDate", job.CreatedDate);

                    job.JobId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void Update(Job job)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        UPDATE Job
                           SET CustomerId = @CustomerId,
                               Status     = @Status
                         WHERE JobId      = @Id;";
                    cmd.AddParameter("@CustomerId", job.CustomerId);
                    cmd.AddParameter("@Status", job.Status.ToString());
                    cmd.AddParameter("@Id", job.JobId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int jobId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Job WHERE JobId = @Id;";
                    cmd.AddParameter("@Id", jobId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Job GetById(int jobId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT JobId, CustomerId, Status, CreatedDate
                          FROM Job
                         WHERE JobId = @Id;";
                    cmd.AddParameter("@Id", jobId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        int idOrd = reader.GetOrdinal("JobId");
                        int custOrd = reader.GetOrdinal("CustomerId");
                        int statOrd = reader.GetOrdinal("Status");
                        int dateOrd = reader.GetOrdinal("CreatedDate");

                        return new Job
                        {
                            JobId = reader.GetInt32(idOrd),
                            CustomerId = reader.GetInt32(custOrd),
                            // cast non-generic Enum.Parse to JobStatus
                            Status = (JobStatus)Enum.Parse(
                                              typeof(JobStatus),
                                              reader.GetString(statOrd)
                                          ),
                            CreatedDate = reader.GetDateTime(dateOrd)
                        };
                    }
                }
            }
        }

        public IEnumerable<Job> GetAll()
        {
            var list = new List<Job>();

            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT JobId, CustomerId, Status, CreatedDate
                          FROM Job;";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idOrd = reader.GetOrdinal("JobId");
                            int custOrd = reader.GetOrdinal("CustomerId");
                            int statOrd = reader.GetOrdinal("Status");
                            int dateOrd = reader.GetOrdinal("CreatedDate");

                            list.Add(new Job
                            {
                                JobId = reader.GetInt32(idOrd),
                                CustomerId = reader.GetInt32(custOrd),
                                Status = (JobStatus)Enum.Parse(
                                                  typeof(JobStatus),
                                                  reader.GetString(statOrd)
                                              ),
                                CreatedDate = reader.GetDateTime(dateOrd)
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
