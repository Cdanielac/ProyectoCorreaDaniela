--Agregar columna a tabla
ALTER TABLE Producto
	ADD idProveedor int;
---Agregar FK
ALTER TABLE Producto
	ADD CONSTRAINT FK_Producto_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(idProveedor);

--Rol
select* from Rol

insert into rol (descripcion)
values('Administrador')
insert into rol (descripcion)
values('Cajero')
insert into rol (descripcion)
values('Jefe de Control de Inventario')

--Empleado
select * from Empleado

insert Empleado(dni,apellido,nombre,email,direccion,telefono,estado)
values(1234,'Ibarrola','Rebeca','rebe@gmail.com','Saladas',45632,1)

insert Empleado(dni,apellido,nombre,email,direccion,telefono,estado)
values(3245,'Ibarrola','Anyelen','anyeI@gmail.com','Saladas',44673,1)

insert Empleado(dni,apellido,nombre,email,direccion,telefono,estado)
values(1345,'Barion','Ian','ian@gmail.com','Corrientes',34562,1)

--Usuario
select* from Usuario

insert into Usuario(dni,idRol,usuario,contraseña,estado)
values(1234,1,'RebeI','Rebe1234',1)

--TipoFactura
select* from TipoFactura

insert into TipoFactura (descripcion,estado)
values('A',1)
insert into TipoFactura (descripcion,estado)
values('B',1)
insert into TipoFactura (descripcion,estado)
values('C',1)

--FormaPago
select* from FormaPago

insert into FormaPago (descripcion,estado)
values('Efectivo',1)
insert into FormaPago (descripcion,estado)
values('Tarjeta Débito',1)
insert into FormaPago (descripcion,estado)
values('Tarjeta Crédito',1)
insert into FormaPago (descripcion,estado)
values('Transferencia Bancaria',1)

--Categoria
select* from Categoria

insert into Categoria (descripcion,estado)
values('Bazar',1)
insert into Categoria (descripcion,estado)
values('Decoración',1)

--Proveedor
select * from Proveedor

insert Proveedor(codProveedor,razonSocial,email,telefono,direccion,estado)
values(34536,'Portal Mayotista','portalM@gmail.com',1145632,'Buenos Aires',1)

insert Proveedor(codProveedor,razonSocial,email,telefono,direccion,estado)
values(2344,'Soifer Hnos','soifer@gmail.com',4567,'Bahía Blanca',1)

insert Proveedor(codProveedor,razonSocial,email,telefono,direccion,estado)
values(12344,'Bazar 380','bazar380@gmail.com',11672,'CABA',1)

--Cliente
select * from Cliente

insert Cliente(dni,apellido,nombre,email,telefono,direccion,estado)
values(1234,'Acevey','Diego','diego@gmail.com',45032,'Corrientes',1)

insert Cliente(dni,apellido,nombre,email,telefono,direccion,estado)
values(4689,'Gomez','Diana','diana@gmail.com',75032,'Corrientes',1)

--Compra
select * from Compra

insert Compra(idTipoFactura,idUsuario,idProveedor,idFormaPago,fechaAlta,total,estado)
values(1,3,1,1,datetime,450,1)

insert Compra(idTipoFactura,idUsuario,idProveedor,idFormaPago,fechaAlta,total,estado)
values(2,3,2,2,datetime,3700,1)

--DetalleCompra
select * from DetalleCompra

insert DetalleCompra(idCompra,idProducto,cantidad,subtotal,estado)
values(1,1,1,300,1)

insert DetalleCompra(idCompra,idProducto,cantidad,subtotal,estado)
values(2,2,1,2500,1)

--Venta
select * from Venta

insert Venta(idTipoFactura,idUsuario,idCliente,idFormaPago,fechaAlta,total,estado)
values(1,3,1,1,NULL,450,1)

insert Venta(idTipoFactura,idUsuario,idCliente,idFormaPago,fechaAlta,total,estado)
values(2,3,2,2,NULL,3700,1)

--DetalleVenta
select * from DetalleVenta

insert DetalleVenta(idVenta,idProducto,cantidad,subtotal,estado)
values(1,1,1,450,1)

insert DetalleVenta(idVenta,idProducto,cantidad,subtotal,estado)
values(2,2,1,3700,1)

