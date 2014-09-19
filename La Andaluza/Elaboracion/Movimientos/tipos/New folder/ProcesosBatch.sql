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

GO
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

GO
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

GO
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

GO
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

GO
