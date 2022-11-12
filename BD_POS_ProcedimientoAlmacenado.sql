
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