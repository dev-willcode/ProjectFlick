USE [cinedb]
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarPeliculasP]    Script Date: 2/3/2020 09:58:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_ListarPeliculasP]
AS
BEGIN
SELECT *
FROM V_PeliculaP
END