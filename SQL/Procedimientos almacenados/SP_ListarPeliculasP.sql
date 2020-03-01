ALTER PROCEDURE SP_ListarPeliculasP
AS
BEGIN
SELECT Pelicula.pelicula_titulo as 'Titulo', 
Pelicula.pelicula_titulo_original as 'Titulo Original', 
Pelicula.pelicula_duracion as 'Duracion', Pelicula.pelicula_tipo_censura as 'Censura', 
Pelicula.pelicula_director as 'Director'
FROM Pelicula
END

