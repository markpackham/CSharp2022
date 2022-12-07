select p.brand from product p
inner join StoreInventory si on p.id = si.ProductId
where si.StoreId = 1