using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.Core
    {
    public class CWNSettings : ICWNSettings
        {
        private string _clientApp;
        private string _clientLocation;
        private string _serviceApp;
        private string _serviceLocation;

        private string _serviceSEP;
        private string _serviceSEPLocation;
        private string _clientSEP;
        private string _clientSEPLocation;

        private string _AppDBServer;
        private string _AppDBName;
        private string _testDir;
        private string _importDir;
        private string _exportDir;
        private string _refDir;

        #region ICWNSettings Members

        public string ServiceSEPLocation
            {
            get { return _serviceSEPLocation; }
            set { _serviceSEPLocation = value; }
            }

        public string ClientSEPLocation
            {
            get { return _clientSEPLocation; }
            set { _clientSEPLocation = value; }
            }


        public string ClientSEP
            {
            get { return _clientSEP; }
            set { _clientSEP = value; }
            }

        public string ServiceSEP
            {
            get { return _serviceSEP; }
            set { _serviceSEP = value; }
            }

        public string ServiceLocation
            {
            get { return _serviceLocation; }
            set { _serviceLocation = value; }
            }

        public string ServiceApp
            {
            get { return _serviceApp; }
            set { _serviceApp = value; }
            }

        public string ClientLocation
            {
            get { return _clientLocation; }
            set { _clientLocation = value; }
            }

        public string ClientApp
            {
            get { return _clientApp; }
            set { _clientApp = value; }
            }

        public string AppDBServer
            {
            get { return _AppDBServer; }
            set { _AppDBServer = value; }
            }

        public string AppDBName
            {
            get { return _AppDBName; }
            set { _AppDBName = value; }
            }

        public string TestDir
            {
            get { return _testDir; }
            set { _testDir = value; }
            }

        public string ImportDir
            {
            get { return _importDir; }
            set { _importDir = value; }
            }

        public string ExportDir
            {
            get { return _exportDir; }
            set { _exportDir = value; }
            }

        public string RefDir
            {
            get { return _refDir; }
            set { _refDir = value; }
            }
        #endregion
        }
    }
public interface ICWNSettings
    {
    string ServiceLocation { get; }
    string ServiceApp { get; }
    string ClientLocation { get; }
    string ClientApp { get; }
    string AppDBServer { get; }
    string AppDBName { get; }
    string TestDir { get; }
    string ImportDir { get; }
    string ExportDir { get; }
    string RefDir { get; }
    string ServiceSEPLocation { get; }
    string ServiceSEP { get; }
    string ClientSEPLocation { get; }
    string ClientSEP { get; }
    }
    
