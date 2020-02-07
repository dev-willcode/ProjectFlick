CREATE PROCEDURE SP_CrearTarjeta
(
@tarjeta_cliente int,
@tarjeta_tipo nvarchar(25),
@tarjeta_banco int,
@tarjeta_numero nvarchar(50),
@tarjeta_digitos_control nchar(4),
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
@tarjeta_digitos_control,
@tarjeta_ccv,
@tarjeta_ano,
@tarjeta_mes,
@tarjeta_propietario
)
END