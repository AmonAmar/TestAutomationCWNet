namespace CwNetTest.Interfaces
    {
    public interface ICWNSetup
        {
        string ServiceLocation { get; }
        string ServiceApp { get; }
        string ClientLocation { get; }
        string ClientApp { get; }
        string TestDir { get; }
        string ImportDir { get; }
        string ExportDir { get; }
        string RefDir { get; }
        string ServiceSEPLocation { get; }
        string ServiceSEP { get; }
        string ClientSEPLocation { get; }
        string ClientSEP { get; }
        }
    }
