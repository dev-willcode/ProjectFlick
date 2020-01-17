CREATE PROCEDURE SP_IniciarSesion
@usuario_username varchar(25),
@usuario_password varchar(25)
AS
BEGIN
SELECT 
*
FROM 
[dbo].[Cliente] cliente

/*Subconsulta a tabla de usuarios*/
WHERE cliente.[cliente_usuario] = (
SELECT
[dbo].[Usuario].[id]
FROM
[dbo].[Usuario]
WHERE
[usuario_username] = @usuario_username AND [usuario_password] = @usuario_password
)
END
GO
