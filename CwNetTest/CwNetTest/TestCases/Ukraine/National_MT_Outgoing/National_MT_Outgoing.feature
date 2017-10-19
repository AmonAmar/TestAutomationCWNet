Feature: SpecFlowFeature
	In order to National MT Outgoing
	As a bank user
	I want to make a transfer

@National_Outgounting_Transfer	
Scenario Outline: Run Natioanl_outgounting_Transfer with example tables
Given Bank User have been on <firstTabPage> tab page
When Bank User enter debit account <debitAccount> for National_MT_Outgoing tab page
And Bank User enter actual date <actualDate> for National_MT_Outgoing tab page
And Bank User enter random amount for transfer for National_MT_Outgoing tab page
And Bank User enter random doc number for National_MT_Outgoing tab page
And Bank User enter credit bank code <bankCode> for National_MT_Outgoing tab page
And Bank User enter credit account <creditAccount> for National_MT_Outgoing tab page
And Bank User enter reason <reason> for National_MT_Outgoing tab page
And Bank User finish prepare BP for <prepareBP> transfer
Then Bank User have been on <secondTabPage> tab page
And Bank User enter current BpId <currentBpId>
And Bank User approve BP for <approveBP> transfer
And Bank User check result for National_MT_Outgoing transfer
Examples: 
| firstTabPage                  | debitAccount      | actualDate        | bankCode | creditAccount  | reason | secondTabPage         | currentBpId       |prepareBP                     | approveBP                    |
| CARD_NMT_OUT                  | 260500194184.980  | getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |CARD_NMT_OUT                  |CARD_NMT_OUT                  |
| CARD_NMT_OUT_EBANK_PI         | 26050210022978.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |CARD_NMT_OUT_EBANK_PI         |CARD_NMT_OUT_EBANK_PI         |
| CARD_NMT_OUT_EBANK_PI_SO      | 260500194184.980  | getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |CARD_NMT_OUT_EBANK_PI_SO      |CARD_NMT_OUT_EBANK_PI_SO      |
| CARD_NMT_OUT_IBANK            | 260500194184.980  | getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |CARD_NMT_OUT_IBANK            |CARD_NMT_OUT_IBANK            |
| CARD_NMT_OUT_PF               | 26050210022978.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |CARD_NMT_OUT_PF               |CARD_NMT_OUT_PF               |
| CARD_NMT_OUT_SO               | 26050210022978.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |CARD_NMT_OUT_SO               |CARD_NMT_OUT_SO               |
| NMT_EXPRESSBANK_INCASS_PAYM   | 26008230067512.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_EXPRESSBANK_INCASS_PAYM   |NMT_EXPRESSBANK_INCASS_PAYM   |
| NMT_EXTERN_MONEY_WRITEOFF_CA  | 26003210079280.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_EXTERN_MONEY_WRITEOFF_CA  |NMT_EXTERN_MONEY_WRITEOFF_CA  |
| NMT_EXTERN_MONEY_WRITEOFF_CARD| 26050210022978.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_EXTERN_MONEY_WRITEOFF_CARD|NMT_EXTERN_MONEY_WRITEOFF_CARD|
| NMT_OUT_CA                    | 260080902977.980  | getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_OUT_CA                    |NMT_OUT_CA                    |
| NMT_OUT_CA_EBANK_PI           | 26200210398106.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_OUT_CA_EBANK_PI           |NMT_OUT_CA_EBANK_PI           |
| NMT_OUT_CA_IBANK              | 260050103926.980  | getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_OUT_CA_IBANK              |NMT_OUT_CA_IBANK              |
| NMT_OUT_CA_IBANK_ST           | 26045210380506.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_OUT_CA_IBANK_ST           |NMT_OUT_CA_IBANK_ST           |
| NMT_OUT_CA_SO                 | 260080902977.980  | getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_OUT_CA_SO                 |NMT_OUT_CA_SO                 |
| NMT_OUT_CA_ST                 | 26049210173043.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_OUT_CA_ST                 |NMT_OUT_CA_ST                 |



@National_Outgounting_Transfer_Free	
Scenario Outline: Run National_Outgounting_Transfer_Free with example tables
Given Bank User have been on <firstTabPage> tab page
When Bank User enter debit account <debitAccount> for National_MT_Outgoing tab page
And Bank User enter actual date <actualDate> for National_MT_Outgoing tab page
And Bank User enter random amount for transfer for National_MT_Outgoing tab page
And Bank User enter random doc number for National_MT_Outgoing tab page
And Bank User enter credit bank code <bankCode> for National_MT_Outgoing tab page
And Bank User enter credit account <creditAccount> for National_MT_Outgoing tab page
And Bank User enter reason <reason> for National_MT_Outgoing tab page
And Bank User finish prepare BP for <prepareBP> transfer
Then Bank User have been on <secondTabPage> tab page
And Bank User enter current BpId <currentBpId>
And Bank User approve BP for <approveBP> transfer
And Bank User check result for National_MT_Outgoing transfer
Examples: 
| firstTabPage                  | debitAccount      | actualDate        | bankCode | creditAccount  | reason | secondTabPage         | currentBpId       |prepareBP                     | approveBP                    |
| NMT_OUT_FREE                  | 29006000100523.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_OUT_FREE                  |NMT_OUT_FREE                  |
| NMT_OUT_FREE_1C               | 36229000106580.980| getActualDate.sql | 820019   | 31115106700002 | *      | BUSINESS_PROCESS_FORM | getActualBpId.sql |NMT_OUT_FREE_1C               |NMT_OUT_FREE_1C               |











Scenario: Run CARD_NMT_OUT withou exmaple tables
Given Bank User have been on CARD_NMT_OUT tab page
When Bank User enter debit account 260500194184.980 for National_MT_Outgoing tab page
And Bank User enter actual date getActualDate.sql for National_MT_Outgoing tab page
And Bank User enter random amount for transfer for National_MT_Outgoing tab page
And Bank User enter random doc number for National_MT_Outgoing tab page
And Bank User enter credit bank code 820019 for National_MT_Outgoing tab page
And Bank User enter credit account 31115106700002 for National_MT_Outgoing tab page
And Bank User enter reason * for National_MT_Outgoing tab page
And Bank User finish prepare BP for CARD_NMT_OUT transfer
Then Bank User have been on BUSINESS_PROCESS_FORM tab page
And Bank User enter current BpId getActualBpId.sql
And Bank User approve BP for CARD_NMT_OUT transfer
And Bank User check result for National_MT_Outgoing transfer