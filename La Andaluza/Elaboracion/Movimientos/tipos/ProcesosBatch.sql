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
     ,@TipoMovimiento varchar(1)
     ,@TipoLoteID int
     ,@ConMuestra bit
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[Procesos]
     (
      Descripcion
     ,TipoProductoParaLote
     ,TipoMovimiento
     ,TipoLoteID
     ,ConMuestra
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Descripcion
     ,@TipoProductoParaLote
     ,@TipoMovimiento
     ,@TipoLoteID
     ,@ConMuestra
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
     ,TipoMovimiento
     ,TipoLoteID
     ,ConMuestra
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
     ,[dbo].[Procesos].[TipoMovimiento]
     ,[dbo].[TiposLotes].[Descripcion]
     ,[dbo].[Procesos].[ConMuestra]
FROM
     [dbo].[Procesos]
     INNER JOIN [dbo].[TiposLotes] ON [dbo].[Procesos].[TipoLoteID] = [dbo].[TiposLotes].[TipoLoteID]
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
     ,@TipoMovimiento varchar(1)
     ,@TipoLoteID int
     ,@ConMuestra bit
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
     ,[TipoMovimiento] = @TipoMovimiento
     ,[TipoLoteID] = @TipoLoteID
     ,[ConMuestra] = @ConMuestra
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [ProcesoID] = @ProcesoID

END

GO
