CREATE PROCEDURE SP_BorrarFuncion
@id int
AS
BEGIN
DELETE FROM Funcion 
OUTPUT 'ELIMINADO' AS 'RESPONSE'
WHERE  id = @id
END