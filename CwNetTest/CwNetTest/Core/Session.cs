using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.Core
    {
    public class Session
        {
        #region init Singleton
        private static volatile Session _instance;
        private static readonly object _syncRoot = new object();
        public Session() { }
        public static Session Instance
            {
            get
                {
                if (_instance != null) return _instance;
                lock (_syncRoot)
                    {
                    if (_instance == null)
                        _instance = new Session();
                    }

                return _instance;
                }
            }
        #endregion

        #region CARD_NMT_OUT
        public static string ACCOUNT_DEBIT_NUMBER_FOR_CARD_NMT_OUT;
        public static string BALANCE_DEBIT_NUMBER_FOR_CARD_NMT_OUT;
        public static string AMOUNT_FOR_TRANSFER_CARD_NMT_OUT;                
        #endregion
        }
 }
