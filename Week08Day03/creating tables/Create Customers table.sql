CREATE TABLE Customers
(
ID int NOT NULL PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Email nvarchar(50),
CustomerAddress nvarchar(60) NOT NULL,
Discount decimal
)