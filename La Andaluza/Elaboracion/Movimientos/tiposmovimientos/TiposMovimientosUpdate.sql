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
