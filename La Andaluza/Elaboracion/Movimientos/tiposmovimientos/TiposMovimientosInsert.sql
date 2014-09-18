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
