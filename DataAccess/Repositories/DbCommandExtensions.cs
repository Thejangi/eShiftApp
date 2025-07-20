using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess.Repositories
{
    // <summary>
    /// Extension methods to simplify adding parameters to any IDbCommand.
    /// </summary>
    internal static class DbCommandExtensions
    {
        public static void AddParameter(this IDbCommand cmd, string name, object value)
        {
            var p = cmd.CreateParameter();
            p.ParameterName = name;
            p.Value = value ?? DBNull.Value;
            cmd.Parameters.Add(p);
        }
    }
}
