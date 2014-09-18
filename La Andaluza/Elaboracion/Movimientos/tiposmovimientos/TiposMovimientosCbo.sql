IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposMovimientosCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposMovimientosCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposMovimientosCbo]
AS 
BEGIN
SELECT
      Id
     ,Descripcion
FROM
     [dbo].[TiposMovimientos]
End
