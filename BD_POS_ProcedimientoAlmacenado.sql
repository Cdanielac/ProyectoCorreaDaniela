
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
/*CREATE PROCEDURE dbo.ventasPorFecha
	@fechaDesde datetime,
	@fechaHasta datetime
AS
	SELECT p.nombre as [Producto], dv.subtotal as [Subtotal] FROM DetalleVenta dv
	INNER JOIN Producto p ON p.idProducto = dv.idProducto
	INNER JOIN Venta v ON v.idVenta = dv.idVenta
	where v.fechaAlta Between @fechaDesde and @fechaHasta
GO*/

if object_id('antiguedadEmpleados') is not null DROP PROCEDURE antiguedadEmpleados

----------VENTAS POR FECHA-----------
CREATE PROCEDURE dbo.ventasPorFecha
	@fechaDesde datetime,
	@fechaHasta datetime
AS
	SELECT idVenta as [Nro_Venta], total as [Total] FROM Venta
	where fechaAlta Between @fechaDesde and @fechaHasta
GO

/*EXEC ventasPorFechaCajero
	@fechaDesde = '2022/11/16',
	@fechaHasta = '2022/11/16',
	@idCajero = 4
GO;*/

------VENTAS POR FECHA SEGUN CAJERO
CREATE PROCEDURE dbo.ventasPorFechaCajero
	@fechaDesde datetime,
	@fechaHasta datetime,
	@idCajero int
AS
	SELECT idVenta as [Nro_Venta], total as [Total] FROM Venta
	where fechaAlta Between @fechaDesde and @fechaHasta and idUsuario = @idCajero;
GO

-------ACUMULADO POR CAJERO
CREATE PROCEDURE dbo.ventasPorCajero
AS
	SELECT SUM(Venta.total) as [Total], CONCAT(Empleado.apellido, ' ' , Empleado.nombre) as [Empleado] FROM Venta
	INNER JOIN Usuario ON Usuario.idUsuario = Venta.idUsuario
	INNER JOIN Empleado ON Empleado.dni = Usuario.dni
	GROUP BY CONCAT(Empleado.apellido, ' ' , Empleado.nombre)
GO

------------ACUMULADO POR CATEGORIA
CREATE PROCEDURE dbo.ventasPorCategoria
AS
	SELECT Categoria.descripcion as [Categoria] ,SUM(DetalleVenta.subtotal) as [Total] FROM DetalleVenta
	INNER JOIN Producto ON Producto.idProducto = DetalleVenta.idProducto
	INNER JOIN Categoria ON Producto.idCategoria = Categoria.idCategoria
	GROUP BY Categoria.descripcion
	ORDER BY SUM(DetalleVenta.subtotal) DESC
GO


-------PRODUCTOS MÁS VENDIDOS---------------------
CREATE PROCEDURE dbo.productosMasVendidos
	@Mes int
AS
	SELECT TOP 10 p.nombre as [Producto], dv.cantidad AS [Cantidad] FROM DetalleVenta dv
	INNER JOIN Producto p ON p.idProducto = dv.idProducto
	INNER JOIN Venta v ON v.idVenta = dv.idVenta
	where MONTH(v.fechaAlta) = @Mes
	GROUP BY p.nombre, dv.cantidad
	ORDER BY dv.cantidad DESC
GO

--------VENTAS POR MES
CREATE PROCEDURE dbo.ventasPorMes
	@Year DATETIME
AS
	SELECT 
			CASE WHEN MONTH(fechaAlta) = 1 THEN 'Enero' 
				 WHEN MONTH(fechaAlta) = 2 THEN 'Febrero' 
				 WHEN MONTH(fechaAlta) = 3 THEN 'Marzo' 
				 WHEN MONTH(fechaAlta) = 4 THEN 'Abril' 
				 WHEN MONTH(fechaAlta) = 5 THEN 'Mayo' 
				 WHEN MONTH(fechaAlta) = 6 THEN 'Junio' 
				 WHEN MONTH(fechaAlta) = 7 THEN 'Julio' 
				 WHEN MONTH(fechaAlta) = 8 THEN 'Agosto' 
				 WHEN MONTH(fechaAlta) = 9 THEN 'Septiembre' 
				 WHEN MONTH(fechaAlta) = 10 THEN 'Octubre' 
				 WHEN MONTH(fechaAlta) = 11 THEN 'Noviembre' 
				 ELSE 'Diciembre'
			END as [Mes],
			SUM(total) as [Total] FROM Venta
			WHERE YEAR(fechaAlta) = YEAR(@Year)
	GROUP BY MONTH(fechaAlta)
GO

use DB_POS;
-----PRODUCTOS PROXIMOS A ACABAR
CREATE PROCEDURE dbo.stockMinimo
AS
	SELECT 
			nombre [Producto],
			stock as [Stock] FROM Producto
			WHERE stock <= stockMinimo
GO
---SELECT * FROM Empleado
----------ANTIGUEDAD DE EMPLEADOS
CREATE PROCEDURE dbo.antiguedadEmpleados
AS
	SELECT TOP 5
			CONCAT(nombre,' ',apellido) [Empleado],
			DATEDIFF(MONTH,fechaAlta,GETDATE()) as [Meses Antiguedad] FROM Empleado
			ORDER BY DATEDIFF(MONTH,fechaAlta,GETDATE()) DESC
GO

-----CANTIDAD DE USUARIOS POR ROL
CREATE PROCEDURE dbo.cantUsuariosRol
AS
	SELECT 
			COUNT(u.idUsuario), r.descripcion [Rol]
			 FROM Usuario u
			INNER JOIN Rol r ON r.idRol = u.idRol
			GROUP BY r.descripcion
			
GO

-----CLIENTES MÁS FRECUENTES
CREATE PROCEDURE dbo.clientesMasFrecuentes
AS
	SELECT TOP 5
			SUM(v.total) [Acumulado],
			CONCAT(c.nombre,' ',c.apellido) [Cliente]
			 FROM Cliente c
			INNER JOIN Venta v ON v.idCliente = c.idCliente
			GROUP BY CONCAT(c.nombre,' ',c.apellido)
			ORDER BY COUNT(v.idVenta) DESC
			
GO

CREATE PROCEDURE dbo.clientesMasFrecuentes
AS
	SELECT TOP 5
			SUM(v.total) [Acumulado],
			CONCAT(c.nombre,' ',c.apellido) [Cliente]
			 FROM Cliente c
			INNER JOIN Venta v ON v.idCliente = c.idCliente
			GROUP BY CONCAT(c.nombre,' ',c.apellido)
			ORDER BY COUNT(v.idVenta) DESC
			
GO




