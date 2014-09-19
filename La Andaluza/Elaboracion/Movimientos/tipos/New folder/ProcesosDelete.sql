IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProcesosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProcesosDelete] 
      @ProcesoID int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[Procesos]
WHERE
    [ProcesoID] = @ProcesoID

END
