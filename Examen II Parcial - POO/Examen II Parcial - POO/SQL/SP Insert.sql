CREATE PROCEDURE SP_Insert (
	@Nombre varchar(200),
	@Genero nvarchar(100),
	@FechaCreacion nvarchar(4),
	@EstadoArtista bit
	)
AS
BEGIN
	INSERT INTO Music.Cancion(Nombre, Genero, AñoCreacion)
	VALUES (@Nombre, @Genero, @FechaCreacion)
END


