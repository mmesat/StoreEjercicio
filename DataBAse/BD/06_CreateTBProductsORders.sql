USE [WebStore]
GO

/****** Object:  Table [dbo].[TB_ProductsOrders]    Script Date: 9/17/2017 1:03:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_ProductsOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdOrders] [int] NOT NULL,
	[IdProducts] [int] NOT NULL,
 CONSTRAINT [PK_TB_CustomersOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[TB_ProductsOrders]  WITH CHECK ADD  CONSTRAINT [FK_TB_ProductsOrders_TB_Orders] FOREIGN KEY([IdOrders])
REFERENCES [dbo].[TB_Orders] ([Id])
GO

ALTER TABLE [dbo].[TB_ProductsOrders] CHECK CONSTRAINT [FK_TB_ProductsOrders_TB_Orders]
GO

ALTER TABLE [dbo].[TB_ProductsOrders]  WITH CHECK ADD  CONSTRAINT [FK_TB_ProductsOrders_TB_Products] FOREIGN KEY([IdProducts])
REFERENCES [dbo].[TB_Products] ([Id])
GO

ALTER TABLE [dbo].[TB_ProductsOrders] CHECK CONSTRAINT [FK_TB_ProductsOrders_TB_Products]
GO

