select * from Venta
select * from DetalleVenta;
select* from Producto;

--Factura
SELECT DetalleVenta.idVenta,
Venta.fechaAlta as Fecha,
Concat(Cliente.apellido, ' ', Cliente.nombre) as Cliente, 
Usuario.usuario,
TipoFactura.descripcion,
FormaPago.descripcion, 
Producto.codProducto, 
Producto.nombre as Producto,
DetalleVenta.cantidad as Cantidad,
DetalleVenta.subtotal as Subtotal,
Venta.total as Total
FROM  DetalleVenta 
INNER JOIN Producto ON Producto.idProducto = DetalleVenta.idProducto 
INNER JOIN Venta ON Venta.idVenta = DetalleVenta.idVenta
INNER JOIN FormaPago ON Venta.idFormaPago = FormaPago.idFormaPago
INNER JOIN TipoFactura ON Venta.idTipoFactura = TipoFactura.idTipoFactura
INNER JOIN Cliente ON Cliente.idCliente = Venta.idCliente
INNER JOIN Usuario ON Usuario.idUsuario = Venta.idUsuario
WHERE Venta.idVenta = 2;

select* from DetalleVenta;

--Producto por categoria
SELECT        Producto.idProducto, Producto.codProducto, Producto.nombre, Categoria.descripcion as Categoria, Producto.stock, Producto.stockMinimo, Proveedor.razonSocial as Proveedor, Producto.precioVenta, Producto.descripcion AS Expr1, Producto.estado, 
                         Producto.fechaAlta
FROM            Producto INNER JOIN
                         Categoria ON Categoria.idCategoria = Producto.idCategoria INNER JOIN
                         Proveedor ON Proveedor.idProveedor = Producto.idProveedor
WHERE        (Producto.idCategoria = 2)

select * from Producto;

Select count(producto.idcategoria) as Cantidad, categoria.descripcion from Producto
	iNNER JOIN Categoria ON Categoria.idCategoria = Producto.idCategoria
group by categoria.descripcion