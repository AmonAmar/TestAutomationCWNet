using CwNetTest.Core;
using CwNetTest.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System;
using CwNetTest.PageObjects.ExternalMoneyTransferForm;
using CwNetTest.PageObjects.VoucherSelectionDialog;
using CwNetTest.PageObjects.InformationDialog;
using CwNetTest.PageObjects.BusinessProcesses;
using CwNetTest.SQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CwNetTest.PageObjects.BankMixAccount;

namespace CwNetTest.Steps
    {
    public class NationalOutgoingSteps
        {
        private RanorexPathToTestedMenuItems _ranorexPathToTestedMenuItems = new RanorexPathToTestedMenuItems();
        internal void goToTestedTabPage(string nameOfTabPage)
            {
            string pathFromCode = string.Empty;
            RanorexPathToTestedMenuItems.ranorexPath.TryGetValue(nameOfTabPage, out pathFromCode);
            List<string> splitedPath = pathFromCode.Split(',').ToList();
            splitedPath.ForEach(_ => CommonMethods.SelectMenu(_));
            }

        internal void enterDebitAccount(string accNumber,string pathOfElement)
            {
            new TextCopy(accNumber,pathOfElement).operationWithText();
            }

        internal void pressLoadMenuItem(string pathOfElement)
            {
            new MenuItemCopy(pathOfElement).operationWithMenuItem();
            }

        internal void enterActualDate(string actualDate, string pathOfElement)
            {
            new TextCopy(actualDate, pathOfElement).operationWithText();
            }

        internal void enterRandomAmountForTransferForNational_MT_OutgoingTabPage(string randomAmount, string pathOfElement)
            {
            new TextCopy(randomAmount, pathOfElement).operationWithText();
            }

        internal void enterRandomDocNumberForTransferForNational_MT_OutgoingTabPage(string randomDocNumber, string pathOfElement)
            {
            new TextCopy(randomDocNumber, pathOfElement).operationWithText();
            }

        internal void enterBankUserCreditBankCodeForNational_MT_OutgoingTabPage(string bankCode, string pathOfElement)
            {
            new TextCopy(bankCode, pathOfElement).operationWithText();
            }

        internal void enterBankUserCreditAccountForNational_MT_OutgoingTabpage(string accCreditNumber, string pathOfElement)
            {
            new TextCopy(accCreditNumber, pathOfElement).operationWithText();
            }

        internal void enterBankUserReasonForNational_MT_OutgoingTabpage(string reason, string pathOfElement)
            {
            new TextCopy(reason, pathOfElement).operationWithText();
            }

        internal void bankUserFinishPrepareBBForCurrentTransfer(string nameOfBP)
            {
            switch (nameOfBP)
                {
                #region CARD_NMT_OUT
                case "CARD_NMT_OUT":
                    new CellCopy(ExternalMoneyTransferFormPage.getPathOfCell()).operationWithCellDoubleClick();
                    CommonMethods.approveCommonPrepareStepsForBpNationalOutgoing();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(VoucherSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
                    break;
                #endregion
                #region CARD_NMT_OUT_EBANK_PI
                case "CARD_NMT_OUT_EBANK_PI":
                    new CellCopy(ExternalMoneyTransferFormPage.getPathOfCell()).operationWithCellDoubleClick();
                    CommonMethods.approveCommonPrepareStepsForBpNationalOutgoing();
                    new ButtonCopy(VoucherSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
                    break;
                #endregion
                #region CARD_NMT_OUT_EBANK_PI_SO && CARD_NMT_OUT_SO
                case "CARD_NMT_OUT_EBANK_PI_SO":
                case "CARD_NMT_OUT_SO":
                    new CellCopy(ExternalMoneyTransferFormPage.getPathOfCell()).operationWithCellDoubleClick();
                    CommonMethods.approveCommonPrepareStepsForBpNationalOutgoing();
                    break;
                #endregion
                #region CARD_NMT_OUT_IBANK && CARD_NMT_OUT_PF && NMT_EXTERN_MONEY_WRITEOFF_CARD
                case "CARD_NMT_OUT_IBANK":
                case "CARD_NMT_OUT_PF":
                case "NMT_EXTERN_MONEY_WRITEOFF_CARD":
                    new CellCopy(ExternalMoneyTransferFormPage.getPathOfCell()).operationWithCellDoubleClick();
                    CommonMethods.approveCommonPrepareStepsForBpNationalOutgoing();
                    new ButtonCopy(VoucherSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
                    break;
                #endregion
                #region NMT_EXPRESSBANK_INCASS_PAYM && NMT_EXTERN_MONEY_WRITEOFF_CA && NMT_OUT_CA_EBANK_PI && NMT_OUT_CA_IBANK && NMT_OUT_CA_IBANK_ST
                case "NMT_EXPRESSBANK_INCASS_PAYM":
                case "NMT_EXTERN_MONEY_WRITEOFF_CA":
                case "NMT_OUT_CA_EBANK_PI":
                case "NMT_OUT_CA_IBANK":
                case "NMT_OUT_CA_IBANK_ST":
                    CommonMethods.approveCommonPrepareStepsForBpNationalOutgoing();
                    new ButtonCopy(VoucherSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
                    break;
                #endregion
                #region NMT_OUT_CA && NMT_OUT_CA_ST
                case "NMT_OUT_CA":
                case "NMT_OUT_CA_ST":
                    CommonMethods.approveCommonPrepareStepsForBpNationalOutgoing();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(VoucherSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
                    break;
                #endregion
                #region NMT_OUT_CA_SO
                case "NMT_OUT_CA_SO":
                    CommonMethods.approveCommonPrepareStepsForBpNationalOutgoing();
                    break;
                #endregion
                #region NMT_OUT_FREE
                case "NMT_OUT_FREE":
                    new ButtonCopy(BankMixAccountPage.getPathOfOkButtonFinishPrepare()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    break;
                #endregion
                #region NMT_OUT_FREE
                case "NMT_OUT_FREE_1C":
                    new ButtonCopy(BankMixAccountPage.getPathOfOkButtonFinishPrepare()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(VoucherSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
                    break;
                    #endregion
                }
            }

        internal void BankUserApproveBPFor_CARD_NMT_OUT_Transfer(string nameOfBP)
            {
            switch (nameOfBP)
                {
                #region CARD_NMT_OUT_EBANK_PI && NMT_OUT_CA && NMT_OUT_CA_EBANK_PI && NMT_OUT_CA_IBANK
                case "CARD_NMT_OUT_EBANK_PI":
                case "NMT_OUT_CA":
                case "NMT_OUT_CA_EBANK_PI":
                case "NMT_OUT_CA_IBANK":
                    CommonMethods.approveCommonApproveStepsForBpNationalOutgoing();
                    new ButtonCopy(BusinessProcessesPage.getPathOfOKButtonOnBusinessProcessFormWPF()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    break;
                #endregion
                #region CARD_NMT_OUT_PF
                case "CARD_NMT_OUT_PF":
                    CommonMethods.approveCommonApproveStepsForBpNationalOutgoing();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    break;
                #endregion
                #region NMT_OUT_CA_SO &&NMT_OUT_CA_IBANK_ST && CARD_NMT_OUT && CARD_NMT_OUT_EBANK_PI_SO && CARD_NMT_OUT_SO && NMT_EXPRESSBANK_INCASS_PAYM && NMT_EXTERN_MONEY_WRITEOFF_CA && NMT_EXTERN_MONEY_WRITEOFF_CARD && CARD_NMT_OUT_IBANK
                case "CARD_NMT_OUT":
                case "CARD_NMT_OUT_EBANK_PI_SO":
                case "CARD_NMT_OUT_SO":
                case "NMT_EXPRESSBANK_INCASS_PAYM":
                case "NMT_EXTERN_MONEY_WRITEOFF_CA":
                case "NMT_EXTERN_MONEY_WRITEOFF_CARD":
                case "CARD_NMT_OUT_IBANK":
                case "NMT_OUT_CA_IBANK_ST":
                case "NMT_OUT_CA_SO":
                    CommonMethods.approveCommonApproveStepsForBpNationalOutgoing();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    break;
                #endregion
                #region NMT_OUT_CA_ST
                case "NMT_OUT_CA_ST":
                    CommonMethods.approveCommonApproveStepsForBpNationalOutgoing();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(ExternalMoneyTransferFormPage.getPathOfOkApproveButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(VoucherSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
                    break;
                #endregion
                #region NMT_OUT_FREE
                case "NMT_OUT_FREE":
                    new CellCopy(BusinessProcessesPage.getPathOfFirstCheckBox()).operationWithCell();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(BankMixAccountPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(BankMixAccountPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(BankMixAccountPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    break;
                #endregion
                #region NMT_OUT_FREE
                case "NMT_OUT_FREE_1C":
                    new CellCopy(BusinessProcessesPage.getPathOfFirstCheckBox()).operationWithCell();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(BankMixAccountPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(BankMixAccountPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new MenuItemCopy(BusinessProcessesPage.getPathOfExecuteButton()).operationWithMenuItem();
                    new ButtonCopy(BankMixAccountPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(InformationDialogPage.getPathOfOkButton()).operationWithButton();
                    new ButtonCopy(VoucherSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
                    break;
                    #endregion
                }
            }

        internal void CheckResultFor_National_MT_Outgoing_Transfer()
            {
            double balanceBeforeTransfer = Convert.ToDouble(Session.BALANCE_DEBIT_NUMBER_FOR_CARD_NMT_OUT);
            double amountForTransfer = Convert.ToDouble(Session.AMOUNT_FOR_TRANSFER_CARD_NMT_OUT);
            string currentBalanceBeforeConverting = string.Empty;
            DataBase.execute(CommonMethods.GET_ACTUAL_BALANCE, Session.ACCOUNT_DEBIT_NUMBER_FOR_CARD_NMT_OUT)[0].TryGetValue("Balance", out currentBalanceBeforeConverting);
            double currentBalance = Convert.ToDouble(currentBalanceBeforeConverting);            
            Assert.IsTrue(balanceBeforeTransfer - amountForTransfer == currentBalance,string.Format("Current balance is {0} expected {1}. " , currentBalance , balanceBeforeTransfer - amountForTransfer));
            }
        }
    }
