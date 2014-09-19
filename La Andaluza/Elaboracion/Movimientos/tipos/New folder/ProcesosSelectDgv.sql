IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProcesosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProcesosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[Procesos].[ProcesoID] Id
     ,[dbo].[Procesos].[Descripcion]
     ,[dbo].[Procesos].[TipoProductoParaLote]
     ,[dbo].[TiposLotes].[Descripcion]
     ,[dbo].[Procesos].[ConMuestra]
     ,[dbo].[TiposMovimientos].[Descripcion]
FROM
     [dbo].[Procesos]
     INNER JOIN [dbo].[TiposLotes] ON [dbo].[Procesos].[TipoLoteID] = [dbo].[TiposLotes].[TipoLoteID]
     INNER JOIN [dbo].[TiposMovimientos] ON [dbo].[Procesos].[TipoMovimientoID] = [dbo].[TiposMovimientos].[Id]
End
