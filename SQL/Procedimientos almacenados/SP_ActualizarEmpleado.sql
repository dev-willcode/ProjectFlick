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