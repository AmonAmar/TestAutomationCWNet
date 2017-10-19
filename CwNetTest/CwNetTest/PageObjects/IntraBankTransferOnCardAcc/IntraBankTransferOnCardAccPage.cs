using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.IntraBankTransferOnCardAcc
    {
   public class IntraBankTransferOnCardAccPage
        {
        public static string getPathOfLoadButtonOnSourceContractControl()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='IntraBankTransferOnCardAcc']/?/?/container[@controlname='SourceContractControl']/toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Load']";
            }

        public static string getPathOfLoadButton()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='IntraBankTransferOnCardAcc']//toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Load']";
            }

        public static string getPathOfAmountBeforeField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='IntraBankTransferOnCardAcc']/?/?/container[@controlname='gbSourceAmountInfo']/text[@controlname='lbBeforeTransferInfo']";
            }
        }
    }
