using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.PaymentRequisitesSpecification
    {
   public class PaymentRequisitesSpecificationPage
        {
        public static string getPathOfOkButton()
            {
            return "/form[@controlname='PaymentRequisitesSpecificationForm']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }

        public static string getPathOfAmountField()
            {
            return "/form[@controlname='PaymentRequisitesSpecificationForm']/tabpagelist[@controlname='tabControl1']/tabpage[@controlname='tpPayment']//text[@accessiblename='Amount']";
            }
        public static string getPathOfAccountField()
            {
            return "/form[@controlname='PaymentRequisitesSpecificationForm']/tabpagelist[@controlname='tabControl1']/tabpage[@controlname='tpPayment']//text[@accessiblename='Account number']";
            }
        }
    }
