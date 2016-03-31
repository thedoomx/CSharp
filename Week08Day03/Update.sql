--UPDATE Employees
--SET DateOfBirth = DATEADD(year, +1, DateOfBirth)

--UPDATE Customers
--SET Discount = Discount / 2


--DELETE FROM Product
--WHERE ( SELECT count(*)
--		FROM OrderProducts as op
--		WHERE Product.ID = op.ProductID) < 1
