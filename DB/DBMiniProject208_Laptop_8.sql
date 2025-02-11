USE [master]
GO
/****** Object:  Database [DBMiniProject208]    Script Date: 18/09/2019 13.41.12 ******/
CREATE DATABASE [DBMiniProject208]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBMiniProject208', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBMiniProject208.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBMiniProject208_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBMiniProject208_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBMiniProject208] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBMiniProject208].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBMiniProject208] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBMiniProject208] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBMiniProject208] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBMiniProject208] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBMiniProject208] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBMiniProject208] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBMiniProject208] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBMiniProject208] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBMiniProject208] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBMiniProject208] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBMiniProject208] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBMiniProject208] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBMiniProject208] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBMiniProject208] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBMiniProject208] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBMiniProject208] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBMiniProject208] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBMiniProject208] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBMiniProject208] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBMiniProject208] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBMiniProject208] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBMiniProject208] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBMiniProject208] SET RECOVERY FULL 
GO
ALTER DATABASE [DBMiniProject208] SET  MULTI_USER 
GO
ALTER DATABASE [DBMiniProject208] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBMiniProject208] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBMiniProject208] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBMiniProject208] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBMiniProject208] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBMiniProject208', N'ON'
GO
USE [DBMiniProject208]
GO
/****** Object:  Table [dbo].[x_addrbook]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_addrbook](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[is_locked] [bit] NOT NULL,
	[attempt] [smallint] NOT NULL,
	[email] [varchar](100) NOT NULL,
	[abuid] [varchar](50) NOT NULL,
	[abpwd] [varchar](50) NOT NULL,
	[fp_token] [varchar](100) NULL,
	[fp_expired_date] [datetime] NULL,
	[fp_counter] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_address]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_address](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[created_by] [int] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [int] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [int] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[biodata_id] [int] NULL,
	[address1] [varchar](1000) NULL,
	[postal_code1] [varchar](20) NULL,
	[rt1] [varchar](5) NULL,
	[rw1] [varchar](5) NULL,
	[kelurahan1] [varchar](100) NULL,
	[kecamatan1] [varchar](100) NULL,
	[region1] [varchar](100) NULL,
	[address2] [varchar](1000) NULL,
	[postal_code2] [varchar](20) NULL,
	[rt2] [varchar](5) NULL,
	[rw2] [varchar](5) NULL,
	[kelurahan2] [varchar](100) NULL,
	[kecamatan2] [varchar](100) NULL,
	[region2] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_biodata]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_biodata](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[created_by] [int] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [int] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [int] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[fullname] [varchar](255) NOT NULL,
	[nick_name] [varchar](100) NOT NULL,
	[pop] [varchar](100) NOT NULL,
	[dob] [date] NOT NULL,
	[gender] [bit] NOT NULL,
	[religion_id] [int] NOT NULL,
	[high] [int] NULL,
	[weights] [int] NULL,
	[nationality] [varchar](100) NULL,
	[ethnic] [varchar](50) NULL,
	[hobby] [varchar](255) NULL,
	[identity_type_id] [int] NOT NULL,
	[identity_no] [varchar](50) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[phone_number1] [varchar](50) NOT NULL,
	[phone_number2] [varchar](50) NULL,
	[parent_phone_number] [varchar](50) NOT NULL,
	[child_sequence] [varchar](5) NULL,
	[how_many_brothers] [varchar](5) NULL,
	[marital_status_id] [int] NOT NULL,
	[addrbook_id] [int] NULL,
	[token] [varchar](10) NULL,
	[expired_token] [date] NULL,
	[marriage_year] [varchar](10) NULL,
	[company_id] [int] NOT NULL,
	[is_process] [bit] NULL,
	[is_complete] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_catatan]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_catatan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[created_by] [int] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [int] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [int] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [int] NOT NULL,
	[title] [varchar](100) NULL,
	[note_type_id] [int] NULL,
	[notes] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_identity_type]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_identity_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_keahlian]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_keahlian](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[skill_name] [varchar](100) NULL,
	[skill_level_id] [bigint] NULL,
	[notes] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_martial_status]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_martial_status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_menu_access]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[x_menu_access](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[menuree_id] [bigint] NOT NULL,
	[role_id] [bigint] NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[x_menutree]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_menutree](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[menu_image_url] [varchar](100) NULL,
	[menu_icon] [varchar](100) NULL,
	[menu_order] [int] NOT NULL,
	[menu_level] [int] NOT NULL,
	[menu_parent] [bigint] NULL,
	[menu_url] [varchar](100) NOT NULL,
	[menu_type] [varchar](10) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_religion]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_religion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[created_by] [int] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [int] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [int] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_role]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_role](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_skill_level]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_skill_level](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_sumber_loker]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_sumber_loker](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[vacancy_source] [varchar](20) NULL,
	[candidate_type] [varchar](10) NULL,
	[event_name] [varchar](100) NULL,
	[career_center_name] [varchar](100) NULL,
	[referrer_name] [varchar](100) NULL,
	[referrer_phone] [varchar](20) NULL,
	[referrer_email] [varchar](100) NULL,
	[other_source] [varchar](100) NULL,
	[last_income] [varchar](20) NULL,
	[apply_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_userrole]    Script Date: 18/09/2019 13.41.13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[x_userrole](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[addrbook_id] [bigint] NOT NULL,
	[role_id] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [DBMiniProject208] SET  READ_WRITE 
GO
