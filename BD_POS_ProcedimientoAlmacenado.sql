
USE DB_POS;

CREATE PROCEDURE [dbo].[resguardar]
	@ubicacion VARCHAR(150),
    @nombre VARCHAR(50)
AS 
	DECLARE @direccion varchar(200)  = @ubicacion + @nombre + '.bak'

    BACKUP DATABASE DB_POS 
	TO DISK = @direccion
	WITH FORMAT, 
	MEDIANAME = 'Backup'
GO