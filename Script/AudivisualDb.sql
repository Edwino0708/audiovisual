
CREATE DATABASE [audiovisualdb]
GO


USE [audiovisualdb]
GO

/****** Object:  Table [dbo].[Brands]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[StateId] [int] NULL,
	[Enabled] [bit] NOT NULL,
	PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BrandsStates]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BrandsStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](40) NOT NULL,
	[Enabled] [bit] NOT NULL,
	PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2/16/2021 4:05:13 PM ******/
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
	PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeesStates]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeesStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
	PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equiments]    Script Date: 2/16/2021 4:05:13 PM ******/
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
	CONSTRAINT [PK__Equiment__3214EC070143A6D0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquimentsStates]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquimentsStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquimentTypes]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquimentTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateId] [int] NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquimentTypesStates]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquimentTypesStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Models]    Script Date: 2/16/2021 4:05:13 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModelsStates]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModelsStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](40) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalTypes]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentReturn]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentReturn](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NoPay] [varchar](40) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[EquimentId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[LoanDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NULL,
	[Comentary] [varchar](100) NULL,
	[StateId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentReturnStates]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentReturnStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnologiesConnection]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnologiesConnection](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[StateId] [int] NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnologiesConnectionStates]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnologiesConnectionStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2/16/2021 4:05:13 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersStates]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](10) NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersTypes]    Script Date: 2/16/2021 4:05:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Brands] ADD  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[Brands] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[BrandsStates] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT (getdate()) FOR [HiredDate]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[EmployeesStates] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[Equiments] ADD  CONSTRAINT [DF__Equiments__State__46E78A0C]  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[Equiments] ADD  CONSTRAINT [DF__Equiments__Enabl__47DBAE45]  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[EquimentsStates] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[EquimentTypes] ADD  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[EquimentTypes] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[EquimentTypesStates] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[Models] ADD  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[Models] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[ModelsStates] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[PersonalTypes] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[RentReturn] ADD  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[RentReturnStates] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[TechnologiesConnection] ADD  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[TechnologiesConnection] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[TechnologiesConnectionStates] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [UsersTypesId]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [PersonalTypesID]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [StateId]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[UsersStates] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[UsersTypes] ADD  DEFAULT ((1)) FOR [Enabled]
GO
ALTER TABLE [dbo].[Brands]  WITH CHECK ADD FOREIGN KEY([StateId])
REFERENCES [dbo].[BrandsStates] ([Id])
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([StateId])
REFERENCES [dbo].[EmployeesStates] ([Id])
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
REFERENCES [dbo].[TechnologiesConnection] ([Id])
GO
ALTER TABLE [dbo].[Equiments] CHECK CONSTRAINT [FK__Equiments__Techn__4BAC3F29]
GO
ALTER TABLE [dbo].[EquimentTypes]  WITH CHECK ADD FOREIGN KEY([StateId])
REFERENCES [dbo].[EquimentTypesStates] ([Id])
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD FOREIGN KEY([BranksId])
REFERENCES [dbo].[Brands] ([Id])
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD FOREIGN KEY([StateId])
REFERENCES [dbo].[ModelsStates] ([Id])
GO
ALTER TABLE [dbo].[RentReturn]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[RentReturn]  WITH CHECK ADD  CONSTRAINT [FK__RentRetur__Equim__6D0D32F4] FOREIGN KEY([EquimentId])
REFERENCES [dbo].[Equiments] ([Id])
GO
ALTER TABLE [dbo].[RentReturn] CHECK CONSTRAINT [FK__RentRetur__Equim__6D0D32F4]
GO
ALTER TABLE [dbo].[RentReturn]  WITH CHECK ADD FOREIGN KEY([StateId])
REFERENCES [dbo].[RentReturnStates] ([Id])
GO
ALTER TABLE [dbo].[RentReturn]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[TechnologiesConnection]  WITH CHECK ADD FOREIGN KEY([StateId])
REFERENCES [dbo].[TechnologiesConnectionStates] ([Id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([PersonalTypesID])
REFERENCES [dbo].[PersonalTypes] ([Id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([StateId])
REFERENCES [dbo].[UsersStates] ([Id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([UsersTypesId])
REFERENCES [dbo].[UsersTypes] ([Id])
GO
