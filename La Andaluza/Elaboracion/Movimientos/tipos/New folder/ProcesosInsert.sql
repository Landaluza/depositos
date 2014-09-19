IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ProcesosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProcesosInsert]
      @Descripcion varchar(50)
     ,@TipoProductoParaLote varchar(1)
     ,@TipoLoteID int
     ,@ConMuestra bit
     ,@TipoMovimientoID int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[Procesos]
     (
      Descripcion
     ,TipoProductoParaLote
     ,TipoLoteID
     ,ConMuestra
     ,TipoMovimientoID
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Descripcion
     ,@TipoProductoParaLote
     ,@TipoLoteID
     ,@ConMuestra
     ,@TipoMovimientoID
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
