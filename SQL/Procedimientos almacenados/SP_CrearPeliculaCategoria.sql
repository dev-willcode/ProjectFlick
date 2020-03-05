CREATE PROCEDURE SP_CrearPeliculaCategoria
@id_Pelicula int,
@id_Categoria int
AS
BEGIN
INSERT INTO rel_Pelicula_Categoria
VALUES (@id_Pelicula,@id_Categoria)	
END
