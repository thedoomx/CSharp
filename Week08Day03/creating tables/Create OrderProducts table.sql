CREATE TABLE OrderProducts
(
OrderID int NOT NULL FOREIGN KEY REFERENCES Orders(ID),
ProductID int NOT NULL FOREIGN KEY REFERENCES Product(ID)
PRIMARY KEY (OrderID, ProductID)
)
