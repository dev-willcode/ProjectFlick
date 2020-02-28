CREATE PROCEDURE SP_ActualizarFactura
@id int,
@factura_cliente int,
@factura_funcion int,
@factura_metodo_pago varchar(25),
@factura_fecha_emision datetime,
@factura_estado varchar(25)
AS
BEGIN
UPDATE [Factura]
set factura_cliente = @factura_cliente,
factura_funcion = @factura_funcion,
factura_metodo_pago = @factura_metodo_pago,
factura_fecha_emision = @factura_fecha_emision,
factura_estado = @factura_estado
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 
END

