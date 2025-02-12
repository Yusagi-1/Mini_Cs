USE [master]
GO
/****** Object:  Database [RecordKeeping]    Script Date: 11/21/2024 8:33:34 AM ******/
CREATE DATABASE [RecordKeeping]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RecordKeeping', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RecordKeeping.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RecordKeeping_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RecordKeeping_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RecordKeeping] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RecordKeeping].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RecordKeeping] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RecordKeeping] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RecordKeeping] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RecordKeeping] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RecordKeeping] SET ARITHABORT OFF 
GO
ALTER DATABASE [RecordKeeping] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RecordKeeping] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RecordKeeping] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RecordKeeping] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RecordKeeping] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RecordKeeping] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RecordKeeping] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RecordKeeping] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RecordKeeping] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RecordKeeping] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RecordKeeping] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RecordKeeping] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RecordKeeping] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RecordKeeping] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RecordKeeping] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RecordKeeping] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RecordKeeping] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RecordKeeping] SET RECOVERY FULL 
GO
ALTER DATABASE [RecordKeeping] SET  MULTI_USER 
GO
ALTER DATABASE [RecordKeeping] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RecordKeeping] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RecordKeeping] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RecordKeeping] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RecordKeeping] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RecordKeeping] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RecordKeeping', N'ON'
GO
ALTER DATABASE [RecordKeeping] SET QUERY_STORE = ON
GO
ALTER DATABASE [RecordKeeping] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RecordKeeping]
GO
/****** Object:  Table [dbo].[AuditLogs]    Script Date: 11/21/2024 8:33:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditLogs](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[Action] [nvarchar](100) NOT NULL,
	[Timestamp] [datetime] NULL,
	[Description] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 11/21/2024 8:33:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[ContactNumber] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[Address] [nvarchar](255) NULL,
	[Notes] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deceased]    Script Date: 11/21/2024 8:33:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deceased](
	[DeceasedID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[DeceasedName] [nvarchar](100) NOT NULL,
	[Age] [int] NULL,
	[BirthDate] [date] NULL,
	[DeathDate] [date] NOT NULL,
	[GraveAddress] [nvarchar](255) NULL,
	[Notes] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[RelationshipToClient] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[DeceasedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 11/21/2024 8:33:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionID] [int] NOT NULL,
	[PaymentDate] [date] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[PaymentMethod] [nvarchar](50) NULL,
	[Notes] [nvarchar](255) NULL,
	[PaymentStatus] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 11/21/2024 8:33:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[DurationDays] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[IncludesChapel] [bit] NULL,
	[IncludesCasket] [bit] NULL,
	[WithAircon] [bit] NULL,
	[IncludesEmbalming] [bit] NULL,
	[IsPresidential] [bit] NULL,
	[IsFreeChapel] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 11/21/2024 8:33:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[TransactionDate] [date] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[Discount] [decimal](10, 2) NOT NULL,
	[Notes] [nvarchar](255) NULL,
	[CreatedBy] [int] NULL,
	[CreatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/21/2024 8:33:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PasswordHash] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](20) NOT NULL,
	[CreatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vigil]    Script Date: 11/21/2024 8:33:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vigil](
	[VigilID] [int] IDENTITY(1,1) NOT NULL,
	[DeceasedID] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[Notes] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Vigil] PRIMARY KEY CLUSTERED 
(
	[VigilID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IDX_UserID]    Script Date: 11/21/2024 8:33:35 AM ******/
CREATE NONCLUSTERED INDEX [IDX_UserID] ON [dbo].[AuditLogs]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Clients_FullName]    Script Date: 11/21/2024 8:33:35 AM ******/
CREATE NONCLUSTERED INDEX [IDX_Clients_FullName] ON [dbo].[Clients]
(
	[FullName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_Deceased_DeathDate]    Script Date: 11/21/2024 8:33:35 AM ******/
CREATE NONCLUSTERED INDEX [IDX_Deceased_DeathDate] ON [dbo].[Deceased]
(
	[DeathDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Deceased_Name]    Script Date: 11/21/2024 8:33:35 AM ******/
CREATE NONCLUSTERED INDEX [IDX_Deceased_Name] ON [dbo].[Deceased]
(
	[DeceasedName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_TransactionID]    Script Date: 11/21/2024 8:33:35 AM ******/
CREATE NONCLUSTERED INDEX [IDX_TransactionID] ON [dbo].[Payments]
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_ClientID]    Script Date: 11/21/2024 8:33:35 AM ******/
CREATE NONCLUSTERED INDEX [IDX_ClientID] ON [dbo].[Transactions]
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_ServiceID]    Script Date: 11/21/2024 8:33:35 AM ******/
CREATE NONCLUSTERED INDEX [IDX_ServiceID] ON [dbo].[Transactions]
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditLogs] ADD  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Deceased] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Deceased] ADD  CONSTRAINT [DF_Deceased_RelationshipToClient]  DEFAULT ('Other') FOR [RelationshipToClient]
GO
ALTER TABLE [dbo].[Payments] ADD  DEFAULT (getdate()) FOR [PaymentDate]
GO
ALTER TABLE [dbo].[Payments] ADD  DEFAULT ('Pending') FOR [PaymentStatus]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT ((0)) FOR [IncludesChapel]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT ((0)) FOR [IncludesCasket]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT ((0)) FOR [WithAircon]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT ((0)) FOR [IncludesEmbalming]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT ((0)) FOR [IsPresidential]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT ((0)) FOR [IsFreeChapel]
GO
ALTER TABLE [dbo].[Transactions] ADD  DEFAULT (getdate()) FOR [TransactionDate]
GO
ALTER TABLE [dbo].[Transactions] ADD  DEFAULT ((0.00)) FOR [Discount]
GO
ALTER TABLE [dbo].[Transactions] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Vigil] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[AuditLogs]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Deceased]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Deceased]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transactions] ([TransactionID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Services] ([ServiceID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vigil]  WITH CHECK ADD  CONSTRAINT [FK_Vigil_Deceased] FOREIGN KEY([DeceasedID])
REFERENCES [dbo].[Deceased] ([DeceasedID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vigil] CHECK CONSTRAINT [FK_Vigil_Deceased]
GO
ALTER TABLE [dbo].[Vigil]  WITH CHECK ADD  CONSTRAINT [FK_Vigil_Users] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Vigil] CHECK CONSTRAINT [FK_Vigil_Users]
GO
USE [master]
GO
ALTER DATABASE [RecordKeeping] SET  READ_WRITE 
GO
