IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposMovimientosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposMovimientosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposMovimientosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[TiposMovimientos].[Id] Id
     ,[dbo].[TiposMovimientos].[Abreviatura]
     ,[dbo].[TiposMovimientos].[Descripcion]
     ,[dbo].[TiposMovimientos].[Observaciones]
FROM
     [dbo].[TiposMovimientos]
End
