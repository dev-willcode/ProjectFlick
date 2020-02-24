CREATE PROCEDURE SP_ActualizarHorario
@id int,
@hora_inicio time(7),
@hora_fin time(7)
AS
BEGIN
UPDATE [Horarios]
set horario_inicio = @hora_inicio,
horario_fin = @hora_fin
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 	
END
