/****** Object:  StoredProcedure [dbo].[SP_CrearBanco]    Script Date: 7/2/2020 11:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_CrearBanco]
(
@banco_nombre nvarchar(25)
)
AS
BEGIN
INSERT INTO [Banco] 
OUTPUT inserted.id
values (@banco_nombre,1)
END

