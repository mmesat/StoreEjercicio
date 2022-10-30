USE [WebStore]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Miguel mesa>
-- Create date: <09-16-2017>
-- Description:	<Procesudre that inserts into products table>
-- =============================================
CREATE PROCEDURE SP_SetProducts(
	@ProductName varchar(200),
	@Description varchar(500)
	)
AS
BEGIN
	Begin
		BEGIN TRY
			BEGIN TRAN
				insert into [dbo].[TB_Products](
			  [ProductName]
			  ,[Description])
				values (@ProductName,@Description)

			COMMIT TRAN
		END TRY
		BEGIN CATCH
			SELECT
				ERROR_NUMBER() AS Numero_de_Error,
				ERROR_SEVERITY() AS Gravedad_del_Error,
				ERROR_STATE() AS Estado_del_Error,
				ERROR_PROCEDURE() AS Procedimiento_del_Error,
				ERROR_LINE() AS Linea_de_Error,
				ERROR_MESSAGE() AS Mensaje_de_Error;
			Rollback Tran
		End Catch	
	End
END
GO
