using CwNetTest.Core;
using CwNetTest.PageObjects.BeneficiaryAccountSelectionDialog;
using CwNetTest.PageObjects.ExternalMoneyTransferForm;
using CwNetTest.SQL;
using CwNetTest.Steps;
using System;
using System.Globalization;
using TechTalk.SpecFlow;

namespace CwNetTest.DefinitionSteps
    {
    [Binding]
    public class NationalOutgoingDefinitionSteps : InitApplications
        {        

        [Given("Bank User have been on (.*) tab page")]
        [Then("Bank User have been on (.*) tab page")]
        public void BankUserHaveBeenOnTabPage(string nameOfTabPage)
            {
            new NationalOutgoingSteps().goToTestedTabPage(nameOfTabPage);
            }

        [When("Bank User enter debit account (.*) for National_MT_Outgoing tab page")]
        public void BankUserEnterDebitAccount(string accNumber)
            {
            new NationalOutgoingSteps().enterDebitAccount(accNumber, ExternalMoneyTransferFormPage.getPathOfContractNumberField());
            new NationalOutgoingSteps().pressLoadMenuItem(ExternalMoneyTransferFormPage.getPathOfLoadButton());
            #region prepare account and balance for Session
            Session.ACCOUNT_DEBIT_NUMBER_FOR_CARD_NMT_OUT = accNumber;
            string balance = string.Empty;
            DataBase.execute(CommonMethods.GET_ACTUAL_BALANCE,accNumber)[0].TryGetValue("Balance", out balance);
            Session.BALANCE_DEBIT_NUMBER_FOR_CARD_NMT_OUT = balance;
            #endregion
            }

        [When("Bank User enter actual date (.*) for National_MT_Outgoing tab page")]
        public void BankUserEnterActualDate(string nameOfSQLFile)
            {
            string actualDate = string.Empty;
            DataBase.execute(nameOfSQLFile)[0].TryGetValue("currDate", out actualDate);
            DateTime dateTime = Convert.ToDateTime(actualDate);
            new NationalOutgoingSteps().enterActualDate(dateTime.ToString("ddMMyyyy", CultureInfo.InvariantCulture)
                , ExternalMoneyTransferFormPage.getPathOfDateField());
            }

        [When("Bank User enter random amount for transfer for National_MT_Outgoing tab page")]
        public void BankUserEnterRandomAmountForTransferForNational_MT_OutgoingTabPage()
            {
            #region prepare amount for Session
            string randomAmount = CommonMethods.getRandomAmount();
            Session.AMOUNT_FOR_TRANSFER_CARD_NMT_OUT = randomAmount;
            #endregion
            new NationalOutgoingSteps().enterRandomAmountForTransferForNational_MT_OutgoingTabPage(randomAmount, ExternalMoneyTransferFormPage.getPathOfAmountForTransferField());            
            }

        [When("Bank User enter random doc number for National_MT_Outgoing tab page")]
        public void BankUserEnterRandomDocNumberForNational_MT_OutgoingTabPage()
            {
            new NationalOutgoingSteps().enterRandomDocNumberForTransferForNational_MT_OutgoingTabPage(CommonMethods.getRandomDocNumber(), ExternalMoneyTransferFormPage.getPathOfDocNumberField());
            }

        [When("Bank User enter credit bank code (.*) for National_MT_Outgoing tab page")]
        public void BankUserEnterCreditBankCodeForNational_MT_OutgoingTabPage(string bankCode)
            {
            new NationalOutgoingSteps().enterBankUserCreditBankCodeForNational_MT_OutgoingTabPage(bankCode, ExternalMoneyTransferFormPage.getPathOfBankField());
            }

        [When("Bank User enter credit account (.*) for National_MT_Outgoing tab page")]
        public void BankUserEnterCreditAccountForNational_MT_OutgoingTabpage(string accCreditNumber)
            {
            new TextCopy(ExternalMoneyTransferFormPage.getPathOfNameField()).operationWithText();
            new NationalOutgoingSteps().enterBankUserCreditAccountForNational_MT_OutgoingTabpage(accCreditNumber, ExternalMoneyTransferFormPage.getPathOfAccountNumberField());
            new ButtonCopy(BeneficiaryAccountSelectionDialogPage.getPathOfCancelButton()).operationWithButton();
            }

        [When("Bank User enter reason (.*) for National_MT_Outgoing tab page")]
        public void BankUserEnterReasonForNational_MT_OutgoingTabpage(string reason)
            {
            new NationalOutgoingSteps().enterBankUserReasonForNational_MT_OutgoingTabpage(reason, ExternalMoneyTransferFormPage.getPathOfReasonField());
            }

        [When(@"Bank User finish prepare BP for (.*) transfer")]
        public void BankUserFinishPrepareBpFor_CARD_NMT_OUT_Transfer(string nameOfBP)
            {
            new NationalOutgoingSteps().bankUserFinishPrepareBBForCurrentTransfer(nameOfBP);
            }

        [Then(@"Bank User enter current BpId (.*)")]
        public void BankUserEnterCurrentBpId(string nameOfSQLFile)
            {
            string actualBpId = string.Empty;
            DataBase.execute(nameOfSQLFile)[0].TryGetValue("actualBpId", out actualBpId);
            CommonMethods.enterBankUserEnterCurrentBpId(actualBpId);
            }

        [Then(@"Bank User approve BP for (.*) transfer")]
        public void BankUserApproveBPFor_CARD_NMT_OUT_transfer(string nameOfBP)
            {
            new NationalOutgoingSteps().BankUserApproveBPFor_CARD_NMT_OUT_Transfer(nameOfBP);
            }

        [Then(@"Bank User check result for National_MT_Outgoing transfer")]
        public void BankUserCheckResultFor_National_MT_Outgoing_Transfer()
            {
            new NationalOutgoingSteps().CheckResultFor_National_MT_Outgoing_Transfer();
            }
        }
}
