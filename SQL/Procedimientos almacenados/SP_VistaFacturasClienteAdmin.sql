ALTER PROCEDURE [dbo].[SP_VistaFacturasClienteAdmin]
AS
BEGIN
SELECT F.*,
(SELECT COUNT(*) FROM Boleto B WHERE B.boleto_factura = F.id) AS 'numero_boletos'
FROM Vista_FacturaAdmin F
ORDER BY F.factura_fecha_emision DESC
END