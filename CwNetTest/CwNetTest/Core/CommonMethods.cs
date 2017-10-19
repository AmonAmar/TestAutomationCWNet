using CwNetTest.PageObjects.BusinessProcesses;
using CwNetTest.PageObjects.ExternalMoneyTransferForm;
using CwNetTest.PageObjects.InformationDialog;
using System;
using System.Linq;

namespace CwNetTest.Core
    {
    public class CommonMethods
        {
        public static readonly string PATH_OF_SQL_FILE = @"F:\WORK\TestAutomation\SpecFlowTestCWNet\CwNetTest\CwNetTest\SQL\";
        public static readonly string GET_ACTUAL_BALANCE = "getActualBalance.sql";
        public static readonly string CW_NET_DATA_BASE = "CwNet";
        public static void SelectMenu(string path)
            {
            if (path.Contains("menuitem"))
                {
                new MenuItemCopy(path).operationWithMenuItem();
                }
            else if (path.Contains("button"))
                {
                new ButtonCopy(path).operationWithButton();
                }
            else if (path.Contains("cell"))
                {
                new CellCopy(path).operationWithCell();
                }

            }

        public static string getRandomDocNumber()
            {
            Random random = new Random();
            string input = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, 5)
                                   .Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());

            }

        public static string getRandomAmount()
            {
            Random random = new Random();
            string input = "123";
            var chars = Enumerable.Range(0, 2)
                                   .Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
            }

        public static void approveCommonPrepareStepsForBpNationalOutgoing()
            {
            SelectMenu(ExternalMoneyTransferFormPage.getPathOfOkButton());
            SelectMenu(InformationDialogPage.getPathOfOkButton());            
            }

        public static void approveCommonApproveStepsForBpNationalOutgoing()
            {
            SelectMenu(BusinessProcessesPage.getPathOfFirstCheckBox());
            SelectMenu(BusinessProcessesPage.getPathOfExecuteButton());
            SelectMenu(ExternalMoneyTransferFormPage.getPathOfOkApproveButton());
            SelectMenu(InformationDialogPage.getPathOfOkButton());
            SelectMenu(BusinessProcessesPage.getPathOfExecuteButton());
            }
        public static void enterBankUserEnterCurrentBpId(string actualBpId)
            {
            SelectMenu(BusinessProcessesPage.getPathOfFilterButton());
            new TextCopy(actualBpId, BusinessProcessesPage.getPathOfFindBpId()).operationWithText();
            }
        }
    }
