using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShiftApp
{
    /// <summary>
    /// Global pub/sub for “data changed” notifications.
    /// Any view or control can subscribe to DataChanged,
    /// and any CRUD handler can call OnDataChanged().
    /// </summary>
    public static class AppEvents
    {
        public static event Action DataChanged;
        public static void OnDataChanged() => DataChanged?.Invoke();
    }
}
