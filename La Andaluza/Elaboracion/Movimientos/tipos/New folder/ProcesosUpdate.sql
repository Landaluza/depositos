IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProcesosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProcesosUpdate] 
      @Descripcion varchar(50)
     ,@TipoProductoParaLote varchar(1)
     ,@TipoLoteID int
     ,@ConMuestra bit
     ,@TipoMovimientoID int
     ,@ProcesoID int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[Procesos]
SET
      [Descripcion] = @Descripcion
     ,[TipoProductoParaLote] = @TipoProductoParaLote
     ,[TipoLoteID] = @TipoLoteID
     ,[ConMuestra] = @ConMuestra
     ,[TipoMovimientoID] = @TipoMovimientoID
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [ProcesoID] = @ProcesoID

END
