IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposMovimientosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposMovimientosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposMovimientosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Abreviatura
     ,Descripcion
     ,Observaciones
FROM
     [dbo].[TiposMovimientos]
WHERE
    [Id] = @Id
End
