USE [WebStore]
GO

/****** Object:  Table [dbo].[TB_ProductsCategories]    Script Date: 9/17/2017 1:03:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_ProductsCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProduct] [int] NOT NULL,
	[IdCategory] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Discount] [float] NOT NULL,
 CONSTRAINT [PK_TB_ProductsCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[TB_ProductsCategories]  WITH CHECK ADD  CONSTRAINT [FK_TB_ProductsCategories_Tb_Categories] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[TB_Categories] ([Id])
GO

ALTER TABLE [dbo].[TB_ProductsCategories] CHECK CONSTRAINT [FK_TB_ProductsCategories_Tb_Categories]
GO

ALTER TABLE [dbo].[TB_ProductsCategories]  WITH CHECK ADD  CONSTRAINT [FK_TB_ProductsCategories_TB_Products] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[TB_Products] ([Id])
GO

ALTER TABLE [dbo].[TB_ProductsCategories] CHECK CONSTRAINT [FK_TB_ProductsCategories_TB_Products]
GO

