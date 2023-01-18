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
CREATE PROCEDURE SP_ActualizarEmpleado
@id int,
@empleado_nombres nvarchar(50),
@empleado_cedula nvarchar(50),
@empleado_apellidos nvarchar(50),
@empleado_telefono nvarchar(50),
@empleado_email nvarchar(50),
@empleado_direccion nvarchar(50),
@empleado_usuario int
AS
BEGIN
UPDATE [Empleado]
set empleado_nombres = @empleado_nombres,
empleado_cedula = @empleado_cedula,
empleado_apellidos = @empleado_apellidos,
empleado_telefono = @empleado_telefono,
empleado_email = @empleado_email,
empleado_direccion = @empleado_direccion,
empleado_usuario = @empleado_usuario
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 
END
GO
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
GO
