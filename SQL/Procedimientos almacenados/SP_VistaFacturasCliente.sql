USE [cinedb]
GO
/****** Object:  StoredProcedure [dbo].[SP_VistaFacturasCliente]    Script Date: 5/3/2020 09:56:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_VistaFacturasCliente]
@id as int
AS
BEGIN
SELECT F.*,
(SELECT COUNT(*) FROM Boleto B WHERE B.boleto_factura = F.id) AS 'numero_boletos'
FROM Vista_FacturaFuncion F
WHERE F.factura_cliente = @id
ORDER BY F.id DESC
END