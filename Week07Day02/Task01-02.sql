USE [AdventureWorks2012]
SELECT [per].FirstName, [per].[LastName], [add].[City]
FROM [Person].[Person] as [per]
JOIN [Person].[BusinessEntityAddress] as [beadd]
ON [beadd].[BusinessEntityID] = [per].[BusinessEntityID]
JOIN [Person].[Address] as [add]
ON [add].[AddressID] = [beadd].[AddressID]
WHERE [add].[City] != 'Payson'