# GeometryLib
   Предположим есть три таблицы: Products (id, name), Categories (id, name), ProductCategories(id, (FK)productId, (FK)categoryId)
SELECT
    p.name,
    c.name
FROM
    Products p
LEFT JOIN
    ProductCategories pc ON p.id = pc.productId
LEFT JOIN
    Categories c ON pc.categoryId = c.id
