USE [AdventureWorks2012]

UPDATE [Person].[Person]
SET [LastName] = 'Weber-Williams'
WHERE [FirstName] = 'Chelsea' AND [LastName] = 'Weber'

SELECT *
FROM [Person].[Person]
WHERE [LastName] = 'Weber-Williams' AND [FirstName] = 'Chelsea'
