USE [IWSSLSE]
GO
/****** Object:  Table [dbo].[IWS_Categories]    Script Date: 21-01-2023 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IWS_Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[p_id] [int] NULL,
	[category_name] [nvarchar](100) NULL,
	[isdeleted] [bit] NULL,
	[isactive] [bit] NULL,
	[created_by] [int] NULL,
	[created_date] [date] NULL,
	[update_date] [date] NULL,
	[update_by] [int] NULL,
	[hiddenimgstr] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IWS_Courses]    Script Date: 21-01-2023 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IWS_Courses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[add_coures] [varchar](50) NULL,
	[duration] [varchar](50) NULL,
	[fees] [int] NULL,
	[isactive] [bit] NULL,
	[isdeleted] [bit] NULL,
 CONSTRAINT [PK_IWS_Courses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IWS_Exam]    Script Date: 21-01-2023 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IWS_Exam](
	[Exam_Type] [varchar](50) NULL,
	[Exam_Id] [int] IDENTITY(1,1) NOT NULL,
	[Exam_Title] [varchar](50) NULL,
	[Categorie] [varchar](40) NULL,
	[Sub_Categorie] [varchar](50) NULL,
	[Num_Questions] [int] NULL,
	[Isactive] [bit] NULL,
	[Isdeleted] [bit] NULL,
	[Created_By] [int] NULL,
	[Created_Date] [datetime] NULL,
	[Updated_By] [int] NULL,
	[Updated_Date] [datetime] NULL,
	[Is_Optional] [varchar](50) NULL,
	[Is_True_orFalse] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Exam_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IWS_Institute]    Script Date: 21-01-2023 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IWS_Institute](
	[name] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[password] [varchar](50) NULL,
	[Address] [varchar](150) NULL,
	[YourEducation] [varchar](100) NULL,
	[Institute_type] [varchar](50) NULL,
	[Present_job_profession] [varchar](50) NULL,
	[Education_Sector_Experience] [varchar](50) NULL,
	[Your_Comment_query] [varchar](250) NULL,
	[createdone] [datetime] NULL,
	[createdby] [varchar](50) NULL,
	[isActive] [bit] NULL,
	[isdeleted] [bit] NULL,
	[updatedon] [datetime] NULL,
	[opdatedby] [varchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Institute_Pre_School] [varchar](30) NULL,
	[isapprove] [bit] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IWS_Login]    Script Date: 21-01-2023 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IWS_Login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NULL,
	[password] [varchar](150) NULL,
	[type] [varchar](200) NULL,
	[isactive] [bit] NULL,
	[isdeleted] [bit] NULL,
	[created_by] [int] NULL,
	[created_date] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_date] [datetime] NULL,
	[UserName] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IWS_Score]    Script Date: 21-01-2023 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IWS_Score](
	[Exam_id] [int] NULL,
	[Question_NO] [int] IDENTITY(1,1) NOT NULL,
	[Question] [varchar](50) NULL,
	[Opction1] [varchar](50) NULL,
	[Opction2] [varchar](50) NULL,
	[Opction3] [varchar](50) NULL,
	[Opction4] [varchar](50) NULL,
	[Answer] [varchar](30) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[Created_Date] [date] NULL,
	[Created_By] [int] NULL,
	[Updated_By] [int] NULL,
	[Updated_Date] [date] NULL,
	[Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Question_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IWS_Student]    Script Date: 21-01-2023 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IWS_Student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NULL,
	[f_name] [varchar](200) NULL,
	[m_name] [varchar](200) NULL,
	[lst_class] [varchar](200) NULL,
	[dob] [datetime] NULL,
	[course_name] [varchar](100) NULL,
	[cast] [varchar](100) NULL,
	[religion] [varchar](100) NULL,
	[address] [varchar](200) NULL,
	[aadhar_NO] [bigint] NULL,
	[whats_no_self] [bigint] NULL,
	[whats_no_home] [bigint] NULL,
	[email] [varchar](200) NULL,
	[password] [varchar](150) NULL,
	[refid] [bigint] NULL,
	[images] [varchar](500) NULL,
	[img_sing] [varchar](500) NULL,
	[isdeleted] [bit] NULL,
	[isactive] [bit] NULL,
	[created_by] [int] NULL,
	[created_date] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_date] [datetime] NULL,
	[institute_id] [int] NULL,
	[isOnline] [bit] NULL,
	[isApprove] [bit] NULL,
	[Year] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[IWS_Categories] ON 

INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (1, 0, N'type1', 0, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'2022-12-29' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (2, 0, N'type2', 0, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'2022-12-29' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (3, 1, N'cat1', 0, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (4, 1, N'cat2', 0, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (5, 1, N'cat3', 0, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (6, 2, N'cat21', 0, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (7, 2, N'cat22', 1, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (8, 2, N'cat23', 1, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (9, 3, N'rtyui', 0, 1, 0, CAST(N'2022-12-29' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (10, 0, N'Sem1', 1, 1, 0, CAST(N'2022-12-30' AS Date), CAST(N'2022-12-30' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (11, 10, N'semexam', 0, 1, 0, CAST(N'2022-12-30' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (12, 11, N'hgdgwu', 0, 1, 0, CAST(N'2022-12-30' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (14, 0, N'type3', 0, 1, 0, CAST(N'2023-01-02' AS Date), CAST(N'2023-01-02' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (16, 2, N'sem2', 1, 1, 0, CAST(N'2023-01-02' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (17, 0, N'hello', 0, 1, 0, CAST(N'2023-01-02' AS Date), CAST(N'2023-01-02' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (18, 17, N'KGF', 1, 1, 0, CAST(N'2023-01-02' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (19, 18, N'KRISH2', 0, 1, 0, CAST(N'2023-01-02' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (20, 0, N'RJ', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'2023-01-03' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (21, 20, N'RK', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (22, 14, N'CAT', 1, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (23, 22, NULL, 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (24, 22, N'SAVE', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (25, 0, N'Hi', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'2023-01-03' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (26, 25, N'KG', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (27, 26, N'SG', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (28, 25, N'KM', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (29, 17, N'hds', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (30, 0, N'Deep', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'2023-01-03' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (31, 30, N'Exam2', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (32, 0, N'Vibes', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'2023-01-03' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (33, 32, N'Vibes2', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (34, 0, N'A1', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'2023-01-03' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (35, 32, N'thfu', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (36, 30, N'jay', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (37, 0, N'SKG', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'2023-01-03' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (42, 0, N'BJP', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'2023-01-03' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (43, 42, N'KLM', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (44, 43, N'JLP', 0, 1, 0, CAST(N'2023-01-03' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (49, 0, N'GRP', 0, 1, 0, CAST(N'2023-01-20' AS Date), CAST(N'2023-01-20' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (50, 49, N'SRP', 0, 1, 0, CAST(N'2023-01-20' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (51, 49, N'SGP', 0, 1, 0, CAST(N'2023-01-20' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (52, 50, N'GSR', 0, 1, 0, CAST(N'2023-01-20' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (53, 0, N'GCR', 0, 1, 0, CAST(N'2023-01-20' AS Date), CAST(N'2023-01-20' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (54, 0, N'KCL', 0, 1, 0, CAST(N'2023-01-21' AS Date), CAST(N'2023-01-21' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (55, 54, N'KFC', 0, 1, 0, CAST(N'2023-01-21' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
INSERT [dbo].[IWS_Categories] ([id], [p_id], [category_name], [isdeleted], [isactive], [created_by], [created_date], [update_date], [update_by], [hiddenimgstr]) VALUES (56, 55, N'KGF', 0, 1, 0, CAST(N'2023-01-21' AS Date), CAST(N'0001-01-01' AS Date), 0, NULL)
SET IDENTITY_INSERT [dbo].[IWS_Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[IWS_Courses] ON 

INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (1, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (2, NULL, N'0001-01-01T00:00:00', 50000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (3, N'MSC', N'0001-01-01T00:00:00', 50000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (4, N'BSC', NULL, 4000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (5, N'PGDCA', N'1 year', 4000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (6, N'ADCA', N'2018-05', 2000, 0, 0)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (7, N'ADCA', N'2018-05', 5000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (8, N'MCA', N'2022-12', 5000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (9, N'BCA', N'2018-07', 2702, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (10, N'BCA', N'2018-07', 2700, 1, 0)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (11, N'B.Tech', N'2018-12', 2000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (12, N'MBA', N'2019-07', 4000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (13, N'A', N'2021-12', 3000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (14, N'A', N'2021-12', 3000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (15, N'ADCA', N'2018-05', 2000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (16, N'ADCA', N'2022-10', 1320, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (17, N'PGDCA', N'2022-11', 4000, 1, 1)
INSERT [dbo].[IWS_Courses] ([id], [add_coures], [duration], [fees], [isactive], [isdeleted]) VALUES (18, N'CCC', N'2022-09', 1500, 1, 0)
SET IDENTITY_INSERT [dbo].[IWS_Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[IWS_Exam] ON 

INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'42', 15, N'bfhgfjhg', N'43', N'44', 566, 1, 1, 2, CAST(N'2023-01-03T20:01:20.360' AS DateTime), 5, CAST(N'2023-01-03T20:01:24.790' AS DateTime), NULL, NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'42', 18, N'fxcghj', N'43', N'44', 32, 1, 1, 2, CAST(N'2023-01-03T20:13:28.730' AS DateTime), 2, CAST(N'2023-01-03T20:13:29.590' AS DateTime), NULL, NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'42', 19, N'ADCA', N'43', N'44', 40, 1, 1, 2, CAST(N'2023-01-03T20:16:05.990' AS DateTime), 5, CAST(N'2023-01-03T20:16:08.720' AS DateTime), NULL, NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'42', 20, N'BCA', N'43', N'44', 40, 1, 0, 2, CAST(N'2023-01-18T18:32:32.647' AS DateTime), 5, CAST(N'2023-01-18T18:32:32.647' AS DateTime), NULL, NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'49', 21, N'CCC', N'50', N'52', 20, 1, 0, 2, CAST(N'2023-01-20T11:19:06.217' AS DateTime), 5, CAST(N'2023-01-20T11:19:06.217' AS DateTime), N'Is True,False', NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'49', 22, N'MCA', N'50', N'52', 30, 1, 0, 2, CAST(N'2023-01-20T17:00:10.073' AS DateTime), 5, CAST(N'2023-01-20T17:00:10.073' AS DateTime), N'Is True,False', NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'49', 23, NULL, N'50', N'52', 25, 1, 1, 2, CAST(N'2023-01-20T17:02:22.523' AS DateTime), 5, CAST(N'2023-01-20T17:02:22.523' AS DateTime), N'Is Optional', NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'49', 24, N'DSA', N'50', N'52', 30, 1, 0, 2, CAST(N'2023-01-20T17:03:18.550' AS DateTime), 5, CAST(N'2023-01-20T17:03:18.550' AS DateTime), N'Is Optional', NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'49', 25, N'JQR', N'50', N'52', 28, 1, 0, 2, CAST(N'2023-01-20T17:05:45.273' AS DateTime), 5, CAST(N'2023-01-20T17:05:45.273' AS DateTime), N'Is True,False', NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'42', 26, N'VIP', N'43', N'44', 40, 1, 0, 2, CAST(N'2023-01-20T17:13:58.053' AS DateTime), 5, CAST(N'2023-01-20T17:13:58.053' AS DateTime), N'Is True,False', NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'54', 27, N'BSC', N'55', N'56', 25, 1, 0, 2, CAST(N'2023-01-21T13:20:35.240' AS DateTime), 5, CAST(N'2023-01-21T13:20:35.240' AS DateTime), N'Is True,False', NULL)
INSERT [dbo].[IWS_Exam] ([Exam_Type], [Exam_Id], [Exam_Title], [Categorie], [Sub_Categorie], [Num_Questions], [Isactive], [Isdeleted], [Created_By], [Created_Date], [Updated_By], [Updated_Date], [Is_Optional], [Is_True_orFalse]) VALUES (N'54', 28, N'BSC', N'55', N'56', 25, 1, 0, 2, CAST(N'2023-01-21T13:35:04.377' AS DateTime), 5, CAST(N'2023-01-21T13:35:04.377' AS DateTime), N'Is True,False', NULL)
SET IDENTITY_INSERT [dbo].[IWS_Exam] OFF
GO
SET IDENTITY_INSERT [dbo].[IWS_Institute] ON 

INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'monu', N'33545', N'monu@gmail.com', N'string', N' string ', N'string ', N'sample string 7', N'sample string 8', N'sample string 9', N'sample string 10', CAST(N'2022-11-22T13:12:30.637' AS DateTime), N'sample string 12', 1, 1, CAST(N'2022-11-22T13:12:30.637' AS DateTime), N'sample string 16', 2, N'sample string 18', 1)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Sinoo', N'99562587456', N'sinoo@gmail.com', N'sino1234', N'Jhansi', N'M.tech', N'something', N'sample string 8', N'5 year', N'no sorry', CAST(N'2022-11-24T10:39:45.090' AS DateTime), N'sample string 12', 1, 1, CAST(N'2022-11-24T10:39:45.090' AS DateTime), N'sample string 16', 5, N'fhhfbejfb', 1)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Sinoo', N'99562587456', N'sinoo@gmail.com', N'sino1234', N'Jhansi', N'M.tech', N'something', N'sample string 8', N'5 year', N'no sorry', CAST(N'2022-11-24T10:39:45.090' AS DateTime), N'sample string 12', 1, 1, CAST(N'2022-11-24T10:39:45.090' AS DateTime), N'sample string 16', 6, N'fhhfbejfb', 1)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'neeraj', N'9956448456', N'sinoo@gmail.com', N'sino1234', N'Jhansi', N'M.tech', N'something', N'computer engineer', N'5 year', N' yes no sorry', CAST(N'2022-11-24T10:39:45.090' AS DateTime), N'sample string 12', 1, 1, CAST(N'2022-11-24T10:39:45.090' AS DateTime), N'sample string 16', 7, N'science', 1)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Kishan', N'7854324085', N'kiyo@gmail.com', N'jhjhh567', N'bhfhg', N'BCA', N'option2', N'Teacher in Math', N'3 Year', N'no problem', NULL, NULL, 0, 0, NULL, NULL, 14, N'Lucknow', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'deep kumar', N'7854324086', N'dee234@gmail.com', N'de234rt', N'Madhya Pradesh', N'M.TECH', N'option1', N'programmer', N'3 Year', N'no discuse', CAST(N'2022-11-30T13:56:06.333' AS DateTime), NULL, 1, 1, NULL, NULL, 15, N'sitapur', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Geet', N'8746512545', N'get78@gmail.com', N'hjhj7473', N'jaipur', N'M.TECH', N'option1', N'web deginer', N'4 year', N'no', CAST(N'2022-11-30T15:07:51.287' AS DateTime), NULL, 1, 1, NULL, NULL, 16, N'noida inside', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Raju', N'8546157852', N'raj90@gmail.com', N'raj775765676', N'Mirzapur', N'BBA', N'option2', N'Businees', N'3 Year', N'ok', CAST(N'2022-11-30T16:15:20.807' AS DateTime), NULL, 1, 1, NULL, NULL, 17, N'Allhabaad', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'mehak', NULL, N'mh34@gmail.com', N'hm123443', N'panjab', NULL, NULL, NULL, NULL, NULL, CAST(N'2022-12-02T12:11:06.843' AS DateTime), NULL, 1, 1, NULL, NULL, 18, NULL, 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'nitesh', N'8795420650', N'rm14@gmail.com', N'rm3456677', N'Gorkhpur', N'M.tech', N'Computer Education', N'Programmer', N'4 year', N'no problem', CAST(N'2022-12-02T12:22:20.743' AS DateTime), N'sample string 11', 1, 1, CAST(N'2022-12-02T12:15:24.263' AS DateTime), N'sample string 14', 19, N'with school', 1)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'sudhansu', N'784651245', N'sh@1234', N'sample string 4', N'vns', N'b.tech', N'hghgh', N'programmer', N'5 year', N'yes no', CAST(N'2022-12-05T23:38:43.740' AS DateTime), N'sample string 11', 1, 1, CAST(N'2022-12-05T23:32:23.263' AS DateTime), N'sample string 14', 20, N'sample string 16', 1)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'vivek', N'78543240833', N'seven123@gmail.com', N'fhg768', N'Mirzapur', N'MCA', N'option1', N'programmer', N'4 year', N'no', CAST(N'2022-12-06T10:11:47.937' AS DateTime), NULL, 1, 1, NULL, NULL, 21, N'Lucknow', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'ajay', N'9846622232', N'asd123@gmail.com', N'zsdds32776', N'Noida', N'BCA', N'option1', N'teacher in science', N'3 Year', N'dduyc', CAST(N'2022-12-06T11:20:48.377' AS DateTime), NULL, 1, 1, NULL, NULL, 22, N'noida inside', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'mehak', NULL, N'ih34@gmail.com', NULL, N'd', NULL, NULL, NULL, NULL, NULL, CAST(N'2022-12-07T18:33:25.227' AS DateTime), NULL, 1, 1, CAST(N'2022-12-07T18:33:23.633' AS DateTime), N'sdk', 23, NULL, 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'sani kumar', N'7854324088', N'dee234@gmail.com', NULL, N'Himachal Pradesh', N'M.TECH', N'option2', N'developer', N'6Year', N'no discuse', CAST(N'2022-12-07T18:57:31.410' AS DateTime), NULL, 1, 1, CAST(N'2022-12-07T18:57:31.380' AS DateTime), N'sdk', 24, N'sitapur', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'ajay sharma', N'9846622232', N'sds@gmail.com', N'147', N'Noida', N'BCA 2nd', N'option2', N'teacher in science', N'3 Year', N'dduyc', CAST(N'2022-12-07T19:04:15.590' AS DateTime), NULL, 1, 1, CAST(N'2022-12-07T19:04:13.330' AS DateTime), N'sdk', 25, N'noida inside', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2022-12-08T12:24:36.753' AS DateTime), NULL, 1, 1, CAST(N'2022-12-08T12:24:36.707' AS DateTime), N'sdk', 26, NULL, 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Jaiprakash', N'8546978455', N'jp456@gmail.com', N'5656567uhh', N'Raypur', N'M.TECH', N'option2', N'teacher in science', N'4 year', N'if you dont mind', CAST(N'2022-12-12T16:12:34.720' AS DateTime), NULL, 1, 1, CAST(N'2022-12-12T16:12:34.670' AS DateTime), N'sdk', 27, N'Jaypur', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Mayank kumar', N'8465125468', N'DFG678@gmail.com', N'452uuy', N'Indor', N'BCA', N'option1', N' Software developer', N'2 year', N'if condition is true', CAST(N'2022-12-12T16:17:40.493' AS DateTime), NULL, 1, 1, CAST(N'2022-12-12T16:17:40.443' AS DateTime), N'sdk', 28, N'Kolkatta', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'suresh', N'954612354625', N'bhu567@gmail.com', N'st3665678', N'Mau', N'Diploma', N'option2', N' software developer', N'2 year', N'ok boss', CAST(N'2022-12-12T17:01:41.197' AS DateTime), NULL, 1, 1, CAST(N'2022-12-12T17:01:41.143' AS DateTime), N'sdk', 29, N'Gonda', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Bipin', N'8564794651', N'ind12@gmail.com', N'45323yttut', N'Hardoi', N'B.tech', N'option2', N'programmer', N'2 year', N'jdkdujjjdojjkjkdjdkjkkjedo', CAST(N'2022-12-12T17:18:10.400' AS DateTime), NULL, 1, 1, CAST(N'2022-12-12T17:18:10.340' AS DateTime), N'sdk', 30, N'sitapur', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'ajay', N'7854324087', N'kj45@gmail.com', N'hgh67797', N'vikapur', N'MCA', N'option1', N'programmer', N'4 year', N'ok dear', CAST(N'2022-12-12T17:25:45.980' AS DateTime), NULL, 1, 1, CAST(N'2022-12-12T17:25:45.927' AS DateTime), N'sdk', 31, N'jhansi insgtitut location', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'karan', N'9846125465', N'rk12@gmail.com', N'jjhjh232323', N'Bilaspur', N'BCA', NULL, N'Software Developer', N'2 year', N'if you don''t moind', CAST(N'2022-12-13T10:50:54.823' AS DateTime), NULL, 1, 1, CAST(N'2022-12-13T10:50:54.747' AS DateTime), N'sdk', 32, N'Himachal Pradesh', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Arav kumar', N'983384612542', N'Mt3@gmail.com', N'm68678', N'Kan', N'M.TECH', NULL, N'programmer', N'2 year', N'kit', CAST(N'2022-12-14T18:30:55.440' AS DateTime), NULL, 1, 1, CAST(N'2022-12-14T18:30:55.250' AS DateTime), N'sdk', 33, N'Panjab', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Divakr', N'9685461245', N'div123@gmail.com', N'6566tyfyf', N'Mirzapur', N'B.pharma', N'option2', N'teacher in chemistry', N'2 year', N'yes boss', CAST(N'2022-12-14T18:37:05.450' AS DateTime), NULL, 1, 0, CAST(N'2022-12-14T18:36:58.180' AS DateTime), N'sdk', 34, N'Varanasi', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Sinoo  Rajput', N'8794556565', N'ss12@gmail.com', N'INSHORT240', N'Ujjan', N'M.TECH', NULL, N'Teacher in Math', N'2 year', N'very easy ways', CAST(N'2022-12-14T18:39:19.193' AS DateTime), NULL, 1, 0, CAST(N'2022-12-14T18:39:19.173' AS DateTime), N'sdk', 35, N'Varanasi', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'monu', N'756556556', N'hg2@gmail.com', N'INSHORT240', N'varanasi', N'MCA', NULL, N'teacher in science', N'5555555', N'ndm', CAST(N'2022-12-14T18:40:51.293' AS DateTime), NULL, 1, 0, CAST(N'2022-12-14T18:40:51.287' AS DateTime), N'sdk', 36, N'LKO', 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2022-12-15T19:00:32.657' AS DateTime), NULL, 1, 0, CAST(N'2022-12-15T19:00:32.620' AS DateTime), N'sdk', 37, NULL, 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'sinoo', N'7854324087', N'sonu@gmail.com', N'INSHORT288', N'noida', N'MCA', N'option1', N'programmer', N'3 Year', N'jhdh', CAST(N'2022-12-15T19:53:23.493' AS DateTime), NULL, 1, 0, CAST(N'2022-12-15T19:53:23.470' AS DateTime), N'sdk', 38, NULL, 0)
INSERT [dbo].[IWS_Institute] ([name], [mobile], [Email], [password], [Address], [YourEducation], [Institute_type], [Present_job_profession], [Education_Sector_Experience], [Your_Comment_query], [createdone], [createdby], [isActive], [isdeleted], [updatedon], [opdatedby], [id], [Institute_Pre_School], [isapprove]) VALUES (N'Satish Gupta', N'7348651265', N'Sg32@gmail.com', N'fg@123', N'Mahadev ki Nagari', N'BCA', NULL, N'Computer Teacher', N'1 year', N'ok boss', CAST(N'2022-12-30T12:33:55.293' AS DateTime), NULL, 1, 0, CAST(N'2022-12-30T12:33:55.270' AS DateTime), N'sdk', 39, N'Gazipur', 0)
SET IDENTITY_INSERT [dbo].[IWS_Institute] OFF
GO
SET IDENTITY_INSERT [dbo].[IWS_Login] ON 

INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (1, NULL, N'INSHORT002', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'kitti123@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (2, NULL, N'INSHORT001', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'sinoo@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (3, NULL, N'INSHORT001', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'sinoo@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (4, 288, N'INSHORT288', N'Admin', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'sinoo@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (5, 669, N'INSHORT669', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'mh34@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (6, 226, N'INSHORT226', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'kiyo@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (7, 607, N'INSHORT607', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'dee234@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (8, 644, N'INSHORT644', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'get78@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (9, 224, N'INSHORT224', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'raj90@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (10, 650, N'INSHORT650', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (11, 606, N'INSHORT606', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (12, 5069, N'INSHORT5069', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (13, 3431, N'INSHORT3431', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (14, 2943, N'INSHORT2943', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (15, 2415, N'INSHORT2415', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (16, 6062, N'INSHORT6062', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (17, 448, N'INSHORT448', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (18, 487, N'INSHORT487', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (19, 4544, N'INSHORT4544', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (20, 245, N'INSHORT245', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (21, 9638, N'INSHORT9638', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (22, 6390, N'INSHORT6390', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (23, 5685, N'INSHORT5685', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (24, 4073, N'INSHORT4073', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (25, 9346, N'INSHORT9346', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (26, 7891, N'INSHORT7891', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (27, 2525, N'INSHORT2525', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (28, 7643, N'INSHORT7643', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (29, 8936, N'INSHORT8936', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (30, 8645, N'INSHORT8645', N'Student', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (31, 206, N'INSHORT206', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (32, 981, N'INSHORT981', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (33, 550, N'INSHORT550', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (34, 581, N'INSHORT581', N'Institute', 0, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (35, 988, N'INSHORT988', N'Institute', 1, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (36, 427, N'INSHORT427', N'Institute', 1, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (37, 512, N'INSHORT512', N'Institute', 1, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'bhu567@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (38, 232, N'INSHORT232', N'Institute', 1, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'ind12@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (39, 234, N'INSHORT234', N'Institute', 1, 0, 0, CAST(N'2022-12-12T19:32:01.917' AS DateTime), 0, NULL, N'kj45@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (40, 240, N'INSHORT240', N'Institute', 1, NULL, 1, CAST(N'2022-12-13T10:50:54.827' AS DateTime), NULL, NULL, N'rk12@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (41, 3525, N'INSHORT3525', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (42, 3535, N'INSHORT3535', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (43, 4189, N'INSHORT4189', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (44, 592, N'INSHORT592', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (45, 4947, N'INSHORT4947', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (46, 558, N'INSHORT558', N'Institute', 1, NULL, 1, CAST(N'2022-12-14T18:30:55.447' AS DateTime), NULL, NULL, N'Mt3@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (47, 887, N'INSHORT887', N'Institute', 1, NULL, 1, CAST(N'2022-12-14T18:37:05.453' AS DateTime), NULL, NULL, N'div123@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (48, 335, N'INSHORT335', N'Institute', 1, NULL, 1, CAST(N'2022-12-14T18:39:19.197' AS DateTime), NULL, NULL, N'ss12@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (49, 548, N'INSHORT548', N'Institute', 1, NULL, 1, CAST(N'2022-12-14T18:40:51.293' AS DateTime), NULL, NULL, N'hg2@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (50, 744, N'INSHORT744', N'Institute', 1, NULL, 1, CAST(N'2022-12-15T19:00:32.660' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (51, 899, N'INSHORT899', N'Institute', 1, NULL, 1, CAST(N'2022-12-15T19:53:23.500' AS DateTime), NULL, NULL, N'sonu@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (52, 5253, N'INSHORT5253', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (53, 7139, N'INSHORT7139', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (54, 469, N'INSHORT469', N'Institute', 1, NULL, 1, CAST(N'2022-12-30T12:33:55.293' AS DateTime), NULL, NULL, N'Sg32@gmail.com')
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (55, 575, N'INSHORT575', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (56, 5308, N'INSHORT5308', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (57, 6668, N'INSHORT6668', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[IWS_Login] ([id], [userid], [password], [type], [isactive], [isdeleted], [created_by], [created_date], [updated_by], [updated_date], [UserName]) VALUES (58, 890, N'INSHORT890', N'Student', 0, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[IWS_Login] OFF
GO
SET IDENTITY_INSERT [dbo].[IWS_Score] ON 

INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (0, 1, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, CAST(N'0001-01-01' AS Date), 0, 0, CAST(N'0001-01-01' AS Date), NULL)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (0, 2, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, CAST(N'0001-01-01' AS Date), 0, 0, CAST(N'0001-01-01' AS Date), NULL)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (0, 3, N'sddfg', N'ert', N'eretr', N'fgf', N'seret', N'sdrtr', 0, 0, CAST(N'0001-01-01' AS Date), 0, 0, CAST(N'0001-01-01' AS Date), NULL)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (0, 4, N'What is HTML', N'H', N'HH', N'HIh', N'Hyper text Markup Language', N'Hyper text Markup Language', 1, 1, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-17' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (19, 5, N'what is DB', N'DBMS', N'RDBMS', N'MYSQL', N'SQL', N'MSSQL', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-18' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (15, 6, N'jdbjkd', N'jehjw', N'wjheh', N'hwkw', N'jdbwkd', N'djwkd', 1, 1, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-18' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (0, 7, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, CAST(N'0001-01-01' AS Date), 0, 0, CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (0, 8, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, CAST(N'0001-01-01' AS Date), 0, 0, CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (0, 9, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, CAST(N'0001-01-01' AS Date), 0, 0, CAST(N'0001-01-01' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (19, 10, N'dddd', N'd', N'dd', N'ddd', N'dddd', N'dddd', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-19' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (19, 11, N'dd', N'dddddd', N'dd', N'ddd', N'dddddd', N'dddddd', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-19' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (22, 12, N'what is VAR', N'var1', N'var2', N'Vaireable', N'vaR', N'Vaireable', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-20' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (26, 13, N'What is form BG color', N'BG', N'bg', N'BGs', N'Bg', N'BG', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-20' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (22, 14, N'What is full form UI', N'User I', N'User IB', N'User ID', N'Usser Interface', N'Usser Interface', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-20' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (28, 15, N'what is Function', N'DDDD', N'FFFF', N'JJJJ', N'QQQQ', N'CCC', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-21' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (28, 16, N'what is Function', N'DDDD', N'FFFF', N'JJJJ', N'QQQQ', N'CCC', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-21' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (28, 17, N'what is Function', N'DDDD', N'FFFF', N'JJJJ', N'QQQQ', N'CCC', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-21' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (27, 18, N'What is KIrchaf law', N'ooo', N'ppp', N'tttt', N'rrrr', N'qqqqq', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-21' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (28, 19, N'what is Mirror', N'M', N'MM', N'MMM', NULL, NULL, 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-21' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (28, 20, N'what is Mirror', N'M', N'MM', N'MMM', N'MMMM', N'MM', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-21' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (28, 21, N'What is Geotharmal', N'G', N'G2', N'G3', N'GGGG', N'G3', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-21' AS Date), 0)
INSERT [dbo].[IWS_Score] ([Exam_id], [Question_NO], [Question], [Opction1], [Opction2], [Opction3], [Opction4], [Answer], [IsActive], [IsDeleted], [Created_Date], [Created_By], [Updated_By], [Updated_Date], [Id]) VALUES (28, 22, N'what is Hydro Cloric Acid Formula', N'HCK', N'HCS', N'HCA', N'HCL', N'HCL', 1, 0, CAST(N'0001-01-01' AS Date), 0, 2, CAST(N'2023-01-21' AS Date), 0)
SET IDENTITY_INSERT [dbo].[IWS_Score] OFF
GO
SET IDENTITY_INSERT [dbo].[IWS_Student] ON 

INSERT [dbo].[IWS_Student] ([id], [name], [f_name], [m_name], [lst_class], [dob], [course_name], [cast], [religion], [address], [aadhar_NO], [whats_no_self], [whats_no_home], [email], [password], [refid], [images], [img_sing], [isdeleted], [isactive], [created_by], [created_date], [updated_by], [updated_date], [institute_id], [isOnline], [isApprove], [Year], [Status]) VALUES (1, N'Ram', N'JaiRam', N'Site', N'B.SC', CAST(N'2003-07-30T00:00:00.000' AS DateTime), N'10', N'OBC', N'Sikkhha', N'Lucknow', 636325555442, 8785656565, 8785656556, N'ra1@gmail.com', N'ra667687878', 8989897, N'Director.jpeg', NULL, 0, 1, 2, CAST(N'2022-12-30T13:27:35.903' AS DateTime), 0, NULL, 5766765, 1, 0, N'2', NULL)
SET IDENTITY_INSERT [dbo].[IWS_Student] OFF
GO
/****** Object:  StoredProcedure [dbo].[pro_category]    Script Date: 21-01-2023 19:06:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[pro_category]      
(      
@id int =null ,      
@p_id int=null,      
@category_name nvarchar(100)=null,      
@Action varchar(20),       
@isdeleted bit=null,    
@isactive bit=null,    
@created_by int=null,    
@created_date date=null,   
@img varchar(max)=null,   
@update_date date=null,    
@update_by int=null    
    
  --Insert =1,    
  --          Update=2,    
  --          SelectAllCategory = 3,    
  --          Delete =4,    
  --          SelectAllType=5,    
  --          SelectAllSubCategory=6,    
  --          Edit=7,   
  --          alldata=8
    
)      
as      
begin      
if @Action='1'      
begin      
insert into IWS_Categories( p_id, category_name, isdeleted, isactive, created_by, created_date, update_date, update_by,hiddenimgstr)     
values(@p_id,@category_name,@isdeleted, @isactive, @created_by, @created_date, @update_date, @update_by,@img)       
end      
if @Action='2'      
begin      
update IWS_Categories set p_id=@p_id,category_name=isnull(@category_name,category_name),isdeleted=@isdeleted,isactive=@isactive,update_by=@update_by,
update_date=@update_date,hiddenimgstr=@img where id=@id      
end      
if @Action='3'      
begin     
with cte as(    
select a.id, a.p_id, a.category_name, isnull(a.isdeleted,0) as isdeleted, isnull(a.isactive,1) as isactive, hiddenimgstr,    
a.created_by,a.created_date, a.update_date,a.update_by from IWS_Categories a where a.p_id in     
(select id from IWS_Categories where p_id=0 and isdeleted=0 and isactive=1) and a.isdeleted=0 and a.isactive=1    
)    
select b.category_name as _Type,a.* from cte a inner join IWS_Categories b on b.id=a.p_id order by b.category_name asc    
end      
if @Action='4'      
begin      
update IWS_Categories set isdeleted=1 where id=@id    
end      
if @Action='5'      
begin      
select id, p_id, category_name, isnull(isdeleted,0) as isdeleted, isnull(isactive,1) as     
isactive, created_by,created_date, update_date,update_by,hiddenimgstr from IWS_Categories where    
 p_id=0 and isdeleted=0 and isactive=1    
end    
if @Action='6'      
begin     
with cte as (    
select a.id, a.p_id, a.category_name, isnull(a.isdeleted,0) as isdeleted, isnull(a.isactive,1) as     
isactive, a.created_by,a.created_date, a.update_date,a.update_by ,a.hiddenimgstr    
from IWS_Categories a where a.p_id in (select id from IWS_Categories  where p_id in     
(select id from IWS_Categories where p_id=0 and isdeleted=0 and isactive=1))and a.isdeleted=0 and a.isactive=1     
)    
select b.category_name as type_category,a.* from cte a inner join IWS_Categories b on b.id= a.p_id order by b.category_name asc    
end    
if @Action='7'    
begin    
select * from IWS_Categories where isactive=1 and isdeleted=0 and id=@id    
end    
if @Action='8'    
begin    
select * from IWS_Categories where isactive=1 and isdeleted=0     
end    
end
GO
