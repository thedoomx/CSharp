CREATE PROCEDURE switchBossWithEmployee
AS
BEGIN
	DECLARE @ManagerId INT;

	SELECT TOP 1   @ManagerId = ManagerId	
	FROM Employees as e

	UPDATE Employees
	SET Name = (SELECT TOP 1 e.Name
				FROM Employees as e
				WHERE e.ManagerID > 1
				ORDER BY e.ID ASC)
	WHERE ManagerID IS NULL AND DepartmentID IS NULL
END