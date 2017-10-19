using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.IntraBankTransfer
    {
   public class IntraBankTransferPage
        {
        public static string getPathOfLoadButtonSourceContractControl()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/?/?/container[@controlname='SourceContractControl']/toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Load']";
            }

        public static string getPathOfLoadButton()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']//toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Load']";
            }

        public static string getPathOfAmountBeforeCreditField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']//table[@controlname='dataGridView']/row[@accessiblename='Row 7']/cell[@accessiblename='PropertyValue Row 7']";
            }

        public static string getPathOfOkButton()
            {
            return "/form[@controlname='IntraBankTransfer']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }

        public static string getPathOfAmountCAField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/?/?/container[@controlname='SourceContractControl']/container[@controlname='panelSurface']/table[@controlname='dataGridView']/row[@accessiblename='Row 7']/cell[@accessiblename='PropertyValue Row 7']";
            }

        public static string getPathOfCreditAccountNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']//toolbar[@controlname='toolBarTools']/text[@controlname='ContractNumberTB']";
            }

        public static string getPathOfDebitAccNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/?/?/container[@controlname='SourceContractControl']/toolbar[@controlname='toolBarTools']/text[@controlname='ContractNumberTB']";
            }

        public static string getPathOfDateField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/container[@controlname='panel1']/element[@controlname='dtpDateDocument']/text[@controltypename='TextBoxMaskBox']";
            }
        public static string getPathOfDocNumberField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/container[@controlname='panel1']/?/?/text[@accessiblename='Purpose Code']";
            }

        public static string getPathOfAmountForTransferField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/container[@controlname='AmountTaskPanel']/container[@controlname='AmountControl']//text[@accessiblerole='Text']/text[@accessiblerole='Text']";
            }

        public static string getPathOfCommentField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/container[@controlname='AmountTaskPanel']//text[@controltypename='TextBoxMaskBox']";
            }

        public static string getPathOfFinishPrepareOkButton()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']";
            }

        public static string getPathOfChooseCardField()
            {
            return "/form[@title='CustomWare.NET']/?/?/form[@controlname='IntraBankTransfer']/?/?/table[@controlname='listViewCards']/?/?/cell[@text='']";
            }
        }
    }
