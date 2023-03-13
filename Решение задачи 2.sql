SELECT p.product_name, c.category_name
FROM Products p
LEFT JOIN (
    SELECT pc.product_id, c.category_name
    FROM ProductCategory pc
		JOIN Categories c ON pc.category_id = c.category_id
) AS c ON p.product_id = c.product_id
ORDER BY p.product_name