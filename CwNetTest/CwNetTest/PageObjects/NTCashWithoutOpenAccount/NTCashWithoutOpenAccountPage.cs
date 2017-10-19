using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.NTCashWithoutOpenAccount
    {
   public class NTCashWithoutOpenAccountPage
        {
        public static string getPathOfBankClientItem()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='NTCashWithoutOpenAccountForm']//toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Bank Client']";
            }

        public static string getPathOfBankClientSecondItem()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='NTCashWithoutOpenAccountForm']/container[@controlname='taskOrderingInfo']/?/?/container[@controlname='ThirdPartClient']/toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Bank Client']";
            }

        public static string getPathOfAmountTransferField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='NTCashWithoutOpenAccountForm']/container[@controlname='taskOrderingInfo']//element[@controlname='Amount']/text[@controltypename='TextBoxMaskBox']";
            }

        public static string getPathOfAccountNumberField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='NTCashWithoutOpenAccountForm']/container[@controlname='taskPanel2']/?/?/element[@controlname='txtAccountNum']/text[@controltypename='TextBoxMaskBox']";
            }

        public static string getPathOfBankCodeField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='NTCashWithoutOpenAccountForm']/container[@controlname='taskPanel2']/?/?/element[@controlname='txtBankCode']/text[@controltypename='TextBoxMaskBox']";
            }

        public static string getPathOfOkButtonOnBusinessProcess()
            {
            return "/form[@controlname='NTCashWithoutOpenAccountForm']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }
        }
    }
