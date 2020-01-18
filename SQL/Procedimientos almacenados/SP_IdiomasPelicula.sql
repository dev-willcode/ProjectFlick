CREATE PROCEDURE SP_IdiomasPelicula
@id int
AS
BEGIN
SELECT

/* Selecciona el listado de idiomas para la pelicula especificada */

idioma.idioma_abreviatura
FROM [dbo].[Funcion] funcion
INNER JOIN [dbo].[Idiomas] idioma
ON idioma.id = funcion.funcion_idioma
WHERE funcion.funcion_pelicula = @id
END
GO
