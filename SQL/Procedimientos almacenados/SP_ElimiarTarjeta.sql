CREATE PROCEDURE SP_ElimiarTarjeta
(
  @id int
)
AS
BEGIN  
DELETE FROM [Tarjetas] 
WHERE id = @id
END

