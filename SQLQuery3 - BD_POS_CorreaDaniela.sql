CREATE DATABASE DB_POS

GO

USE DB_POS

GO

create table Rol(
idRol int primary key identity,
descripcion varchar(50),
fechaAlta datetime default getdate()
)

go

create table Proveedor(
idProveedor int primary key identity,
codProveedor int,
razonSocial varchar(50),
email varchar(100),
telefono int,
direccion varchar(100),
estado int,
fechaAlta datetime default getdate()
)

go

create table Cliente(
idCliente int primary key identity,
dni int,
apellido varchar(100),
nombre varchar(100),
email varchar(100),
telefono int,
direccion varchar(100),
estado int,
fechaAlta datetime default getdate()
)

go

create table Empleado(
dni int primary key,
apellido varchar(100),
nombre varchar(100),
email varchar(100),
direccion varchar(100),
telefono int,
estado int,
fechaAlta datetime default getdate()
)

go

create table Usuario(
idUsuario int primary key identity,
dni int not null,
idRol int,
usuario varchar(50),
contraseña varchar(500),
estado int,
fechaAlta datetime default getdate(),
CONSTRAINT FK_Usuario_Empleado FOREIGN KEY (dni) REFERENCES Empleado(dni),
CONSTRAINT FK_Usuario_Rol FOREIGN KEY (idRol) REFERENCES Rol(idRol)
)

go

create table Categoria(
idCategoria int primary key identity,
codCategoria int,
descripcion varchar(100),
estado int,
fechaAlta datetime default getdate()
)

go

create table Producto(
idProducto int primary key identity,
codProducto int,
nombre varchar(100),
idCategoria int not null,
stock int not null default 1,
stockMinimo int not null default 1,
precioCompra decimal(10,2) default 0,
precioVenta decimal(10,2) default 0,
descripcion varchar(500),
estado int,
fechaAlta datetime default getdate(),
CONSTRAINT FK_Producto_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
)

go

create table TipoFactura(
idTipoFactura int primary key identity,
descripcion varchar(500),
estado int,
fechaAlta datetime default getdate()
)

go

create table FormaPago(
idFormaPago int primary key identity,
descripcion varchar(500),
estado int,
fechaAlta datetime default getdate()
)

go

create table Compra(
idCompra int primary key identity,
idTipoFactura int not null,
idUsuario int not null,
idProveedor int not null,
idFormaPago int not null,
fechaAlta datetime default getdate(),
total decimal(10,2) default 0,
estado int,
CONSTRAINT FK_Compra_TipoFactura FOREIGN KEY (idTipoFactura) REFERENCES TipoFactura(idTipoFactura),
CONSTRAINT FK_Compra_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario),
CONSTRAINT FK_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(idProveedor),
CONSTRAINT FK_Compra_FormaPago FOREIGN KEY (idFormaPago) REFERENCES FormaPago(idFormaPago)
)

go

create table DetalleCompra(
idDetCompra int primary key identity,
idCompra int not null,
idProducto int not null,
cantidad int,
subtotal decimal(10,2) default 0,
estado int,
CONSTRAINT FK_DetalleCompra_Compra FOREIGN KEY (idCompra) REFERENCES Compra(idCompra),
CONSTRAINT FK_DetalleCompra_Producto FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
)

go

create table Venta(
idVenta int primary key identity,
idTipoFactura int not null,
idUsuario int not null,
idCliente int not null,
idFormaPago int not null,
fechaAlta datetime default getdate(),
total decimal(10,2) default 0,
estado int,
CONSTRAINT FK_Venta_TipoFactura FOREIGN KEY (idTipoFactura) REFERENCES TipoFactura(idTipoFactura),
CONSTRAINT FK_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario),
CONSTRAINT FK_Venta_Cliente FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente),
CONSTRAINT FK_Venta_FormaPago FOREIGN KEY (idFormaPago) REFERENCES FormaPago(idFormaPago)
)

go

create table DetalleVenta(
idDetVenta int primary key identity,
idVenta int references Venta(idVenta),
idProducto int references Producto(idProducto),
cantidad int,
subtotal decimal(10,2) default 0,
estado int,
)
go