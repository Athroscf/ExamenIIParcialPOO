CREATE PROCEDURE SP_Delete (
	@Nombre varchar(200)
	)
AS
BEGIN
	Delete From Music.Cancion
	Where Nombre = @Nombre
END
