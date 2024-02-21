SELECT p.Name, c.Name FROM Product as p
LEFT JOIN ProductCategory as pc ON p.Id = pc.Product
LEFT JOIN Category as c ON c.Id = pc.Category