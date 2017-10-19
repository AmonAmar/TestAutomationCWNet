using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.MultiPurposeTransferForm
    {
   public class MultiPurposeTransferPage
        {
        public static string getPathOfOkButton()
            {
            return "/form[@controlname='MultiPurposeTransferForm']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }
        public static string getPathOfDebitAccountField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='MultiPurposeTransferForm']//toolbar[@controlname='toolBarTools']/text[@controlname='ContractNumberTB']"; ;
            }

        public static string getPathOfBeforeTransferField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='MultiPurposeTransferForm']/?/?/text[@controlname='lbBeforeTransferInfo']";
            }

        public static string getPathOfAfterTransferField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='MultiPurposeTransferForm']/?/?/text[@controlname='lbAfterTransferInfo']";
            }

        public static string getPathOfAmountTransferField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='MultiPurposeTransferForm']/container[@controlname='panelAmount']/element/text[@controltypename='TextBoxMaskBox']";
            }

        public static string getPathOfLoadButton()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='MultiPurposeTransferForm']//toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Load']";
            }

        public static string getPathOfDocNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='MultiPurposeTransferForm']/container[@controlname='panelInfo']/?/?/text[@accessiblerole='Text']";
            }
        }
    }
