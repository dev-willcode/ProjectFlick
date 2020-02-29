CREATE PROCEDURE SP_GetEmpleado
@id int
AS
BEGIN
SELECT * FROM dbo.Empleado
WHERE Empleado.id = @id
END
