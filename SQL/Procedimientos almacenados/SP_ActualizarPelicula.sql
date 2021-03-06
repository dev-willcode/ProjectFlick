USE [cinedb]
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarPelicula]    Script Date: 1/3/2020 00:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_ActualizarPelicula]
@id int,
@pelicula_titulo nvarchar(50),
@pelicula_titulo_original nvarchar(50),
@pelicula_duracion nvarchar(50),
@pelicula_tipo_censura nvarchar(50),
@pelicula_sinopsis nvarchar(255),
@pelicula_director nvarchar(50),
@pelicula_reparto nvarchar(255),
@pelicula_url_trailer nvarchar(255),
@pelicula_imagen image
AS
BEGIN
UPDATE [Pelicula]
set pelicula_titulo = @pelicula_titulo,
pelicula_titulo_original = @pelicula_titulo_original,
pelicula_duracion = @pelicula_duracion,
pelicula_tipo_censura = @pelicula_tipo_censura,
pelicula_sinopsis = @pelicula_sinopsis,
pelicula_director = @pelicula_director,
pelicula_reparto = @pelicula_reparto,
pelicula_url_trailer = @pelicula_url_trailer,
pelicula_imagen = @pelicula_imagen
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 	
END
