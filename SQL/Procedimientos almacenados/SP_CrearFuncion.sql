CREATE PROCEDURE SP_CrearFuncion
@funcion_pelicula int,
@funcion_sala int,
@funcion_fecha_evento date,
@funcion_horario int,
@funcion_estado nvarchar(25),
@funcion_precio_boleto decimal(18,0),
@funcion_fecha_creacion date,
@funcion_idioma int,
@funcion_asientos_disponibles int
AS
BEGIN
INSERT INTO Funcion
(funcion_pelicula,
funcion_sala,
funcion_fecha_evento,
funcion_horario,
funcion_estado,
funcion_precio_boleto,
funcion_fecha_creacion,
funcion_idioma,
funcion_asientos_disponibles)
OUTPUT inserted.id
VALUES (
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
