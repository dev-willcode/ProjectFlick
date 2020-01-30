CREATE PROCEDURE SP_BuscarTarjetas
@idCliente int
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM [dbo].[Tarjetas]
WHERE @idCliente = [tarjeta_cliente]
END
GO