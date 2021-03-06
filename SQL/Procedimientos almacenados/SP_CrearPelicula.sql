USE [cinedb]
GO
/****** Object:  StoredProcedure [dbo].[SP_CrearPelicula]    Script Date: 29/2/2020 23:37:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_CrearPelicula]
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
INSERT INTO [Pelicula]
(pelicula_titulo,
pelicula_titulo_original,
pelicula_duracion,
pelicula_tipo_censura,
pelicula_sinopsis,
pelicula_director,
pelicula_reparto,
pelicula_url_trailer,
pelicula_imagen)
OUTPUT inserted.id
VALUES (
@pelicula_titulo,
@pelicula_titulo_original,
@pelicula_duracion,
@pelicula_tipo_censura,
@pelicula_sinopsis,
@pelicula_director,
@pelicula_reparto,
@pelicula_url_trailer,
@pelicula_imagen
)	
END

