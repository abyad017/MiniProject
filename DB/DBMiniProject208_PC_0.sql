USE [master]
GO
/****** Object:  Database [DBMiniProject208]    Script Date: 25/09/2019 22:23:46 ******/
CREATE DATABASE [DBMiniProject208]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBMiniMart208', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MOVENUESERVER\MSSQL\DATA\DBMiniMart208.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBMiniMart208_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MOVENUESERVER\MSSQL\DATA\DBMiniMart208_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBMiniProject208] SET COMPATIBILITY_LEVEL = 110
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
/****** Object:  Table [dbo].[x_addrbook]    Script Date: 25/09/2019 22:23:46 ******/
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
/****** Object:  Table [dbo].[x_address]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_address](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[biodata_id] [bigint] NULL,
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
/****** Object:  Table [dbo].[x_biodata]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_biodata](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[fullname] [varchar](255) NOT NULL,
	[nick_name] [varchar](100) NOT NULL,
	[pob] [varchar](100) NOT NULL,
	[dob] [date] NOT NULL,
	[gender] [bit] NOT NULL,
	[religion_id] [bigint] NOT NULL,
	[high] [int] NULL,
	[weights] [int] NULL,
	[nationality] [varchar](100) NULL,
	[ethnic] [varchar](50) NULL,
	[hobby] [varchar](255) NULL,
	[identity_type_id] [bigint] NOT NULL,
	[identity_no] [varchar](50) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[phone_number1] [varchar](50) NOT NULL,
	[phone_number2] [varchar](50) NULL,
	[parent_phone_number] [varchar](50) NOT NULL,
	[child_sequence] [varchar](5) NULL,
	[how_many_brothers] [varchar](5) NULL,
	[marital_status_id] [bigint] NOT NULL,
	[addrbook_id] [bigint] NULL,
	[token] [varchar](10) NULL,
	[expired_token] [date] NULL,
	[marriage_year] [varchar](10) NULL,
	[company_id] [bigint] NOT NULL,
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
/****** Object:  Table [dbo].[x_catatan]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_catatan](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[title] [varchar](100) NULL,
	[note_type_id] [bigint] NULL,
	[notes] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_identity_type]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_identity_type](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[created_by] [bigint] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_keahlian]    Script Date: 25/09/2019 22:23:46 ******/
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
/****** Object:  Table [dbo].[x_marital_status]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_marital_status](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[created_by] [bigint] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_menu_access]    Script Date: 25/09/2019 22:23:46 ******/
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
/****** Object:  Table [dbo].[x_menutree]    Script Date: 25/09/2019 22:23:46 ******/
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
/****** Object:  Table [dbo].[x_note_type]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_note_type](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NOT NULL,
	[created_on] [datetime] NOT NULL,
	[modify_by] [bigint] NULL,
	[modify_on] [datetime] NULL,
	[delete_by] [bigint] NULL,
	[delete_on] [datetime] NULL,
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
/****** Object:  Table [dbo].[x_religion]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_religion](
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
/****** Object:  Table [dbo].[x_riwayat_pendidikan]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_riwayat_pendidikan](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[biodata_id] [bigint] NULL,
	[school_name] [varchar](100) NULL,
	[major] [varchar](100) NULL,
	[create_by] [bigint] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[city] [nchar](50) NULL,
	[country] [nchar](50) NULL,
	[education_level_id] [bigint] NULL,
	[entry_year] [nchar](10) NULL,
	[graduation_year] [nchar](10) NULL,
	[gpa] [decimal](18, 0) NULL,
	[notes] [nchar](1000) NULL,
	[order] [int] NULL,
	[judul_ta] [nchar](255) NULL,
	[deskripsi_ta] [nchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_role]    Script Date: 25/09/2019 22:23:46 ******/
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
/****** Object:  Table [dbo].[x_schedule_type]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_schedule_type](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
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
/****** Object:  Table [dbo].[x_skill_level]    Script Date: 25/09/2019 22:23:46 ******/
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
/****** Object:  Table [dbo].[x_sumber_loker]    Script Date: 25/09/2019 22:23:46 ******/
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
/****** Object:  Table [dbo].[x_undangan]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_undangan](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[schedule_type_id] [bigint] NULL,
	[invitation_date] [date] NULL,
	[invitation_code] [varchar](20) NULL,
	[time] [varchar](10) NULL,
	[ro] [bigint] NULL,
	[tro] [bigint] NULL,
	[other_ro_tro] [varchar](100) NULL,
	[location] [varchar](100) NULL,
	[status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_undangan_detail]    Script Date: 25/09/2019 22:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[x_undangan_detail](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[created_by] [bigint] NULL,
	[created_on] [datetime] NULL,
	[modified_by] [bigint] NULL,
	[modified_on] [datetime] NULL,
	[deleted_by] [bigint] NULL,
	[deleted_on] [datetime] NULL,
	[is_delete] [bit] NULL,
	[undangan_id] [bigint] NOT NULL,
	[biodata_id] [bigint] NOT NULL,
	[notes] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[x_userrole]    Script Date: 25/09/2019 22:23:46 ******/
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
SET IDENTITY_INSERT [dbo].[x_address] ON 

INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Bekasi', N'16475', N'5', N'7', N'Sukamaju', N'Cilodong', N'Bekasi', N'Bekasi', N'16475', N'5', N'7', N'Sukamaju', N'Cilodong', N'Bekasi')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Depok', N'16475', N'5', N'10', N'Sukamaju', N'Cilodong', N'Depok', N'Depok', N'16475', N'5', N'10', N'Sukamaju', N'Cilodong', N'Depok')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (11, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (12, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (13, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (14, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 14, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (15, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 15, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Bekasi', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Bekasi')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (16, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 16, N'Padang', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Padang', N'Padang', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Padang')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (17, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 17, N'Banten', N'16475', N'2', N'4', N'Sukorojo', N'Banyuwangi', N'Banten', N'Banten', N'16475', N'2', N'4', N'Sukorojo', N'Banyuwangi', N'Banten')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 18, N'Pekalongan', N'16475', N'2', N'5', N'Sukorojo', N'Banyuwangi', N'Pekalongan', N'Pekalongan', N'16475', N'2', N'5', N'Sukorojo', N'Banyuwangi', N'Pekalongan')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 19, N'Pekalongan', N'16475', N'2', N'10', N'Sukamaju', N'Cilodong', N'Banten', N'Pekalongan', N'16475', N'2', N'10', N'Sukamaju', N'Banyuwangi', N'Bekasi')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (20, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 20, N'Serang', N'16475', N'6', N'10', N'Sukorojo', N'Cilodong', N'Padang', N'Serang', N'16475', N'6', N'7', N'Sukamaju', N'Cilodong', N'Padang')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (21, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 21, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Padang', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok')
INSERT [dbo].[x_address] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [address1], [postal_code1], [rt1], [rw1], [kelurahan1], [kecamatan1], [region1], [address2], [postal_code2], [rt2], [rw2], [kelurahan2], [kecamatan2], [region2]) VALUES (22, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 22, N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok', N'Depok', N'16475', N'6', N'10', N'Sukamaju', N'Cilodong', N'Depok')
SET IDENTITY_INSERT [dbo].[x_address] OFF
SET IDENTITY_INSERT [dbo].[x_biodata] ON 

INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Aji Saputra', N'Aji', N'Jakarta', CAST(N'2019-09-09' AS Date), 1, 1, 165, 50, N'Indonesia', N'Jawa', N'Futsal', 1, N'327666399993883663', N'muhmdteguh54@gmail.com', N'08999343972', N'08377465454', N'088994876', N'4', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Muhammad Teguh', N'Teguh', N'Jakarta', CAST(N'2019-09-09' AS Date), 1, 1, 170, 55, N'Indonesia', N'Jawa', N'Futsal', 1, N'327666399993883663', N'muhmdteguh54@gmail.com', N'08999343972', N'09093859839859', N'03989389768', N'3', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Reza Akbar', N'Mas Reza', N'Jakarta', CAST(N'2019-09-04' AS Date), 1, 1, 170, 55, N'Indonesia', N'Jawa', N'Baca Buku', 1, N'327666399993883663', N'rezaakbar24@gmail.com', N'085673442552', N'087634424426', N'08635534437773', N'1', N'2', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Farhan Nurrabbani', N'Farhan', N'Jakarta', CAST(N'2019-09-17' AS Date), 1, 1, 175, 60, N'Indonesia', N'Jawa', N'Futsal', 1, N'327666399993883663', N'farhannur@gmail.com', N'089994553663', N'098474664', N'089994664554', N'3', N'5', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (11, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Isabella Songko', N'songko', N'Jakarta', CAST(N'2019-09-09' AS Date), 0, 2, 165, 45, N'Indonesia', N'Jawa', N'Baca Buku', 2, N'327666399993883663', N'aaronfidel2@gmail.com', N'089993435622', N'08827726636', N'08993773633', N'2', N'3', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (12, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Aaron Fidel Pattipeilohy', N'Fidel', N'Ambon', CAST(N'2019-09-10' AS Date), 1, 4, 165, 55, N'Indonesia', N'Ambon', N'Futsal', 4, N'327666399993883663', N'fidel@gmail.com', N'0899937664553', N'085673553443', N'083766344443', N'2', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (13, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Sebastian Fadli', N'Sebas', N'Jakarta', CAST(N'2019-09-03' AS Date), 1, 1, 170, 55, N'Indonesia', N'Jawa', N'Futsal', 1, N'327666399993883663', N'fidel@gmail.com', N'089355366377', N'085677388833', N'083553636633', N'3', N'5', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (14, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Dimas Tri', N'Dimas', N'Minang', CAST(N'2019-09-10' AS Date), 1, 1, 170, 55, N'Indonesia', N'Jawa', N'Futsal', 1, N'327666399993883663', N'aaronfidel2@gmail.com', N'08999355366', N'00848746464554', N'00499474664', N'2', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (15, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Bakti Maulana', N'Bakti', N'Ambon', CAST(N'2019-09-04' AS Date), 1, 1, 170, 55, N'Indonesia', N'Ambon', N'Futsal', 1, N'327666399993883663', N'baktimaulana@gmail.com', N'089993438477', N'085677477744', N'08574664664', N'2', N'3', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (16, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Kemal Maulana', N'Kemal', N'Padang', CAST(N'2019-09-03' AS Date), 1, 3, 165, 55, N'Indonesia', N'Manise', N'Futsal', 1, N'327666399993883663', N'kemal@gmail.com', N'0899936366355', N'09377466644', N'08466477383', N'1', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (17, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Muhammad Fajar ', N'Fajar', N'Banten', CAST(N'2019-09-04' AS Date), 1, 1, 185, 60, N'Indonesia', N'Jawa', N'Baca Buku', 1, N'327666399993883663', N'fajar@gmail.com', N'08999343972', N'08355362773', N'08377366355', N'2', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Bento Akbar', N'Bento', N'Pekalongan', CAST(N'2019-09-05' AS Date), 1, 1, 177, 58, N'Indonesia', N'Jawa', N'Futsal', 1, N'327666399993883663', N'bento@gmail.com', N'08999343972', N'08355466663', N'09298387474', N'2', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Siti Nurjanah', N'Siti', N'Padang', CAST(N'2019-09-04' AS Date), 0, 3, 177, 55, N'Indonesia', N'Jawa', N'Baca Buku', 1, N'327666399993883663', N'siti@gmail.com', N'0856377365353', N'085637725333', N'083552777333', N'2', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (20, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Dimsky Ulala', N'Ulala', N'Serang', CAST(N'2019-09-03' AS Date), 1, 1, 165, 43, N'Indonesia', N'Sunda', N'Futsal', 3, N'327666399993883663', N'dimsky@gmail.com', N'08999343973', N'08958565665665', N'0846647747', N'2', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (21, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Muhammad Teguh', N'Teguh', N'Jakarta', CAST(N'2019-09-06' AS Date), 1, 1, 170, 55, N'Indonesia', N'Sunda', N'Baca Buku', 1, N'327666399993883663', N'teguh@gmail.com', N'083774747744', N'083993003883', N'083553663773', N'2', N'4', 1, NULL, NULL, NULL, N'-', 1, NULL, NULL)
INSERT [dbo].[x_biodata] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [fullname], [nick_name], [pob], [dob], [gender], [religion_id], [high], [weights], [nationality], [ethnic], [hobby], [identity_type_id], [identity_no], [email], [phone_number1], [phone_number2], [parent_phone_number], [child_sequence], [how_many_brothers], [marital_status_id], [addrbook_id], [token], [expired_token], [marriage_year], [company_id], [is_process], [is_complete]) VALUES (22, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Abdullah', N'Lolo', N'Jakarta', CAST(N'2019-08-07' AS Date), 1, 1, 175, 60, N'Indonesia', N'Jawa', N'Berenang', 1, N'327666399993883663', N'abdullah@gmail.com', N'0812663773773', N'0884663443', N'083999373663', N'3', N'4', 4, NULL, NULL, NULL, N'1986', 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[x_biodata] OFF
SET IDENTITY_INSERT [dbo].[x_catatan] ON 

INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (2, 1, CAST(N'2019-09-25 01:02:35.053' AS DateTime), NULL, NULL, NULL, NULL, 1, 1, N'test', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (3, 1, CAST(N'2019-09-25 01:55:00.623' AS DateTime), NULL, NULL, NULL, NULL, 0, 0, N'Interview', 1, N'-')
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10003, 1, CAST(N'2019-09-25 02:09:29.643' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'Interview', 1, N'-')
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10004, 1, CAST(N'2019-09-25 02:11:03.830' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'Interview', 1, N'-')
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10005, 1, CAST(N'2019-09-25 02:15:27.197' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'Interview', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10006, 1, CAST(N'2019-09-25 02:21:46.940' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'd', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10007, 1, CAST(N'2019-09-25 02:22:54.447' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'f', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10008, 1, CAST(N'2019-09-25 02:25:40.420' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N's', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10009, 1, CAST(N'2019-09-25 02:27:16.140' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N's', 2, N's')
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10010, 1, CAST(N'2019-09-25 02:28:44.720' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'c', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10011, 1, CAST(N'2019-09-25 02:29:55.387' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'g', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10012, 1, CAST(N'2019-09-25 02:31:06.453' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'h', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10013, 1, CAST(N'2019-09-25 02:32:04.343' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'R', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10014, 1, CAST(N'2019-09-25 02:34:46.927' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'k', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10015, 1, CAST(N'2019-09-25 02:36:04.533' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'ger', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10016, 1, CAST(N'2019-09-25 02:49:29.533' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'fe', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10017, 1, CAST(N'2019-09-25 02:56:49.807' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'fff', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10018, 1, CAST(N'2019-09-25 02:58:30.470' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'ferffef', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10019, 1, CAST(N'2019-09-25 03:53:05.327' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'Interview', 1, N'-')
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10020, 1, CAST(N'2019-09-25 03:53:55.717' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'Interview', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10021, 1, CAST(N'2019-09-25 04:04:28.013' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'a', 1, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10022, 1, CAST(N'2019-09-25 04:07:43.740' AS DateTime), NULL, NULL, NULL, NULL, 0, 0, N'Interview', 2, N'-')
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (10023, 1, CAST(N'2019-09-25 04:35:16.427' AS DateTime), NULL, NULL, NULL, NULL, 1, 0, N'Interview', 2, NULL)
INSERT [dbo].[x_catatan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [title], [note_type_id], [notes]) VALUES (20003, 1, CAST(N'2019-09-25 20:48:26.477' AS DateTime), NULL, NULL, NULL, NULL, 0, 0, N'Interview', 1, N'-')
SET IDENTITY_INSERT [dbo].[x_catatan] OFF
SET IDENTITY_INSERT [dbo].[x_identity_type] ON 

INSERT [dbo].[x_identity_type] ([id], [name], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [description]) VALUES (1, N'KTP', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_identity_type] ([id], [name], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [description]) VALUES (2, N'SIM', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_identity_type] ([id], [name], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [description]) VALUES (3, N'KK', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_identity_type] ([id], [name], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [description]) VALUES (4, N'Paspor', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[x_identity_type] OFF
SET IDENTITY_INSERT [dbo].[x_keahlian] ON 

INSERT [dbo].[x_keahlian] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [biodata_id], [skill_name], [skill_level_id], [notes]) VALUES (1, 1, CAST(N'2019-09-20 21:30:17.897' AS DateTime), NULL, NULL, NULL, NULL, 0, 2, N'Java', 1, N'-')
SET IDENTITY_INSERT [dbo].[x_keahlian] OFF
SET IDENTITY_INSERT [dbo].[x_marital_status] ON 

INSERT [dbo].[x_marital_status] ([id], [name], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [description]) VALUES (1, N'Single', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_marital_status] ([id], [name], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [description]) VALUES (2, N'Janda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_marital_status] ([id], [name], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [description]) VALUES (3, N'Duda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_marital_status] ([id], [name], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [description]) VALUES (4, N'Menikah', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[x_marital_status] OFF
SET IDENTITY_INSERT [dbo].[x_note_type] ON 

INSERT [dbo].[x_note_type] ([id], [created_by], [created_on], [modify_by], [modify_on], [delete_by], [delete_on], [is_delete], [name], [description]) VALUES (1, 1, CAST(N'2019-09-25 01:46:53.080' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Interview RO', NULL)
INSERT [dbo].[x_note_type] ([id], [created_by], [created_on], [modify_by], [modify_on], [delete_by], [delete_on], [is_delete], [name], [description]) VALUES (2, 1, CAST(N'2019-09-25 01:46:53.080' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Interview TRO', NULL)
SET IDENTITY_INSERT [dbo].[x_note_type] OFF
SET IDENTITY_INSERT [dbo].[x_religion] ON 

INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (1, 1, CAST(N'2019-09-22 22:05:57.200' AS DateTime), 1, CAST(N'2019-09-23 00:17:01.607' AS DateTime), NULL, NULL, 0, N'Islam', N'-')
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (2, 1, CAST(N'2019-09-22 22:06:07.940' AS DateTime), NULL, NULL, NULL, NULL, 1, N' Agama 2', N'-')
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (3, 1, CAST(N'2019-09-22 22:06:18.580' AS DateTime), 1, CAST(N'2019-09-22 22:06:24.583' AS DateTime), NULL, NULL, 1, N'Agama 4', N'-
')
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (4, 1, CAST(N'2019-09-22 22:38:53.817' AS DateTime), 1, CAST(N'2019-09-22 22:38:59.287' AS DateTime), NULL, NULL, 1, N'Agama 4', N'-')
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (5, 1, CAST(N'2019-09-23 00:00:22.300' AS DateTime), 1, CAST(N'2019-09-23 00:00:27.947' AS DateTime), NULL, NULL, 1, N'Agama 3', N'-')
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (6, 1, CAST(N'2019-09-23 00:19:57.373' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Kristen', N'-')
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (7, 1, CAST(N'2019-09-23 21:20:26.807' AS DateTime), 1, CAST(N'2019-09-24 13:57:30.217' AS DateTime), NULL, NULL, 0, N'Katolik', N'-')
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (8, 1, CAST(N'2019-09-23 21:20:38.047' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 4', NULL)
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (9, 1, CAST(N'2019-09-23 21:20:45.813' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 5', NULL)
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (10, 1, CAST(N'2019-09-23 21:20:52.293' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 6', NULL)
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (11, 1, CAST(N'2019-09-23 21:20:57.000' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 7', NULL)
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (12, 1, CAST(N'2019-09-23 21:21:02.517' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 8', NULL)
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (13, 1, CAST(N'2019-09-23 21:21:09.367' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 9', NULL)
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (14, 1, CAST(N'2019-09-23 21:21:13.930' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 10', NULL)
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (15, 1, CAST(N'2019-09-23 21:21:20.727' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 11', NULL)
INSERT [dbo].[x_religion] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (16, 1, CAST(N'2019-09-25 00:33:47.927' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Agama 12', N'-')
SET IDENTITY_INSERT [dbo].[x_religion] OFF
SET IDENTITY_INSERT [dbo].[x_riwayat_pendidikan] ON 

INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (1, 7, N'ITB', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (2, 8, N'UI', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (3, 9, N'Harvard University', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (4, 10, N'Pakuan University', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (5, 11, N'ITB', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (6, 12, N'UI', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (7, 13, N'Harvard University', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (8, 14, N'Pakuan University', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (9, 15, N'ITB', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (10, 16, N'UI', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (11, 17, N'Harvard University', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (12, 18, N'Pakuan University', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (13, 19, N'ITB', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (14, 20, N'ITB', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (15, 9, N'SMA 1', N'Teknik Informatika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[x_riwayat_pendidikan] ([id], [biodata_id], [school_name], [major], [create_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [city], [country], [education_level_id], [entry_year], [graduation_year], [gpa], [notes], [order], [judul_ta], [deskripsi_ta]) VALUES (16, 22, N'Universitas Padjajaran', N'Kesenian', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[x_riwayat_pendidikan] OFF
SET IDENTITY_INSERT [dbo].[x_skill_level] ON 

INSERT [dbo].[x_skill_level] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [name], [description]) VALUES (1, 1, CAST(N'2019-09-20 21:29:55.973' AS DateTime), NULL, NULL, NULL, NULL, 0, N'Beginner', NULL)
SET IDENTITY_INSERT [dbo].[x_skill_level] OFF
SET IDENTITY_INSERT [dbo].[x_undangan] ON 

INSERT [dbo].[x_undangan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [schedule_type_id], [invitation_date], [invitation_code], [time], [ro], [tro], [other_ro_tro], [location], [status]) VALUES (1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, CAST(N'2019-03-12' AS Date), N'UD0001', N'13:00', 8, 8, N'apalah', N'jakarta', N'uhuy')
INSERT [dbo].[x_undangan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [schedule_type_id], [invitation_date], [invitation_code], [time], [ro], [tro], [other_ro_tro], [location], [status]) VALUES (2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, CAST(N'2019-09-28' AS Date), N'UD0002', N'21:00', 14, 14, N'hallo', N'jakarta selatan', NULL)
INSERT [dbo].[x_undangan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [schedule_type_id], [invitation_date], [invitation_code], [time], [ro], [tro], [other_ro_tro], [location], [status]) VALUES (3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, CAST(N'2019-09-30' AS Date), N'UD0003', N'12:30', 20, 20, N'Apaaja', N'Kuningan, Jakarta Selatan', NULL)
INSERT [dbo].[x_undangan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [schedule_type_id], [invitation_date], [invitation_code], [time], [ro], [tro], [other_ro_tro], [location], [status]) VALUES (4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, CAST(N'2019-09-26' AS Date), N'UD0004', N'14:30', 18, 18, N'Apaaja', N'Bandung', NULL)
INSERT [dbo].[x_undangan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [schedule_type_id], [invitation_date], [invitation_code], [time], [ro], [tro], [other_ro_tro], [location], [status]) VALUES (5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, CAST(N'2019-09-28' AS Date), N'UD0005', N'13.40', 12, 12, N'Sasongko', N'Depok Timur', NULL)
INSERT [dbo].[x_undangan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [schedule_type_id], [invitation_date], [invitation_code], [time], [ro], [tro], [other_ro_tro], [location], [status]) VALUES (6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2019-09-28' AS Date), N'UD0006', N'15.00', 16, 16, N'Dimas', N'Bandung Jawa Barat', NULL)
INSERT [dbo].[x_undangan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [schedule_type_id], [invitation_date], [invitation_code], [time], [ro], [tro], [other_ro_tro], [location], [status]) VALUES (7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2019-09-29' AS Date), N'UD0007', N'17:30', 10, 10, N'Apaaja', N'Banten ', NULL)
INSERT [dbo].[x_undangan] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [schedule_type_id], [invitation_date], [invitation_code], [time], [ro], [tro], [other_ro_tro], [location], [status]) VALUES (8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2019-09-30' AS Date), N'UD0008', N'19:00', 22, 22, N'hallo', N'Sudirman', NULL)
SET IDENTITY_INSERT [dbo].[x_undangan] OFF
SET IDENTITY_INSERT [dbo].[x_undangan_detail] ON 

INSERT [dbo].[x_undangan_detail] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [undangan_id], [biodata_id], [notes]) VALUES (1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, 14, N'Bawa laptop')
INSERT [dbo].[x_undangan_detail] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [undangan_id], [biodata_id], [notes]) VALUES (2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3, 20, N'Membawa Laptop Pribadi')
INSERT [dbo].[x_undangan_detail] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [undangan_id], [biodata_id], [notes]) VALUES (3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, 18, N'Bawa laptop dan Rapih')
INSERT [dbo].[x_undangan_detail] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [undangan_id], [biodata_id], [notes]) VALUES (4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 5, 12, N'Memakai Baju Putih Lengan Panjang')
INSERT [dbo].[x_undangan_detail] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [undangan_id], [biodata_id], [notes]) VALUES (5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 6, 16, N'Memakai Baju Putih Lengan Panjang')
INSERT [dbo].[x_undangan_detail] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [undangan_id], [biodata_id], [notes]) VALUES (6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 10, N'Memakai Baju Putih Lengan Panjang')
INSERT [dbo].[x_undangan_detail] ([id], [created_by], [created_on], [modified_by], [modified_on], [deleted_by], [deleted_on], [is_delete], [undangan_id], [biodata_id], [notes]) VALUES (7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 8, 22, N'Bawa Alat Tulis Lengkap')
SET IDENTITY_INSERT [dbo].[x_undangan_detail] OFF
USE [master]
GO
ALTER DATABASE [DBMiniProject208] SET  READ_WRITE 
GO
