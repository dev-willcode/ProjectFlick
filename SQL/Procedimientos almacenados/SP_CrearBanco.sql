CREATE PROCEDURE SP_CrearBanco
(
@banco_nombre nvarchar(25)
)
AS
BEGIN
INSERT INTO [Banco] 
OUTPUT inserted.id
values (@banco_nombre,'true')
END

