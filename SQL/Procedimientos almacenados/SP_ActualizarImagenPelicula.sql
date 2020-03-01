CREATE PROCEDURE SP_ActualizarImagenPelicula
@id int,
@imagen image
AS
BEGIN
UPDATE Pelicula
SET pelicula_imagen = @imagen
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE id = @id
END
