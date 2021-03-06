USE [audiovisualdb]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[StateId] [int] NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BrandsStates]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BrandsStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](40) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_BrandsStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](150) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[IdentificationCard] [varchar](20) NOT NULL,
	[Workshift] [varchar](50) NOT NULL,
	[HiredDate] [datetime] NULL,
	[StateId] [int] NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeesStates]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeesStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_EmployeesStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equiments]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equiments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Serial] [varchar](50) NOT NULL,
	[ServiceTag] [varchar](50) NOT NULL,
	[EquimentTypesId] [int] NOT NULL,
	[BrandId] [int] NOT NULL,
	[ModelsId] [int] NOT NULL,
	[TechnologiesConnectionId] [int] NOT NULL,
	[StateId] [int] NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_Equiments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquimentsStates]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquimentsStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_EquimentsStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquimentTypes]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquimentTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateId] [int] NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_EquimentTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquimentTypesStates]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquimentTypesStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_EquimentTypesStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Models]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Models](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BranksId] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[StateId] [int] NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_Models] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModelsStates]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModelsStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](40) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_ModelsStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalTypes]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_PersonalTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentReturns]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentReturns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NoPay] [varchar](40) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[EquimentId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[LoanDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NULL,
	[Comentary] [varchar](100) NULL,
	[StateId] [int] NULL,
 CONSTRAINT [PK_RentReturns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentReturnStates]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentReturnStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_RentReturnStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnologiesConnections]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnologiesConnections](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[StateId] [int] NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_TechnologiesConnections] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnologiesConnectionStates]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnologiesConnectionStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_TechnologiesConnectionStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogins]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogins](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[role] [varchar](50) NOT NULL,
	[isActive] [bit] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[username] ASC,
	[password] ASC,
	[role] ASC,
	[isActive] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[IdentificationCard] [varchar](20) NOT NULL,
	[Carnet] [varchar](50) NOT NULL,
	[UsersTypesId] [int] NULL,
	[PersonalTypesID] [int] NULL,
	[StateId] [int] NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersStates]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_UsersStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersTypes]    Script Date: 3/14/2021 11:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
 CONSTRAINT [PK_UsersTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Brands]  WITH CHECK ADD  CONSTRAINT [FK__Brands__StateId__5EBF139D] FOREIGN KEY([StateId])
