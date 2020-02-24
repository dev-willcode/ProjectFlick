CREATE PROCEDURE SP_CrearHorario
@hora_inicio time(7),
@hora_fin time(7)
AS
BEGIN
INSERT INTO Horarios
OUTPUT inserted.id
values (
@hora_inicio,
@hora_fin
)
END
