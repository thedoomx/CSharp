SELECT o.ID, ( SELECT count(*)
		FROM OrderProducts as op
		WHERE o.ID = op.OrderID) as ProductsInOrder
FROM Orders as o
WHERE ( SELECT count(*)
		FROM OrderProducts as op
		WHERE o.ID = op.OrderID) IS NOT NULL


select op.OrderID, sum(op.Quantity) c
from OrderProducts op
group by op.OrderID
having sum(op.Quantity) = (select max(d.qty)
							from (select sum(op.Quantity) qty
								from OrderProducts op
								group by op.OrderID) d)


with data as (select op.OrderID, sum(op.Quantity) Quantity
	from OrderProducts op
	group by op.OrderID)
select op.OrderID, op.Quantity
from data op
where op.Quantity = (select max(d.Quantity)
							from data d)


select top 1 op.OrderID, sum(op.Quantity) c
from OrderProducts op
group by op.OrderID
order by sum(op.Quantity) desc