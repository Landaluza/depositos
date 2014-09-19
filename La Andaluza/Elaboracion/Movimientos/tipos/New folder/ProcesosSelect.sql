IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProcesosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProcesosSelect]
      @ProcesoID int
AS 
BEGIN
SELECT
      ProcesoID
     ,Descripcion
     ,TipoProductoParaLote
     ,TipoLoteID
     ,ConMuestra
     ,TipoMovimientoID
FROM
     [dbo].[Procesos]
WHERE
    [ProcesoID] = @ProcesoID
End
