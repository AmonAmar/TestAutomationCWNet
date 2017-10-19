using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.ExternalMoneyTransferForm
    {
   public class ExternalMoneyTransferFormPage
        {
        public static string getPathOfLoadButton()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']//toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Load']";
            }

        public static string getPathOfAmountBeforeField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='taskPanel1']/?/?/text[@controlname='lblBeforeAmount']";
            }

        public static string getPathOfAmountAfterField()
            {
            return "/form[@controlname='MainForm']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='taskPanel1']/?/?/text[@controlname='lblAfterAmount']";
            }


        public static string getPathOfContractNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']//toolbar[@controlname='toolBarTools']/text[@controlname='ContractNumberTB']";
            }

        public static string getPathOfAmountForTransferField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='taskPanel1']/container[@controlname='amountSelectionControl1']//text[@controltypename='TextBoxMaskBox']";
            }

        public static string getPathOfCell()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/table[@controlname='listViewCards']/?/?/cell[@text='']";
            }

        public static string getPathOfDateField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='panel1']/element[@controlname='dteDocumentDate']/text[@controltypename='TextBoxMaskBox']";
            }

        public static string getPathOfDocNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='panel1']/?/?/text[@accessiblename='Document number']";
            }

        public static string getPathOfBankField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='taskPanel2']/?/?/element[@controlname='txtBankCode']/?/?/text[@accessiblename='Bank Code']";
            }

        public static string getPathOfNameField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='taskPanel2']/?/?/element[@controlname='txtName']/?/?/text[@accessiblename='Name']";
            }

        public static string getPathOfAccountNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='taskPanel2']/?/?/element[@controlname='txtAccountNum']/?/?/text[@accessiblename='Account number']";
            }

        public static string getPathOfReasonField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='taskPanel2']/?/?/element[@controlname='clsReason']/text[@controltypename='TextBoxMaskBox']";
            }

        public static string getPathOfOkApproveButton()
            {
            return "/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }

        public static string getPathOfOkButton()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='ExternalMoneyTransferForm_new']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }
        }
    }
