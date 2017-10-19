using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.BankMixAccount
    {
   public class BankMixAccountPage
        {
        public static string getPathOfOkButton()
            {
            return "/form[@controlname='BankMixAccount']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }

        public static string getPathOfOkButtonFinishPrepare()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='BankMixAccount']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }

        public static string getPathOfDebitAccountMTToAnotherBankField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='BankMixAccount']/container[@controlname='taskBankAccountControl']/?/?/toolbar[@controlname='toolBarTools']/?/?/text[@accessiblerole='Text']";
            }

        public static string getPathOfDebitBalanceBeforeTransferField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='BankMixAccount']/?/?/container[@controlname='groupBox1']/text[@controlname='lblBeforeAmount']";
            }

        public static string getPathOfDebitBalanceAfterTransferField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='BankMixAccount']/?/?/container[@controlname='groupBox1']/text[@controlname='lblAfterAmount']";
            }

        public static string getPathOfAmountForMTToAnotherBankField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='BankMixAccount']/?/?/container[@controlname='groupBox1']/?/?/text[@controltypename='TextBoxMaskBox']";
            }
        public static string getPathOfLoadButton()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='BankMixAccount']//toolbar[@controlname='toolBarTools']/button[@accessiblename='Load']";
            }

        public static string getPathDocNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='BankMixAccount']/?/?/text[@controlname='txtDocumentNumber']";
            }

        public static string getPathBankCodeField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='BankMixAccount']/container[@controlname='taskBeneficiaryInfo']/?/?/element[@controlname='txtBankCode']/?/?/text[@accessiblename='Bank Code']";
            }

        public static string getPathOfNameField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='BankMixAccount']/container[@controlname='taskBeneficiaryInfo']/?/?/element[@controlname='txtName']/?/?/text[@accessiblename='Name']";
            }

        public static string getPathOfAccountNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='BankMixAccount']/container[@controlname='taskBeneficiaryInfo']/?/?/element[@controlname='txtAccountNum']/?/?/text[@accessiblename='Account number']";
            }

        public static string getPathOfReasonField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='BankMixAccount']/container[@controlname='taskBeneficiaryInfo']/?/?/element[@controlname='clsReason']/text[@controltypename='TextBoxMaskBox']";
            }
        }
    }
