USE [Week08Day03]

SELECT * 
FROM [Employees] as e
WHERE e.DepartmentID IS NULL AND e.ManagerID IS NULL

SELECT * 
FROM [Employees] as e
WHERE e.ManagerID = 1

SELECT * 
FROM [Employees] as e
WHERE e.DepartmentID = 1 AND e.ManagerID = 2
ORDER BY Name