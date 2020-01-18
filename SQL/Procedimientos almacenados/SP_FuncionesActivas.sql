CREATE PROCEDURE SP_FuncionesActivas
AS
BEGIN
SELECT * 
FROM [dbo].[Vista_Funciones]
WHERE funcion_estado = 'ACTIVO'
END
GO
