select
	p.[id],
	p.[Name],
	c.[id],
	c.[Name]
from Products p
left join Products_Categories pc on p.id = pc.ProductId
left join Categories c on pc.CategorieId = c.id
