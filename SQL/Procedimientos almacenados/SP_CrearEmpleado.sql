CREATE PROCEDURE SP_CrearEmpleado
@empleado_nombres nvarchar(50),
@empleado_cedula nvarchar(50),
@empleado_apellidos nvarchar(50),
@empleado_telefono nvarchar(50),
@empleado_email nvarchar(50),
@empleado_direccion nvarchar(50),
@empleado_usuario int
AS
BEGIN
INSERT INTO Empleado
(
empleado_nombres,
empleado_cedula,
empleado_apellidos,
empleado_telefono,
empleado_email,
empleado_direccion,
empleado_usuario
)
OUTPUT inserted.id
VALUES (
@empleado_nombres,
@empleado_cedula,
@empleado_apellidos,
@empleado_telefono,
@empleado_email,
@empleado_direccion,
@empleado_usuario
)
END
