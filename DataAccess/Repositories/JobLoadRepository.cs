using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using DataAccess.Interfaces;
namespace DataAccess.Repositories
{
    /// <summary>
    /// ADO.NET implementation of IJobLoadRepository for MySQL.
    /// </summary>
    public class JobLoadRepository : IJobLoadRepository
    {
        public void Add(JobLoad jobLoad)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new JobLoad and return its generated ID
                    cmd.CommandText = @"
                        INSERT INTO JobLoad 
                          (JobId, UnitId, Weight, Volume, PickupLocation, DropoffLocation)
                        VALUES 
                          (@JobId, @UnitId, @Weight, @Volume, @PickupLocation, @DropoffLocation);
                        SELECT LAST_INSERT_ID();";
                    cmd.AddParameter("@JobId", jobLoad.JobId);
                    cmd.AddParameter("@UnitId", jobLoad.UnitId);
                    cmd.AddParameter("@Weight", jobLoad.Weight);
                    cmd.AddParameter("@Volume", jobLoad.Volume);
                    cmd.AddParameter("@PickupLocation", jobLoad.PickupLocation);
                    cmd.AddParameter("@DropoffLocation", jobLoad.DropoffLocation);

                    jobLoad.JobLoadId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void Update(JobLoad jobLoad)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Update an existing JobLoad by its primary key
                    cmd.CommandText = @"
                        UPDATE JobLoad
                           SET JobId           = @JobId,
                               UnitId          = @UnitId,
                               Weight          = @Weight,
                               Volume          = @Volume,
                               PickupLocation  = @PickupLocation,
                               DropoffLocation = @DropoffLocation
                         WHERE JobLoadId      = @Id;";
                    cmd.AddParameter("@JobId", jobLoad.JobId);
                    cmd.AddParameter("@UnitId", jobLoad.UnitId);
                    cmd.AddParameter("@Weight", jobLoad.Weight);
                    cmd.AddParameter("@Volume", jobLoad.Volume);
                    cmd.AddParameter("@PickupLocation", jobLoad.PickupLocation);
                    cmd.AddParameter("@DropoffLocation", jobLoad.DropoffLocation);
                    cmd.AddParameter("@Id", jobLoad.JobLoadId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int jobLoadId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Remove a JobLoad by its ID
                    cmd.CommandText = "DELETE FROM JobLoad WHERE JobLoadId = @Id;";
                    cmd.AddParameter("@Id", jobLoadId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public JobLoad GetById(int jobLoadId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Fetch a single JobLoad
                    cmd.CommandText = @"
                        SELECT JobLoadId, JobId, UnitId, Weight, Volume,
                               PickupLocation, DropoffLocation
                          FROM JobLoad
                         WHERE JobLoadId = @Id;";
                    cmd.AddParameter("@Id", jobLoadId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        int idOrd = reader.GetOrdinal("JobLoadId");
                        int jobOrd = reader.GetOrdinal("JobId");
                        int unitOrd = reader.GetOrdinal("UnitId");

                        return new JobLoad
                        {
                            JobLoadId = reader.GetInt32(idOrd),
                            JobId = reader.GetInt32(jobOrd),
                            UnitId = reader.GetInt32(unitOrd),
                            Weight = reader.GetDecimal(reader.GetOrdinal("Weight")),
                            Volume = reader.GetDecimal(reader.GetOrdinal("Volume")),
                            PickupLocation = reader.GetString(reader.GetOrdinal("PickupLocation")),
                            DropoffLocation = reader.GetString(reader.GetOrdinal("DropoffLocation"))
                        };
                    }
                }
            }
        }

        public IEnumerable<JobLoad> GetAll()
        {
            var list = new List<JobLoad>();

            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Fetch all JobLoad rows
                    cmd.CommandText = @"
                        SELECT JobLoadId, JobId, UnitId, Weight, Volume,
                               PickupLocation, DropoffLocation
                          FROM JobLoad;";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idOrd = reader.GetOrdinal("JobLoadId");
                            int jobOrd = reader.GetOrdinal("JobId");
                            int unitOrd = reader.GetOrdinal("UnitId");

                            list.Add(new JobLoad
                            {
                                JobLoadId = reader.GetInt32(idOrd),
                                JobId = reader.GetInt32(jobOrd),
                                UnitId = reader.GetInt32(unitOrd),
                                Weight = reader.GetDecimal(reader.GetOrdinal("Weight")),
                                Volume = reader.GetDecimal(reader.GetOrdinal("Volume")),
                                PickupLocation = reader.GetString(reader.GetOrdinal("PickupLocation")),
                                DropoffLocation = reader.GetString(reader.GetOrdinal("DropoffLocation"))
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
