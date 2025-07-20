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
    /// ADO.NET implementation of ITransportUnitRepository for MySQL.
    /// </summary>
    public class TransportUnitRepository : ITransportUnitRepository
    {
        public void Add(TransportUnit unit)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO TransportUnit
                          (LorryPlate, DriverName, AssistantName, ContainerId)
                        VALUES
                          (@LorryPlate, @DriverName, @AssistantName, @ContainerId);
                        SELECT LAST_INSERT_ID();";

                    cmd.AddParameter("@LorryPlate", unit.LorryPlate);
                    cmd.AddParameter("@DriverName", unit.DriverName);
                    cmd.AddParameter("@AssistantName", unit.AssistantName);
                    cmd.AddParameter("@ContainerId", unit.ContainerId);

                    unit.UnitId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void Update(TransportUnit unit)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        UPDATE TransportUnit
                           SET LorryPlate    = @LorryPlate,
                               DriverName    = @DriverName,
                               AssistantName = @AssistantName,
                               ContainerId   = @ContainerId
                         WHERE UnitId        = @Id;";

                    cmd.AddParameter("@LorryPlate", unit.LorryPlate);
                    cmd.AddParameter("@DriverName", unit.DriverName);
                    cmd.AddParameter("@AssistantName", unit.AssistantName);
                    cmd.AddParameter("@ContainerId", unit.ContainerId);
                    cmd.AddParameter("@Id", unit.UnitId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int unitId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM TransportUnit WHERE UnitId = @Id;";
                    cmd.AddParameter("@Id", unitId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public TransportUnit GetById(int unitId)
        {
            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT UnitId, LorryPlate, DriverName,
                               AssistantName, ContainerId
                          FROM TransportUnit
                         WHERE UnitId = @Id;";
                    cmd.AddParameter("@Id", unitId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        int idOrd = reader.GetOrdinal("UnitId");
                        int lorryOrd = reader.GetOrdinal("LorryPlate");
                        int driverOrd = reader.GetOrdinal("DriverName");
                        int assistOrd = reader.GetOrdinal("AssistantName");
                        int contOrd = reader.GetOrdinal("ContainerId");

                        return new TransportUnit
                        {
                            UnitId = reader.GetInt32(idOrd),
                            LorryPlate = reader.GetString(lorryOrd),
                            DriverName = reader.GetString(driverOrd),
                            AssistantName = reader.IsDBNull(assistOrd)
                                                ? null
                                                : reader.GetString(assistOrd),
                            ContainerId = reader.GetString(contOrd)
                        };
                    }
                }
            }
        }

        public IEnumerable<TransportUnit> GetAll()
        {
            var list = new List<TransportUnit>();

            using (var conn = DbConnectionFactory.Create())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT UnitId, LorryPlate, DriverName,
                               AssistantName, ContainerId
                          FROM TransportUnit;";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idOrd = reader.GetOrdinal("UnitId");
                            int lorryOrd = reader.GetOrdinal("LorryPlate");
                            int driverOrd = reader.GetOrdinal("DriverName");
                            int assistOrd = reader.GetOrdinal("AssistantName");
                            int contOrd = reader.GetOrdinal("ContainerId");

                            list.Add(new TransportUnit
                            {
                                UnitId = reader.GetInt32(idOrd),
                                LorryPlate = reader.GetString(lorryOrd),
                                DriverName = reader.GetString(driverOrd),
                                AssistantName = reader.IsDBNull(assistOrd)
                                                    ? null
                                                    : reader.GetString(assistOrd),
                                ContainerId = reader.GetString(contOrd)
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
