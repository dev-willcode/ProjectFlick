CREATE PROCEDURE SP_GetBanco
@id int
AS
BEGIN
SELECT * FROM dbo.Banco
WHERE Banco.id = @id
END

