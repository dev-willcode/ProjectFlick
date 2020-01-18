CREATE PROCEDURE SP_CategoriasPelicula
@id int
AS
BEGIN
/* Selecciona el nombre de la categoria según la id de pelicula indicado */

SELECT 
Categoria.categoria_nombre AS nombre_cateogria
FROM [dbo].[rel_Pelicula_Categoria] relacion
INNER JOIN [dbo].[Categoria] categoria
ON categoria.id = relacion.id_Categoria
WHERE relacion.id_Pelicula = @id
END
GO
