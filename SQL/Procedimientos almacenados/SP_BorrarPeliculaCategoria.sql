ALTER PROCEDURE SP_BorrarPeliculaCategoria
@idPelicula int
AS
BEGIN
DELETE FROM rel_Pelicula_Categoria
WHERE id_Pelicula = @idPelicula
END
