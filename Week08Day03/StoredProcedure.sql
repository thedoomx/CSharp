ALTER PROCEDURE orderedProductCount
@ProductID int
AS
SELECT sum(op.Quantity) as ProductCounter
FROM OrderProducts as op
WHERE op.ProductID = @ProductID
GO

EXEC orderedProductCount @ProductID = 4