
USE DB_POS;

/*CREATE PROCEDURE [dbo].[resguardar]
	@ubicacion VARCHAR(150),
    @nombre VARCHAR(50)
AS 
	DECLARE @direccion varchar(200)  = @ubicacion + @nombre + '.bak'

    BACKUP DATABASE DB_POS 
	TO DISK = @direccion
	WITH FORMAT, 
	MEDIANAME = 'Backup'
GO*/

CREATE PROCEDURE dbo.crearBackup
	@ubicacion VARCHAR(150),
    @nombre VARCHAR(50)
AS
	DECLARE @direccion varchar(200)
	SET @direccion = @ubicacion + '\' + @nombre + '.bak'

	BACKUP DATABASE DB_POS
	TO DISK = @direccion
	WITH FORMAT ,
		MEDIANAME = 'Backup_BD_Pos'
GO

CREATE PROCEDURE dbo.productosMasVendidos
	@ubicacion VARCHAR(150),
    @nombre VARCHAR(50)
AS
	DECLARE @direccion varchar(200)
	SET @direccion = @ubicacion + '\' + @nombre + '.bak'

	BACKUP DATABASE DB_POS
	TO DISK = @direccion
	WITH FORMAT ,
		MEDIANAME = 'Backup_BD_Pos'
GO

/*CREATE PROCEDURE dbo.restaurar
	@direccion VARCHAR(400)
AS
	RESTORE DATABASE DB_POS
	FROM DISK = @direccion
GO*/

/*
EXEC crearBackup
     @ubicacion = 'C:\Users\Danie\Desktop\'   
    , @nombre = 'prueba';
GO*/

----------VENTAS POR FECHA-----------
CREATE PROCEDURE dbo.ventasPorFecha
	@fechaDesde datetime,
	@fechaHasta datetime
AS
	SELECT p.nombre as [Producto], dv.subtotal as [Subtotal] FROM DetalleVenta dv
	INNER JOIN Producto p ON p.idProducto = dv.idProducto
	INNER JOIN Venta v ON v.idVenta = dv.idVenta
	where v.fechaAlta Between @fechaDesde and @fechaHasta
GO

/*EXEC ventasPorFecha
	@fechaDesde = '2022/11/16',
	@fechaHasta = '2022/11/16';
GO;*/

-------PRODUCTOS MÁS VENDIDOS---------------------
CREATE PROCEDURE dbo.productosMasVendidos
	@Mes datetime
AS
	SELECT TOP 10 p.nombre as [Producto] FROM DetalleVenta dv
	INNER JOIN Producto p ON p.idProducto = dv.idProducto
	INNER JOIN Venta v ON v.idVenta = dv.idVenta
	where MONTH(v.fechaAlta) = 11
	GROUP BY p.nombre 
GO




