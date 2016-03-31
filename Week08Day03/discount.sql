USE Week08Day03

SELECT o.CustomerID, count(*)
FROM Orders as o
GROUP BY o.CustomerID
ORDER BY count(*) DESC
