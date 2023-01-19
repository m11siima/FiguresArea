  SELECT Pr.Name, C.Name 
  FROM [dbo].[Products] AS Pr
  LEFT JOIN [dbo].[CategoryProduct] CP ON Pr.Id = CP.ProductId
  LEFT JOIN [dbo].[Categories] C ON CP.CategoryId = C.Id