REFERENCES [dbo].[BrandsStates] ([Id])
GO
ALTER TABLE [dbo].[Brands] CHECK CONSTRAINT [FK__Brands__StateId__5EBF139D]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK__Employees__State__5FB337D6] FOREIGN KEY([StateId])
REFERENCES [dbo].[EmployeesStates] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK__Employees__State__5FB337D6]
GO
ALTER TABLE [dbo].[Equiments]  WITH CHECK ADD  CONSTRAINT [FK__Equiments__Brand__49C3F6B7] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
GO
ALTER TABLE [dbo].[Equiments] CHECK CONSTRAINT [FK__Equiments__Brand__49C3F6B7]
GO
ALTER TABLE [dbo].[Equiments]  WITH CHECK ADD  CONSTRAINT [FK__Equiments__Equim__48CFD27E] FOREIGN KEY([EquimentTypesId])
REFERENCES [dbo].[EquimentTypes] ([Id])
GO
ALTER TABLE [dbo].[Equiments] CHECK CONSTRAINT [FK__Equiments__Equim__48CFD27E]
GO
ALTER TABLE [dbo].[Equiments]  WITH CHECK ADD  CONSTRAINT [FK__Equiments__Model__4AB81AF0] FOREIGN KEY([ModelsId])
REFERENCES [dbo].[Models] ([Id])
GO
ALTER TABLE [dbo].[Equiments] CHECK CONSTRAINT [FK__Equiments__Model__4AB81AF0]
GO
ALTER TABLE [dbo].[Equiments]  WITH CHECK ADD  CONSTRAINT [FK__Equiments__State__4CA06362] FOREIGN KEY([StateId])
REFERENCES [dbo].[EquimentsStates] ([Id])
GO
ALTER TABLE [dbo].[Equiments] CHECK CONSTRAINT [FK__Equiments__State__4CA06362]
GO
ALTER TABLE [dbo].[Equiments]  WITH CHECK ADD  CONSTRAINT [FK__Equiments__Techn__4BAC3F29] FOREIGN KEY([TechnologiesConnectionId])
REFERENCES [dbo].[TechnologiesConnections] ([Id])
GO
ALTER TABLE [dbo].[Equiments] CHECK CONSTRAINT [FK__Equiments__Techn__4BAC3F29]
GO
ALTER TABLE [dbo].[EquimentTypes]  WITH CHECK ADD  CONSTRAINT [FK__EquimentT__State__656C112C] FOREIGN KEY([StateId])
REFERENCES [dbo].[EquimentTypesStates] ([Id])
GO
ALTER TABLE [dbo].[EquimentTypes] CHECK CONSTRAINT [FK__EquimentT__State__656C112C]
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD  CONSTRAINT [FK__Models__BranksId__66603565] FOREIGN KEY([BranksId])
REFERENCES [dbo].[Brands] ([Id])
GO
ALTER TABLE [dbo].[Models] CHECK CONSTRAINT [FK__Models__BranksId__66603565]
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD  CONSTRAINT [FK__Models__StateId__6754599E] FOREIGN KEY([StateId])
REFERENCES [dbo].[ModelsStates] ([Id])
GO
ALTER TABLE [dbo].[Models] CHECK CONSTRAINT [FK__Models__StateId__6754599E]
GO
ALTER TABLE [dbo].[RentReturns]  WITH CHECK ADD  CONSTRAINT [FK__RentRetur__Emplo__68487DD7] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[RentReturns] CHECK CONSTRAINT [FK__RentRetur__Emplo__68487DD7]
GO
ALTER TABLE [dbo].[RentReturns]  WITH CHECK ADD  CONSTRAINT [FK__RentRetur__Equim__6D0D32F4] FOREIGN KEY([EquimentId])
REFERENCES [dbo].[Equiments] ([Id])
GO
ALTER TABLE [dbo].[RentReturns] CHECK CONSTRAINT [FK__RentRetur__Equim__6D0D32F4]
GO
ALTER TABLE [dbo].[RentReturns]  WITH CHECK ADD  CONSTRAINT [FK__RentRetur__State__6A30C649] FOREIGN KEY([StateId])
REFERENCES [dbo].[RentReturnStates] ([Id])
GO
ALTER TABLE [dbo].[RentReturns] CHECK CONSTRAINT [FK__RentRetur__State__6A30C649]
GO
ALTER TABLE [dbo].[RentReturns]  WITH CHECK ADD  CONSTRAINT [FK__RentRetur__UserI__6B24EA82] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[RentReturns] CHECK CONSTRAINT [FK__RentRetur__UserI__6B24EA82]
GO
ALTER TABLE [dbo].[TechnologiesConnections]  WITH CHECK ADD  CONSTRAINT [FK__Technolog__State__6C190EBB] FOREIGN KEY([StateId])
REFERENCES [dbo].[TechnologiesConnectionStates] ([Id])
GO
ALTER TABLE [dbo].[TechnologiesConnections] CHECK CONSTRAINT [FK__Technolog__State__6C190EBB]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK__Users__PersonalT__6D0D32F4] FOREIGN KEY([PersonalTypesID])
REFERENCES [dbo].[PersonalTypes] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK__Users__PersonalT__6D0D32F4]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK__Users__StateId__6E01572D] FOREIGN KEY([StateId])
REFERENCES [dbo].[UsersStates] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK__Users__StateId__6E01572D]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK__Users__UsersType__6EF57B66] FOREIGN KEY([UsersTypesId])
REFERENCES [dbo].[UsersTypes] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK__Users__UsersType__6EF57B66]
GO
