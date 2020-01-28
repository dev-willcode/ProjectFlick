CREATE PROCEDURE SP_ActualizarCliente
@id int,
@cliente_cedula varchar(50),
@cliente_apellidos varchar(50),
@cliente_nombres varchar(50),
@cliente_telefono varchar(50),
@cliente_email varchar(50),
@cliente_direccion varchar(50)
AS
BEGIN
UPDATE [Cliente]
set [cliente_cedula] = @cliente_cedula,
[cliente_apellidos] = @cliente_apellidos,
[cliente_nombres] = @cliente_nombres,
[cliente_telefono] = @cliente_telefono,
[cliente_email] = @cliente_email,
[cliente_direccion] = @cliente_direccion
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 
END
GO
