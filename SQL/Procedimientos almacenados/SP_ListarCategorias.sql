ALTER PROCEDURE SP_ListarCategorias
AS
BEGIN
SELECT * FROM Categoria
END

EXEC SP_ListarCategorias