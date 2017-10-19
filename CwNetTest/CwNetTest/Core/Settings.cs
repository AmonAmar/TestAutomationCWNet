using CwNetTest.Interfaces;
using System.Configuration;
using System.Xml.Serialization;

namespace CwNetTest.Core
    {
  public class Settings : ISettings
        {
        private const string CWNSetupName = "CWNSetup";
        private const string RepSettings = "ReportSettings";

        ICWNSetup _CWN;
        [XmlIgnore]
        public ICWNSetup CWNSetup
            {
            get
                {
                if (_CWN == null)
                    {
                    try
                        {
                        ConfigurationManager.RefreshSection(CWNSetupName);
                        _CWN = (ICWNSetup)ConfigurationManager.GetSection(CWNSetupName);
                        }
                    catch
                        {
                        throw;
                        }
                    }
                return _CWN;
                }
            }

        IReportSettings _reportSettings;
        [XmlIgnore]
        public IReportSettings ReportSettings
            {
            get
                {
                if (_reportSettings == null)
                    {
                    try
                        {
                        ConfigurationManager.RefreshSection(RepSettings);
                        _reportSettings = (IReportSettings)ConfigurationManager.GetSection(RepSettings);
                        }
                    catch
                        {
                        throw;
                        }
                    }
                return _reportSettings;
                }
            }
        }

    public class CWNSetup : ICWNSetup
        {
        public string ClientApp { get; set; }

        public string ClientLocation { get; set; }

        public string ClientSEP { get; set; }

        public string ClientSEPLocation { get; set; }

        public string ExportDir { get; set; }

        public string ImportDir { get; set; }

        public string RefDir { get; set; }

        public string ServiceApp { get; set; }

        public string ServiceLocation { get; set; }

        public string ServiceSEP { get; set; }

        public string ServiceSEPLocation { get; set; }

        public string TestDir { get; set; }
        }

    public class ReportSettings : IReportSettings
        {
        public string ListRecepients { get; set; }
        public string ReportsLocation { get; set; }
        }
    }
    
