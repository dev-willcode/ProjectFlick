ALTER PROCEDURE [dbo].[SP_BorrarClientes]
@id int
AS
BEGIN
DELETE FROM Cliente 
OUTPUT 'ELIMINADO' AS 'RESPONSE'
WHERE  id = @id
END

