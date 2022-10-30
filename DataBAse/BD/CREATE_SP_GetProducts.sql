USE [WebStore]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Miguel Mesa
-- Create date: <09-16-2017>
-- Description:	<SP whit select alla de data from products.>
-- =============================================
CREATE PROCEDURE SP_GetPRoducts
AS
BEGIN
SELECT [Id]
      ,[ProductName]
      ,[Description]
  FROM [dbo].[TB_Products]
END
GO
