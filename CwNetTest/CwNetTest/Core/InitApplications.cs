using Ranorex;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace CwNetTest.Core
    {
    public class InitApplications : Settings
        {
        private IList<int> apps = new List<int>();        

        [BeforeScenario]
        public  void BeforeScenario()
            {
            
          //  string timeStamp = string.Concat(System.DateTime.Now.Year.ToString(), System.DateTime.Now.Month.ToString(), System.DateTime.Now.Day.ToString(), "_", System.DateTime.Now.Hour, "-", System.DateTime.Now.Minute);
          //  string reportLocation = ReportSettings.ReportsLocation;
           // if (!Directory.Exists(reportLocation)) Directory.CreateDirectory(reportLocation);
           // TestReport.Setup(ReportLevel.Info, @reportLocation + @"\Report_" + timeStamp + ".rxlog", true);
            apps.Add(Host.Local.RunApplication(string.Format("{0}{1}", CWNSetup.ServiceLocation, CWNSetup.ServiceApp), null, CWNSetup.ServiceLocation));
            apps.Add(Host.Local.RunApplication(string.Format("{0}{1}", CWNSetup.ClientLocation, CWNSetup.ClientApp), null, CWNSetup.ClientLocation));

            Delay.Duration(15000);
            }

        [AfterScenario]
        public void AfterScenario()
            {
            foreach (var app in apps.OrderByDescending(_ => _))
                Host.Local.CloseApplication(app);
            }
        }
    }
