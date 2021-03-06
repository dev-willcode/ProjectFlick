/****** Object:  StoredProcedure [dbo].[SP_CrearTarjeta]    Script Date: 7/2/2020 11:34:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_CrearTarjeta]
(
@tarjeta_cliente int,
@tarjeta_tipo nvarchar(25),
@tarjeta_banco int,
@tarjeta_numero nvarchar(50),
@tarjeta_ccv nvarchar(3),
@tarjeta_ano int, 
@tarjeta_mes nvarchar(50),
@tarjeta_propietario nvarchar(50)
)
AS
BEGIN
INSERT INTO [Tarjetas]
OUTPUT inserted.id
values (
@tarjeta_cliente,
@tarjeta_tipo,
@tarjeta_banco,
@tarjeta_numero,
@tarjeta_ccv,
@tarjeta_ano,
@tarjeta_mes,
@tarjeta_propietario
)
END