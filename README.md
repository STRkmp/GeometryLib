# GeometryLib
   Предположим есть три таблицы: 
   1) Products (id, name)
   2) Categories (id, name)
   3) ProductCategories(id, (FK) productId, (FK) categoryId)
      
```
SELECT
    p.name,
    c.name
FROM
    Products p
LEFT JOIN
    ProductCategories pc ON p.id = pc.productId
LEFT JOIN
    Categories c ON pc.categoryId = c.id
```
