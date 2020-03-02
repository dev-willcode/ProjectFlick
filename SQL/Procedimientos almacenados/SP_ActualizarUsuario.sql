CREATE PROCEDURE SP_ActualizarUsuario
@id int,
@usuario_username nvarchar(25),
@usuario_password nvarchar(25),
@usuario_perfil int
AS
BEGIN
UPDATE [Usuario]
set usuario_username = @usuario_username,
usuario_password = @usuario_password,
usuario_perfil = @usuario_perfil
OUTPUT 'CORRECTO' AS 'RESPONSE'
WHERE [id] = @id 
END
