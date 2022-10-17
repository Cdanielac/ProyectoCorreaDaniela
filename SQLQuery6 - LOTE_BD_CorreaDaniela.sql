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

insert into Usuario(dni,idRol,usuario,contrase�a,estado)
values(1234,1,'RebeI','Rebe1234',1)
insert into Usuario(dni,idRol,usuario,contrase�a,estado)
values(1345,2,'CajeroIan','ian1234',1)

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
values('Tarjeta D�bito',1)
insert into FormaPago (descripcion,estado)
values('Tarjeta Cr�dito',1)
insert into FormaPago (descripcion,estado)
values('Transferencia Bancaria',1)

--Categoria
select* from Categoria

insert into Categoria (codCategoria,descripcion,estado)
values(12321,'Bazar',1)
insert into Categoria (codCategoria,descripcion,estado)
values(12313,'Decoraci�n',1)

--Proveedor
select * from Proveedor

insert Proveedor(codProveedor,razonSocial,email,telefono,direccion,estado)
values(34536,'Portal Mayotista','portalM@gmail.com',1145632,'Buenos Aires',1)

insert Proveedor(codProveedor,razonSocial,email,telefono,direccion,estado)
values(2344,'Soifer Hnos','soifer@gmail.com',4567,'Bah�a Blanca',1)

insert Proveedor(codProveedor,razonSocial,email,telefono,direccion,estado)
values(12344,'Bazar 380','bazar380@gmail.com',11672,'CABA',1)

--Cliente
select * from Cliente

insert Cliente(dni,apellido,nombre,email,telefono,direccion,estado)
values(34667876,'Acevey','Diego','diego@gmail.com',45032,'Corrientes',1)

insert Cliente(dni,apellido,nombre,email,telefono,direccion,estado)
values(41234564,'Gomez','Diana','diana@gmail.com',75032,'Corrientes',1)

--Producto
select * from Producto

insert Producto(codProducto,nombre,idCategoria,stock,stockMinimo,idProveedor,precioVenta,descripcion,estado)
values(123124,'Mate',1,25,5,1,850,'Material: forrado en cuero.',1)

insert Producto(codProducto,nombre,idCategoria,stock,stockMinimo,idProveedor,precioVenta,descripcion,estado)
values(34345,'Termo',1,15,5,2,3500,'Material: aluminio',1)

--Venta
select * from Venta

insert Venta(idTipoFactura,idUsuario,idCliente,idFormaPago,fechaAlta,total,estado)
values(1,2,1,1,'2022/09/19',4350,1)

--DetalleVenta
select * from DetalleVenta

insert DetalleVenta(idVenta,idProducto,cantidad,subtotal,estado)
values(2,1,1,850,1)

insert DetalleVenta(idVenta,idProducto,cantidad,subtotal,estado)
values(2,3,1,3500,1)

