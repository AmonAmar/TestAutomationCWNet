SELECT vcc.Balance
FROM vContractComponents AS vcc 
WHERE vcc.ContractNumber = @parameter
AND vcc.ContractServiceId = 1