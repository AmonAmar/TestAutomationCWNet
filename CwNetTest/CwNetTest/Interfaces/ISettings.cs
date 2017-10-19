using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.Interfaces
    {
   public interface ISettings
        {
        ICWNSetup CWNSetup { get; }
        IReportSettings ReportSettings { get; }
        }
    }
