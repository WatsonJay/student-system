USE [db_libary]
GO
/****** Object:  Table [dbo].[tb_answer]    Script Date: 2017/7/31 11:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_answer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[qusetionId] [int] NOT NULL,
	[intro] [nchar](2000) NOT NULL,
	[answerName] [nchar](10) NOT NULL,
	[fileName] [nchar](10) NULL,
	[answertime] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_book]    Script Date: 2017/7/31 11:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_book](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[autor] [nvarchar](50) NOT NULL,
	[pubname] [nvarchar](100) NOT NULL,
	[date] [date] NULL,
	[price] [int] NOT NULL,
	[code] [nchar](10) NOT NULL,
	[picture] [image] NULL,
	[about] [nvarchar](1000) NULL,
	[pagecode] [int] NULL,
	[list] [nvarchar](300) NULL,
	[download] [nvarchar](300) NULL,
 CONSTRAINT [PK_tb_book] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_bookcomment]    Script Date: 2017/7/31 11:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_bookcomment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[bookname] [nchar](10) NOT NULL,
	[commenter] [nchar](10) NOT NULL,
	[date] [datetime] NOT NULL,
	[comment] [nchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_borrow]    Script Date: 2017/7/31 11:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_borrow](
	[borrower] [nchar](10) NOT NULL,
	[borrowbook] [nvarchar](50) NOT NULL,
	[borrowbookcode] [nchar](10) NOT NULL,
	[borrowdate] [date] NOT NULL,
	[returntime] [date] NOT NULL,
	[returned] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_question]    Script Date: 2017/7/31 11:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_question](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nchar](20) NOT NULL,
	[type] [nchar](10) NOT NULL,
	[about] [nchar](1000) NOT NULL,
	[filename] [nchar](20) NULL,
	[uploadTime] [datetime] NOT NULL,
	[questionerId] [nchar](10) NOT NULL,
	[fileExtension] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_User]    Script Date: 2017/7/31 11:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_User](
	[name] [nvarchar](50) NOT NULL,
	[student_name] [nvarchar](50) NOT NULL,
	[student_id] [nchar](10) NOT NULL,
	[subject] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[phone] [char](15) NULL,
	[qq] [char](15) NULL,
	[level] [bit] NOT NULL,
	[borrownum] [int] NOT NULL,
	[online] [bit] NOT NULL,
	[headima] [image] NULL,
	[signature] [nvarchar](200) NULL,
	[onlinedate] [datetime] NULL,
 CONSTRAINT [PK_tb_User] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tb_borrow]  WITH CHECK ADD  CONSTRAINT [FK_tb_borrow_tb_book] FOREIGN KEY([borrowbookcode])
REFERENCES [dbo].[tb_book] ([code])
GO
ALTER TABLE [dbo].[tb_borrow] CHECK CONSTRAINT [FK_tb_borrow_tb_book]
GO
ALTER TABLE [dbo].[tb_borrow]  WITH CHECK ADD  CONSTRAINT [FK_tb_borrow_tb_User] FOREIGN KEY([borrower])
REFERENCES [dbo].[tb_User] ([student_id])
GO
ALTER TABLE [dbo].[tb_borrow] CHECK CONSTRAINT [FK_tb_borrow_tb_User]
GO
