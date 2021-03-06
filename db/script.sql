USE [QLLT]
GO
/****** Object:  Table [dbo].[NgonNgu]    Script Date: 3/16/2016 4:18:32 PM ******/
/****** Tao moi: Nguyen Tuan Quang  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgonNgu](
	[MaNN] [bigint] IDENTITY(1,1) NOT NULL,
	[TenNN] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](1000) NULL,
	[STT] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_NgonNgu] PRIMARY KEY CLUSTERED 
(
	[MaNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

