using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShiftApp
{
    /// <summary>
    /// Implement this on any UserControl that can reload its data.
    /// MainForm will call RefreshData() when showing the view.
    /// </summary>
    public interface IRefreshable
    {
        void RefreshData();
    }
}
