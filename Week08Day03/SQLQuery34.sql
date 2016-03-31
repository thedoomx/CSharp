--SELECT *
--FROM Department as d
--WHERE ( SELECT count(*) --tova vrushta 1 chislo
--		FROM Employees as e
--		WHERE e.DepartmentID = d.ID) > 3

SELECT d.Name , ( SELECT count(*)
		FROM Employees as e
		WHERE e.DepartmentID = d.ID) as EmployeeCount
FROM Department as d
WHERE ( SELECT count(*)
		FROM Employees as e
		WHERE e.DepartmentID = d.ID) > 3

--SELECT d.Name, ( SELECT count(*)
--		FROM Employees as e
--		WHERE e.DepartmentID = d.ID) as EmployeeCount
--FROM Department as d
--JOIN Employees e
--ON e.DepartmentID = d.ID
--WHERE e.ManagerID != 1 AND ( SELECT count(*)
--		FROM Employees as e
--		WHERE e.DepartmentID = d.ID) > 3
--GROUP BY d.ID, d.Name --v select chasta mojem da slagame ili samo agregirashti funkcii ili koloni koito sa v group by

SELECT TOP 1 d.Name , ( SELECT count(*)
		FROM Employees as e
		WHERE e.DepartmentID = d.ID) as EmployeeCount
FROM Department as d
WHERE ( SELECT count(*)
		FROM Employees as e
		WHERE e.DepartmentID = d.ID) > 3