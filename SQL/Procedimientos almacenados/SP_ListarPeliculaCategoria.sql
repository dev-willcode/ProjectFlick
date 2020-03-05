CREATE PROCEDURE SP_ListarPeliculaCategoria
@idPelicula int
AS
BEGIN
SELECT * FROM rel_Pelicula_Categoria
WHERE id_Pelicula = @idPelicula
END

