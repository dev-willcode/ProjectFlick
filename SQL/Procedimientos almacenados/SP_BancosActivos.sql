
CREATE PROCEDURE SP_BancosActivos
AS
BEGIN
SELECT * FROM dbo.Banco
WHERE Banco.banco_estado = 1
END
GO
