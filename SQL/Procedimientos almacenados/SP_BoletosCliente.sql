CREATE PROCEDURE SP_BoletosCliente
(
@idCliente int
)
AS
BEGIN
/* Selecciona un grupo de boletos */
SELECT [Boleto].* 
FROM [Boleto]
/* Cuando la factura del boleto, 
corresponda a las id de las facturas 
de un cliente x */
WHERE [Boleto].boleto_factura IN ( 
SELECT [Factura].id
FROM [Factura]
WHERE [Factura].factura_cliente = @idCliente
)
END
