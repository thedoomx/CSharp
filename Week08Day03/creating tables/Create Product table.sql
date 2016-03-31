CREATE TABLE Product
(
ID int NOT NULL PRIMARY KEY,
Name nvarchar(50),
SinglePrice money NOT NULL,
CategoryID int FOREIGN KEY REFERENCES Category(ID)
)