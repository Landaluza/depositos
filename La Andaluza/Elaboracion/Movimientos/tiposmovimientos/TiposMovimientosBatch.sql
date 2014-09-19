use[la]
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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposMovimientosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposMovimientosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposMovimientosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[TiposMovimientos]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposMovimientosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposMovimientosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposMovimientosInsert]
      @Abreviatura char
     ,@Descripcion varchar(50)
     ,@Observaciones varchar(3000)
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[TiposMovimientos]
     (
      Abreviatura
     ,Descripcion
     ,Observaciones
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Abreviatura
     ,@Descripcion
     ,@Observaciones
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
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

GO
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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposMovimientosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposMovimientosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposMovimientosUpdate] 
      @Abreviatura char
     ,@Descripcion varchar(50)
     ,@Observaciones varchar(3000)
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[TiposMovimientos]
SET
      [Abreviatura] = @Abreviatura
     ,[Descripcion] = @Descripcion
     ,[Observaciones] = @Observaciones
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
