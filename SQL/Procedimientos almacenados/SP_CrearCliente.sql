CREATE PROCEDURE SP_CrearCliente
@cliente_cedula varchar(50),
@cliente_apellidos varchar(50),
@cliente_nombres varchar(50),
@cliente_telefono varchar(50),
@cliente_email varchar(50),
@cliente_direccion varchar(50),
@cliente_usuario int
AS
BEGIN
INSERT INTO [Cliente]
OUTPUT inserted.id
values (
@cliente_cedula,
@cliente_apellidos,
@cliente_nombres,
@cliente_telefono,
@cliente_email,
@cliente_direccion,
@cliente_usuario
)
END
GO
