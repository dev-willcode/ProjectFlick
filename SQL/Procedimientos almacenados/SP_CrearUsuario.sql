CREATE PROCEDURE SP_CrearUsuario
@usuario_username varchar(25),
@usuario_password varchar(25),
@usuario_perfil int
AS
BEGIN
INSERT INTO [Usuario]
OUTPUT inserted.id
values (
@usuario_username,
@usuario_password,
@usuario_perfil
)
END
GO
