// MySql.Data.MySqlClient: MySQL ADO.NET provider (MySqlConnection, MySqlCommand, etc.)
using MySql.Data.MySqlClient;
// System: core types and basic functionality (e.g., String, Console)
using System;
// System.Collections.Generic: generic collection classes (List<T>, Dictionary<TKey, TValue>, etc.)
using System.Collections.Generic;
// System.Configuration: access to configuration files (e.g., App.config)
using System.Configuration;
// System.Data: ADO.NET interfaces (IDbConnection, IDataReader, etc.)
using System.Data;
// System.Linq: LINQ extension methods for querying and manipulating collections
using System.Linq;
// System.Text: classes for handling and manipulating text (StringBuilder, Encoding, etc.)
using System.Text;
// System.Threading.Tasks: support for asynchronous and parallel operations (Task, Task<T>)
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Factory class responsible for creating configured IDbConnection instances
    /// based on the named connection string in the application configuration.
    /// </summary>
    public static class DbConnectionFactory
    {
        /// <summary>
        /// Reads the "eShiftDb" connection string from App.config
        /// and returns a new MySqlConnection initialized with that string.
        /// </summary>
        public static IDbConnection Create()
        {
            // Retrieve the connection-string entry with key "eShiftDb"
            string cs = ConfigurationManager
                .ConnectionStrings["eShiftDb"]
                .ConnectionString;
            // Instantiate and return a MySQL connection using the retrieved string
            return new MySqlConnection (cs);
        }
    }
}
