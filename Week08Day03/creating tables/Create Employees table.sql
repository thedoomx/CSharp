CREATE TABLE Employees
(
ID int NOT NULL PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Email nvarchar(50),
DateOfBirth date NOT NULL,
ManagerID int REFERENCES Employees(ID),
DepartmentID int REFERENCES Department(ID),
)