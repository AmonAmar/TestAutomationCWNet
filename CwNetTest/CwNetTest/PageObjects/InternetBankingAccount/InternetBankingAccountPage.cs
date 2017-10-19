using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetTest.PageObjects.InternetBankingAccount
    {
   public class InternetBankingAccountPage
        {
        public static string getPathOfFindButton() { return "/form[@title='CustomWare.NET']/?/?/form[@controlname='SpecialContractForm']//toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Find']"; }
        public static string getPathOfCurrencyField() { return "/form[@controlname='AccountContractProductSearchForm']/container[@controlname='pnlType']//text[@controltypename='TextBoxMaskBox']"; }
        public static string getPathOfFirstRow() { return "/form[@controlname='AccountContractProductSearchForm']/container[@controlname='accountContractProductSearchViewer']/?/?/tree[@accessiblerole='Outline']//cell[@accessiblename='Min open amount row 0']"; }
        public static string getPathOfFind1Button() { return "/form[@title='CustomWare.NET']/?/?/form[@controlname='SpecialContractForm']/?/?/container[@controlname='clientViewer']/toolbar[@controlname='toolBarTools']/menuitem[@accessiblename='Find']"; }
        public static string getPathOfOkButton() { return "/form[@title='CustomWare.NET']/?/?/form[@controlname='SpecialContractForm']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']"; }
        public static string getPathOfCancelButton() { return "/form[@controlname='AgreementTypeSelectionDialog']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Cancel']"; }
        public static string getPathOfFilterButton() { return "/form[@title='CustomWare.NET']/?/?/form[@controlname='BusinessProcessesForm']/?/?/menubar[@controlname='menuStrip2']/menuitem[@accessiblename='Filter']"; }
        public static string getPathOfOkButtonBP() { return "/form[@controlname='SpecialContractForm']/container[@controlname='buttonsPanel1']/?/?/button[@accessiblename='Ok']"; }
        }
    }
