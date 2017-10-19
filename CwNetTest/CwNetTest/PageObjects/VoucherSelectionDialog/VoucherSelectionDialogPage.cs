using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.VoucherSelectionDialog
    {
   public class VoucherSelectionDialogPage
        {
        public static string getPathOfCancelButton()
            {
            return "/form[@controlname='VouchersSelectionDialog']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Cancel']";
            }
        }
    }
