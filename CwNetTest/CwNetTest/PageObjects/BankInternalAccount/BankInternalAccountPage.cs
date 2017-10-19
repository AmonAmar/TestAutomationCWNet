using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.BankInternalAccount
    {
   public class BankInternalAccountPage
        {
        public string getPathOfOkButton()
            {
            return "/form[@controlname='BankInternalAccount']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }
        }
    }
