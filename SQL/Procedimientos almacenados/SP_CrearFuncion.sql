USE [cinedb]
GO
/****** Object:  StoredProcedure [dbo].[SP_CrearFuncion]    Script Date: 1/3/2020 18:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_CrearFuncion]
(
@funcion_pelicula int,
@funcion_sala int,
@funcion_fecha_evento date,
@funcion_horario int,
@funcion_estado nvarchar(25),
@funcion_precio_boleto decimal(18,0),
@funcion_fecha_creacion date,
@funcion_idioma int,
@funcion_asientos_disponibles int
)
AS
BEGIN
INSERT INTO [Funcion]
VALUES(
@funcion_pelicula,
@funcion_sala,
@funcion_fecha_evento,
@funcion_horario,
@funcion_estado,
@funcion_precio_boleto,
@funcion_fecha_creacion,
@funcion_idioma,
@funcion_asientos_disponibles
)
END