USE [cinedb]
GO
/****** Object:  StoredProcedure [dbo].[SP_CrearFactura]    Script Date: 5/3/2020 09:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_CrearFactura]
@factura_cliente int,
@factura_funcion int,
@factura_metodo_pago varchar(25),
@factura_fecha_emision datetime,
@factura_estado varchar(25)
AS
BEGIN

DECLARE @factura_numero as int;
SET @factura_numero = (SELECT COUNT(id) FROM Factura) + 1;

INSERT INTO Factura 
OUTPUT inserted.id
VALUES(@factura_cliente,@factura_funcion,@factura_numero,@factura_fecha_emision,@factura_metodo_pago,@factura_estado)
END