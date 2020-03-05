CREATE PROCEDURE SP_GetCategoria
@id int
AS
BEGIN
SELECT * FROM [dbo].Categoria
WHERE [dbo].Categoria.id = @id
END
