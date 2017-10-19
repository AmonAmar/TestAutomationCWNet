using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.BeneficiaryAccountSelectionDialog
    {
  public  class BeneficiaryAccountSelectionDialogPage
        {
        public static string getPathOfCancelButton()
            {
            return "/form[@controlname='BeneficiaryAccountSelectionDialog']/?/?/button[@accessiblename='Cancel']";
            }
        }
    }
