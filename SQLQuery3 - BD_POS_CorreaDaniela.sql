CREATE DATABASE DB_POS

GO

USE DB_POS

GO

create table Rol(
idRol int identity,
descripcion varchar(50),
fechaAlta datetime default getdate(),
CONSTRAINT PK_Rol PRIMARY KEY (idRol),
)
go

create table Proveedor(
idProveedor int identity,
codProveedor int unique,
razonSocial varchar(50),
email varchar(100) unique,
telefono int,
direccion varchar(100),
estado int default 1,
fechaAlta datetime default getdate(),
CONSTRAINT PK_Proveedor PRIMARY KEY (idProveedor)
)

go

create table Cliente(
idCliente int identity,
dni int unique,
apellido varchar(100),
nombre varchar(100),
email varchar(100) unique,
telefono int,
direccion varchar(100),
estado int default 1,
fechaAlta datetime default getdate(),
CONSTRAINT PK_Cliente PRIMARY KEY (idCliente)
)

go

create table Empleado(
dni int,
apellido varchar(100),
nombre varchar(100),
email varchar(100) unique,
direccion varchar(100),
telefono int,
estado int default 1,
fechaAlta datetime default getdate(),
CONSTRAINT PK_Empleado PRIMARY KEY (dni)
)

go

create table Usuario(
idUsuario int identity,
dni int not null unique,
idRol int not null,
usuario varchar(50) unique,
contraseña varchar(500),
estado int default 1,
fechaAlta datetime default getdate(),
CONSTRAINT FK_Usuario_Empleado FOREIGN KEY (dni) REFERENCES Empleado(dni),
CONSTRAINT FK_Usuario_Rol FOREIGN KEY (idRol) REFERENCES Rol(idRol),
CONSTRAINT PK_Usuario PRIMARY KEY (idUsuario)
)

go

create table Categoria(
idCategoria int identity,
codCategoria int unique,
descripcion varchar(100),
estado int default 1,
fechaAlta datetime default getdate(),
CONSTRAINT PK_Categoria PRIMARY KEY (idCategoria)
)

go

create table Producto(
idProducto int identity,
codProducto int unique,
nombre varchar(100),
idCategoria int not null,
stock int not null default 1,
stockMinimo int not null default 1,
idProveedor int not null, 
precioVenta decimal(10,2),
descripcion varchar(500),
estado int default 1,
fechaAlta datetime default getdate(),
CONSTRAINT CK_Producto_Precio Check (precioVenta > 0),
CONSTRAINT FK_Producto_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria),
CONSTRAINT FK_Producto_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(idProveedor),
CONSTRAINT PK_Producto PRIMARY KEY (idProducto)
)

go

create table TipoFactura(
idTipoFactura int identity,
descripcion varchar(500),
estado int default 1,
fechaAlta datetime default getdate(),
CONSTRAINT PK_TipoFactura PRIMARY KEY (idTipoFactura)
)

go

create table FormaPago(
idFormaPago int identity,
descripcion varchar(500),
estado int default 1,
fechaAlta datetime default getdate(),
CONSTRAINT PK_FormaPago PRIMARY KEY (idFormaPago)
)

go

create table Venta(
idVenta int identity,
idTipoFactura int not null,
idUsuario int not null,
idCliente int not null,
idFormaPago int not null,
fechaAlta datetime default getdate(),
total decimal(10,2),
estado int default 1,
CONSTRAINT CK_Venta_Total Check (total > 0),
CONSTRAINT FK_Venta_TipoFactura FOREIGN KEY (idTipoFactura) REFERENCES TipoFactura(idTipoFactura),
CONSTRAINT FK_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario),
CONSTRAINT FK_Venta_Cliente FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente),
CONSTRAINT FK_Venta_FormaPago FOREIGN KEY (idFormaPago) REFERENCES FormaPago(idFormaPago),
CONSTRAINT PK_Venta PRIMARY KEY (idVenta)
)
go

create table DetalleVenta(
idDetVenta int identity,
idVenta int,
idProducto int,
cantidad int,
subtotal decimal(10,2) default 0,
estado int,
CONSTRAINT CK_DetalleVenta_Cantidad Check (cantidad > 0),
CONSTRAINT FK_DetalleVenta_Venta FOREIGN KEY (idVenta) REFERENCES Venta(idVenta),
CONSTRAINT FK_DetalleVenta_Producto FOREIGN KEY (idProducto) REFERENCES Producto(idProducto),
CONSTRAINT PK_DetalleVenta PRIMARY KEY (idDetVenta)
)
go