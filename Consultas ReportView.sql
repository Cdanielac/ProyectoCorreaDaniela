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


----Ventas con sus detalles
SELECT v.idVenta AS [Nro Factura],
	CONVERT(DATE,v.fechaAlta) as [Fecha],
	cj.usuario AS [Cajero],
	CONCAT(cl.apellido, ' ', cl.nombre) AS [Cliente],
	t.descripcion AS [Tipo de Factura],
	f.descripcion AS [Forma de Pago],
	p.nombre AS [Producto],
	d.cantidad AS [Cantidad],
	d.subtotal AS [Subtotal],
	v.total AS [Total]
FROM Venta v
	INNER JOIN DetalleVenta d ON d.idVenta = v.idVenta
	INNER JOIN Usuario cj ON cj.idUsuario = v.idUsuario
	INNER JOIN Cliente cl ON cl.idCliente = v.idCliente
	INNER JOIN TipoFactura t ON t.idTipoFactura = v.idTipoFactura
	INNER JOIN FormaPago f ON f.idFormaPago = v.idFormaPago
	INNER JOIN Producto p ON p.idProducto = d.idProducto
ORDER BY v.idVenta ASC

---Usuarios Rol
SELECT        CONCAT(Empleado.apellido, ' ' , Empleado.nombre) as [Empleado], Rol.descripcion as [Rol]
FROM            Usuario
 INNER JOIN
                         Empleado ON Usuario.dni = Empleado.dni 
INNER JOIN
                         Rol ON Usuario.idRol = Rol.idRol

--Recaudado por categoria


SELECT        Categoria.descripcion AS Categoria, SUM(DetalleVenta.subtotal) AS Recaudado
FROM            DetalleVenta INNER JOIN
                         Producto ON DetalleVenta.idProducto = Producto.idProducto INNER JOIN
                         Categoria ON Producto.idCategoria = Categoria.idCategoria
GROUP BY Categoria.descripcion