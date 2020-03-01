CREATE PROCEDURE SP_ActualizarFuncion
@id int,
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
UPDATE [Funcion]
set funcion_pelicula = @funcion_pelicula,
funcion_sala = @funcion_sala,
funcion_fecha_evento = @funcion_fecha_evento,
funcion_horario = @funcion_horario,
funcion_estado = @funcion_estado,
funcion_precio_boleto = @funcion_precio_boleto,
funcion_fecha_creacion = @funcion_fecha_creacion,
funcion_idioma = @funcion_idioma,
funcion_asientos_disponibles = @funcion_asientos_disponibles
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 	
END

