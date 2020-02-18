CREATE PROCEDURE SP_GetEmpresa
@id int
AS
BEGIN
SELECT * FROM dbo.Empresa
WHERE Empresa.id = @id
END
