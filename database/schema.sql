USE [master]
GO
/****** Object:  Database [LibraryManagementSystem]    Script Date: 6/5/2025 8:03:42 AM ******/
CREATE DATABASE [LibraryManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\LibraryManagementSystem.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\LibraryManagementSystem_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LibraryManagementSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LibraryManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [LibraryManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LibraryManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LibraryManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LibraryManagementSystem', N'ON'
GO
ALTER DATABASE [LibraryManagementSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [LibraryManagementSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LibraryManagementSystem]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAuthorName]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create Function [dbo].[GetAuthorName](@AuthorID int)
returns nvarchar(50)
as
begin
	
	return 	(select AuthorName from Authors_View where AuthorID = @AuthorID);
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetNextMemberFromReservationsList]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE function [dbo].[GetNextMemberFromReservationsList] (@BookID int)
returns int
as
begin
	return (select top 1 MemberID from Reservations where ReservationStatus = 1 and BookID = @BookID)

end
GO
/****** Object:  UserDefinedFunction [dbo].[GetPublisherName]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create Function [dbo].[GetPublisherName](@PublisherID int)
returns nvarchar(50)
as
begin
	
	return 	(select PublisherName from Publishers_View where PublisherID = @PublisherID);
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalAvailableCopies]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create function [dbo].[GetTotalAvailableCopies](@BookID int)
returns int
begin
	return (SELECT COUNT(BookCopyID) AS Expr1
                       FROM      dbo.BookCopies AS BookCopies_1
                       WHERE   (BookID = @BookID) AND (IsAvailable = 1) AND (IsDamaged = 0));
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalCopies]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create function [dbo].[GetTotalCopies](@BookID int)
returns int
begin
	return (SELECT COUNT(BookCopyID) 
                       FROM      dbo.BookCopies
                       WHERE   (BookID = @BookID));
end
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[ReservationID] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[ReservationDate] [date] NOT NULL,
	[ReservationStatus] [smallint] NOT NULL,
	[CreatedByUserID] [int] NOT NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Reservations_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Reservations_View]
AS
SELECT ReservationID, MemberID, BookID, ReservationDate, 
                  CASE WHEN ReservationStatus = 1 THEN 'Pending' WHEN ReservationStatus = 2 THEN 'Available' WHEN ReservationStatus = 3 THEN 'Compelete' WHEN ReservationStatus = 4 THEN 'Cancelled' END AS ReservationStatus
FROM     dbo.Reservations
GO
/****** Object:  Table [dbo].[BookCopies]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCopies](
	[BookCopyID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[ReservedForMemberID] [int] NULL,
	[IsAvailable] [bit] NOT NULL,
	[IsDamaged] [bit] NOT NULL,
 CONSTRAINT [PK_BookCopies] PRIMARY KEY CLUSTERED 
(
	[BookCopyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrows]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrows](
	[BorrowID] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NOT NULL,
	[CopyID] [int] NOT NULL,
	[BorrowDate] [datetime] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	[PaidFees] [smallmoney] NOT NULL,
	[CreatedByUserID] [int] NOT NULL,
	[ReturnNotes] [nvarchar](50) NULL,
	[ReturnDate] [datetime] NULL,
	[ReturnFees] [smallmoney] NULL,
	[ReturnedByUserID] [int] NULL,
 CONSTRAINT [PK_Borrows] PRIMARY KEY CLUSTERED 
(
	[BorrowID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[NationalNo] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[SecondName] [nvarchar](50) NOT NULL,
	[ThirdName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Gender] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedByUserID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[AuthorID] [int] NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
	[PublisherID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Year] [date] NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
	[BorrowFees] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [ISBN_unique] UNIQUE NONCLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Borrows_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Borrows_View]
AS
SELECT dbo.Borrows.BorrowID, dbo.Borrows.MemberID, dbo.People.FirstName + '  ' + dbo.People.SecondName + '  ' + ISNULL(dbo.People.ThirdName, '') + '  ' + dbo.People.LastName AS MemberName, dbo.Books.Title, dbo.BookCopies.BookCopyID, 
                  CASE WHEN ReturnDate IS NULL THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END AS IsReturned
FROM     dbo.Borrows INNER JOIN
                  dbo.Members ON dbo.Borrows.MemberID = dbo.Members.MemberID INNER JOIN
                  dbo.People ON dbo.Members.PersonID = dbo.People.PersonID INNER JOIN
                  dbo.BookCopies ON dbo.Borrows.CopyID = dbo.BookCopies.BookCopyID INNER JOIN
                  dbo.Books ON dbo.BookCopies.BookID = dbo.Books.BookID
GO
/****** Object:  Table [dbo].[Fines]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fines](
	[FineID] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NOT NULL,
	[BorrowID] [int] NOT NULL,
	[FineAmount] [smallmoney] NOT NULL,
	[PaidAmount] [smallmoney] NOT NULL,
	[FineDate] [datetime] NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[Reason] [int] NOT NULL,
 CONSTRAINT [PK_Fines] PRIMARY KEY CLUSTERED 
(
	[FineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Fines_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Fines_View]
AS
SELECT FineID, MemberID, BorrowID, FineAmount, PaidAmount, FineDate, IsPaid, CASE WHEN Reason = 0 THEN 'Over Due Date' ELSE 'DamagedBook' END AS FineReason
FROM     dbo.Fines
GO
/****** Object:  Table [dbo].[BookCategories]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCategories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Catgories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[BookData_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BookData_View]
AS
SELECT dbo.Books.BookID, dbo.Books.Title, dbo.Books.Author, dbo.Books.ISBN, dbo.BookCategories.CategoryName, dbo.Books.Location, dbo.Books.LoanFees,
                      (SELECT COUNT(BookCopyID) AS Expr1
                       FROM      dbo.BookCopies
                       WHERE   (BookID = dbo.Books.BookID)) AS TotalCopies, CASE WHEN
                      (SELECT COUNT(BookCopyID)
                       FROM      BookCopies
                       WHERE   BookCopies.BookID = Books.BookID AND IsAvailable = 1 AND BookCopies.ReservedForMemberID IS NULL) > 0 THEN 'Availabel' ELSE 'Checked Out' END AS Availablability
FROM     dbo.Books INNER JOIN
                  dbo.BookCategories ON dbo.Books.CategoryID = dbo.BookCategories.CategoryID
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](500) NOT NULL,
	[UserRoles] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Users_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Users_View]
AS
SELECT dbo.Users.UserID, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' ' + dbo.People.LastName AS FullName, dbo.Users.UserName, 
                  CASE WHEN Users.UserRoles = 0 THEN 'Admin' WHEN Users.UserRoles = 1 THEN 'Librarian' END AS UserRols, dbo.Users.IsActive
FROM     dbo.Users INNER JOIN
                  dbo.People ON dbo.Users.PersonID = dbo.People.PersonID
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Authors_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Authors_View]
AS
SELECT dbo.Authors.AuthorID, dbo.People.FirstName + '  ' + dbo.People.SecondName + '  ' + ISNULL(dbo.People.ThirdName, '') + '  ' + dbo.People.LastName AS AuthorName, dbo.People.Email, dbo.People.Phone,
                      (SELECT COUNT(BookID) AS Expr1
                       FROM      dbo.Books
                       WHERE   (AuthorID = dbo.Authors.AuthorID)) AS TotalBooks
FROM     dbo.Authors INNER JOIN
                  dbo.People ON dbo.Authors.PersonID = dbo.People.PersonID
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Publishers_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Publishers_View]
AS
SELECT dbo.Publishers.PublisherID, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' ' + dbo.People.LastName AS PublisherName, dbo.People.Email, dbo.People.Phone,
                      (SELECT COUNT(BookID) AS Expr1
                       FROM      dbo.Books
                       WHERE   (PublisherID = dbo.Publishers.PublisherID)) AS TotalBooks
FROM     dbo.Publishers INNER JOIN
                  dbo.People ON dbo.Publishers.PersonID = dbo.People.PersonID
GO
/****** Object:  View [dbo].[Book_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Book_View]
AS
SELECT dbo.Books.BookID, dbo.Books.Title, dbo.GetAuthorName(dbo.Books.AuthorID) AS Author, dbo.Books.ISBN, dbo.GetPublisherName(dbo.Books.PublisherID) AS Publisher, dbo.BookCategories.CategoryName, dbo.Books.Location, 
                  dbo.Books.BorrowFees, dbo.GetTotalCopies(dbo.Books.BookID) AS TotalCopies, dbo.GetTotalAvailableCopies(dbo.Books.BookID) AS AvailableCopies
FROM     dbo.Books INNER JOIN
                  dbo.BookCategories ON dbo.Books.CategoryID = dbo.BookCategories.CategoryID
GO
/****** Object:  Table [dbo].[Memberships]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Memberships](
	[MembershipID] [int] IDENTITY(1,1) NOT NULL,
	[MemberID] [int] NOT NULL,
	[MembershipClassID] [int] NOT NULL,
	[MembershipStartDate] [datetime] NOT NULL,
	[MembershipExpirationDate] [datetime] NOT NULL,
	[PaidFees] [smallmoney] NOT NULL,
	[CreatedByUserID] [int] NOT NULL,
 CONSTRAINT [PK_Memberships] PRIMARY KEY CLUSTERED 
(
	[MembershipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MembershipClasses]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MembershipClasses](
	[MembershipClassID] [int] IDENTITY(1,1) NOT NULL,
	[MembershipClassName] [nvarchar](50) NOT NULL,
	[MaxNumberOfBooksCanBorrow] [int] NOT NULL,
	[FeesPerDay] [smallmoney] NOT NULL,
 CONSTRAINT [PK_MembershipClasses] PRIMARY KEY CLUSTERED 
(
	[MembershipClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Members_View]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Members_View]
AS
SELECT dbo.Members.MemberID, dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' ' + dbo.People.LastName AS FullName, dbo.Memberships.MembershipStartDate, 
                  dbo.Memberships.MembershipExpirationDate, dbo.MembershipClasses.MembershipClassName,
                      (SELECT COUNT(BorrowID) AS Expr1
                       FROM      dbo.Borrows
                       WHERE   (MemberID = dbo.Members.MemberID)) AS TotalBorrowedBooks, dbo.Members.IsActive
FROM     dbo.Members INNER JOIN
                  dbo.People ON dbo.Members.PersonID = dbo.People.PersonID INNER JOIN
                  dbo.Memberships ON dbo.Members.MemberID = dbo.Memberships.MemberID AND dbo.Memberships.MembershipExpirationDate =
                      (SELECT TOP (1) MembershipExpirationDate
                       FROM      dbo.Memberships
                       WHERE   (MemberID = dbo.Members.MemberID)
                       ORDER BY MembershipID DESC) INNER JOIN
                  dbo.MembershipClasses ON dbo.Memberships.MembershipClassID = dbo.MembershipClasses.MembershipClassID
GO
/****** Object:  Table [dbo].[LibrarySettings]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibrarySettings](
	[FineAmountPerDay] [smallmoney] NOT NULL,
	[FineForDamagedBook] [smallmoney] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maintenances]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maintenances](
	[MaintenanceID] [int] IDENTITY(1,1) NOT NULL,
	[CopyID] [int] NOT NULL,
	[Desctiption] [nvarchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Cost] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Maintenances] PRIMARY KEY CLUSTERED 
(
	[MaintenanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[FineID] [int] NOT NULL,
	[PaidAmount] [smallmoney] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[PaidByUserID] [int] NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Idx_Books_Title]    Script Date: 6/5/2025 8:03:43 AM ******/
CREATE NONCLUSTERED INDEX [Idx_Books_Title] ON [dbo].[Books]
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Books_ISBN]    Script Date: 6/5/2025 8:03:43 AM ******/
CREATE NONCLUSTERED INDEX [IX_Books_ISBN] ON [dbo].[Books]
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Idx_Borrows_CopyID]    Script Date: 6/5/2025 8:03:43 AM ******/
CREATE NONCLUSTERED INDEX [Idx_Borrows_CopyID] ON [dbo].[Borrows]
(
	[CopyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Idx_Membership_MemberID]    Script Date: 6/5/2025 8:03:43 AM ******/
CREATE NONCLUSTERED INDEX [Idx_Membership_MemberID] ON [dbo].[Memberships]
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_People]    Script Date: 6/5/2025 8:03:43 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_People] ON [dbo].[People]
(
	[NationalNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Idx_Users_UserNama]    Script Date: 6/5/2025 8:03:43 AM ******/
CREATE NONCLUSTERED INDEX [Idx_Users_UserNama] ON [dbo].[Users]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Authors] ADD  CONSTRAINT [DF_Authors_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Borrows] ADD  CONSTRAINT [DF_Borrows_BorrowDate]  DEFAULT (getdate()) FOR [BorrowDate]
GO
ALTER TABLE [dbo].[Fines] ADD  CONSTRAINT [DF_Fines_PaidAmount]  DEFAULT ((0)) FOR [PaidAmount]
GO
ALTER TABLE [dbo].[Fines] ADD  CONSTRAINT [DF_Fines_FineDate]  DEFAULT (getdate()) FOR [FineDate]
GO
ALTER TABLE [dbo].[Fines] ADD  CONSTRAINT [DF_Fines_IsPaid]  DEFAULT ((0)) FOR [IsPaid]
GO
ALTER TABLE [dbo].[Maintenances] ADD  CONSTRAINT [DF_Maintenances_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Members] ADD  CONSTRAINT [DF_Members_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Memberships] ADD  CONSTRAINT [DF_Memberships_MembershipStartDate]  DEFAULT (getdate()) FOR [MembershipStartDate]
GO
ALTER TABLE [dbo].[Payments] ADD  CONSTRAINT [DF_Payments_PaymentDate]  DEFAULT (getdate()) FOR [PaymentDate]
GO
ALTER TABLE [dbo].[Publishers] ADD  CONSTRAINT [DF_Publishers_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Reservations] ADD  CONSTRAINT [DF_Reservations_ReservationDate]  DEFAULT (getdate()) FOR [ReservationDate]
GO
ALTER TABLE [dbo].[Reservations] ADD  CONSTRAINT [DF_Reservations_ReservationStatus]  DEFAULT ((1)) FOR [ReservationStatus]
GO
ALTER TABLE [dbo].[Authors]  WITH CHECK ADD  CONSTRAINT [FK_Authors_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Authors] CHECK CONSTRAINT [FK_Authors_People]
GO
ALTER TABLE [dbo].[BookCopies]  WITH CHECK ADD  CONSTRAINT [FK_BookCopies_Books1] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[BookCopies] CHECK CONSTRAINT [FK_BookCopies_Books1]
GO
ALTER TABLE [dbo].[BookCopies]  WITH CHECK ADD  CONSTRAINT [FK_BookCopies_Members] FOREIGN KEY([ReservedForMemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
ALTER TABLE [dbo].[BookCopies] CHECK CONSTRAINT [FK_BookCopies_Members]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Catgories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[BookCategories] ([CategoryID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Catgories]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publishers] ([PublisherID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[Borrows]  WITH CHECK ADD  CONSTRAINT [FK_Loans_BookCopies] FOREIGN KEY([CopyID])
REFERENCES [dbo].[BookCopies] ([BookCopyID])
GO
ALTER TABLE [dbo].[Borrows] CHECK CONSTRAINT [FK_Loans_BookCopies]
GO
ALTER TABLE [dbo].[Borrows]  WITH CHECK ADD  CONSTRAINT [FK_Loans_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
ALTER TABLE [dbo].[Borrows] CHECK CONSTRAINT [FK_Loans_Members]
GO
ALTER TABLE [dbo].[Borrows]  WITH CHECK ADD  CONSTRAINT [FK_Loans_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Borrows] CHECK CONSTRAINT [FK_Loans_Users]
GO
ALTER TABLE [dbo].[Borrows]  WITH CHECK ADD  CONSTRAINT [FK_Loans_Users1] FOREIGN KEY([ReturnedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Borrows] CHECK CONSTRAINT [FK_Loans_Users1]
GO
ALTER TABLE [dbo].[Fines]  WITH CHECK ADD  CONSTRAINT [FK_Fines_Loans] FOREIGN KEY([BorrowID])
REFERENCES [dbo].[Borrows] ([BorrowID])
GO
ALTER TABLE [dbo].[Fines] CHECK CONSTRAINT [FK_Fines_Loans]
GO
ALTER TABLE [dbo].[Fines]  WITH CHECK ADD  CONSTRAINT [FK_Fines_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
ALTER TABLE [dbo].[Fines] CHECK CONSTRAINT [FK_Fines_Members]
GO
ALTER TABLE [dbo].[Maintenances]  WITH CHECK ADD  CONSTRAINT [FK_Maintenances_BookCopies] FOREIGN KEY([CopyID])
REFERENCES [dbo].[BookCopies] ([BookCopyID])
GO
ALTER TABLE [dbo].[Maintenances] CHECK CONSTRAINT [FK_Maintenances_BookCopies]
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD  CONSTRAINT [FK_Members_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Members] CHECK CONSTRAINT [FK_Members_People]
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD  CONSTRAINT [FK_Members_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Members] CHECK CONSTRAINT [FK_Members_Users]
GO
ALTER TABLE [dbo].[Memberships]  WITH CHECK ADD  CONSTRAINT [FK_Memberships_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
ALTER TABLE [dbo].[Memberships] CHECK CONSTRAINT [FK_Memberships_Members]
GO
ALTER TABLE [dbo].[Memberships]  WITH CHECK ADD  CONSTRAINT [FK_Memberships_MembershipClasses] FOREIGN KEY([MembershipClassID])
REFERENCES [dbo].[MembershipClasses] ([MembershipClassID])
GO
ALTER TABLE [dbo].[Memberships] CHECK CONSTRAINT [FK_Memberships_MembershipClasses]
GO
ALTER TABLE [dbo].[Memberships]  WITH CHECK ADD  CONSTRAINT [FK_Memberships_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Memberships] CHECK CONSTRAINT [FK_Memberships_Users]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Fines] FOREIGN KEY([FineID])
REFERENCES [dbo].[Fines] ([FineID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Fines]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Users] FOREIGN KEY([PaidByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Users]
GO
ALTER TABLE [dbo].[Publishers]  WITH CHECK ADD  CONSTRAINT [FK_Publishers_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Publishers] CHECK CONSTRAINT [FK_Publishers_People]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Books]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Members]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_People]
GO
ALTER TABLE [dbo].[Fines]  WITH CHECK ADD  CONSTRAINT [CK_Fines_PaidAmount] CHECK  (([PaidAmount]<=[FineAmount]))
GO
ALTER TABLE [dbo].[Fines] CHECK CONSTRAINT [CK_Fines_PaidAmount]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewAuthor]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_AddNewAuthor]
				@PersonID int 
as
begin
	insert into Authors (PersonID) values (@PersonID)
	return @@identity
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewBook]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_AddNewBook] 
					@Title nvarchar(50), 
					@AuthorID int, 
					@ISBN nvarchar(50), 
					@PublisherID int ,    
					@CategoryID int, 
					@Year datetime, 
					@Location nvarchar(50),
					@BorrowFees smallmoney,
					@TheNumberOfCopies int,
					@TheRowAffected int OUTPut
as
begin
		declare @ThisBookID int;
	    INSERT INTO Books(Title,AuthorID ,ISBN,PublisherID,CategoryID,Year,Location,BorrowFees)
		VALUES( @Title, @AuthorID,@ISBN,@PublisherID,@CategoryID,@Year,@Location,@BorrowFees);
		set @ThisBookID = @@Identity;
		exec sp_AddNumberOfCopies
				@BookID = @ThisBookID,
				@NumberOfCopies =@TheNumberOfCopies,
				 @RowAffected = @TheNumberOfCopies

		return @ThisBookID;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewCategory]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddNewCategory] 
			@CategoryName  nvarchar(50)
as 
begin 
	insert into BookCategories (CategoryName) values (@CategoryName)
	return  @@identity
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewPerson]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_AddNewPerson]
			   @NationalNo nvarchar(50),
			   @FirstName nvarchar(50),
			   @SecondName nvarchar(50),
			   @ThirdName nvarchar(50),
			   @LastName nvarchar(50),
			   @Gender int,
			   @Email nvarchar(50),
			   @Phone nvarchar(50),
			   @Address nvarchar(50)
as
begin
	INSERT INTO People
           (NationalNo,
			   FirstName ,
			   SecondName,
			   ThirdName,
			   LastName ,
			   Gender ,
			   Email ,
			   Phone ,
			   Address)
     VALUES
           (@NationalNo,
			   @FirstName ,
			   @SecondName,
			   @ThirdName,
			   @LastName ,
			   @Gender ,
			   @Email ,
			   @Phone ,
			   @Address )
		return @@identity;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewPublisher]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_AddNewPublisher]
				@PersonID int
as
begin
	insert into Publishers (PersonID) values (@PersonID)
	return @@Identity;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_AddNewUser]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_AddNewUser]
		@PersonID int, 
		@UserName nvarchar(50) , 
		@Password nvarchar(500),
		@UserRoles bit,
		@IsActive bit
as 
begin
	    INSERT INTO Users (PersonID,UserName,Password,UserRoles,IsActive)
		VALUES(@PersonID, @UserName, @Password,@UserRoles,@IsActive);
		return SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddNumberOfCopies]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_AddNumberOfCopies]
	@BookID int,
	@NumberOfCopies int,
	@RowAffected  int out 
as
begin
	declare @ReservationListe Table (

		MemberID int 
		)
	declare @CurrentMemberID int ;
	set @RowAffected = 0;
	DECLARE @counter INT = 1;
	WHILE @counter <= @NumberOfCopies
	BEGIN
	INSERT INTO BookCopies (BookID, isAvailable, IsDamaged)
	VALUES (@BookID,  1, 0);
	set @RowAffected = @@RowCount +@RowAffected;
	exec sp_ReserveCopyToMember 
					@SelectedCopyID = @@IDENTITY,
					@SelectedMemberID  =  @CurrentMemberID out;
	if @CurrentMemberID is not null
		begin
			insert into @ReservationListe (MemberID) values (@CurrentMemberID);
		end
	SET @counter = @counter + 1;
	END	
	select * from @ReservationListe;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BorrowBook]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_BorrowBook] 
			@MemberID int,
			@HasReservation bit ,
			@BookID int,
			@DueDate datetime ,
			@PaidFees smallmoney,
			@CreatedByUserID int,
			@CopyID int OUT,
			@BorrowID int OUT
as
begin
	if @HasReservation = 1 
		begin
			set @CopyID = (Select BookCopyID from BookCopies where ReservedForMemberID  = @MemberID and BookID = @BookID );
			Update BookCopies set ReservedForMemberID = NULL where BookCopyID = @CopyID;
		end
	else
		begin
			set @CopyID = (select Top 1 BookCopyID from BookCopies where BookID = @BookID and IsDamaged = 0 and IsAvailable = 1 and ReservedForMemberID is NULL);
		end
	insert into Borrows(MemberID,CopyID,DueDate,PaidFees,CreatedByUserID) values (@MemberID,@CopyID,@DueDate,@PaidFees,@CreatedByUserID);
	set @BorrowID = @@Identity; 
	update Reservations set ReservationStatus = 3 where BookID = @BookID and ReservationStatus  in (1,2) and  MemberID = @MemberID;
	update BookCopies set IsAvailable = 0 where BookCopyID = @CopyID;
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CancelReservation]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_CancelReservation]
					@ReservationID int,
					@ReservedForMemberID int out
as 
begin
	declare @MemberID int = (select MemberID from Reservations where ReservationID = @ReservationID)
	declare @BookID int = (select BookID from Reservations where ReservationID = @ReservationID);
	declare @CopyID int = (select BookCopyID from BookCopies where BookID = @BookID and ReservedForMemberID = @MemberID);
	if @CopyID is not null
		begin 
			update BookCopies set ReservedForMemberID = NULL where BookCopyID = @CopyID;
			exec sp_ReserveCopyToMember
					@SelectedCopyID = @CopyID,
					@SelectedMemberID  =@ReservedForMemberID out;
		end
	update Reservations set ReservationStatus = 4 where ReservationID = @ReservationID;
	return @@RowCount
end
GO
/****** Object:  StoredProcedure [dbo].[sp_FindBookByID]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[sp_FindBookByID]
	@bookID int
as
begin
	select * from Books where BookID = @bookID
end
GO
/****** Object:  StoredProcedure [dbo].[sp_PayFine]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[sp_PayFine]
				@FineID int,
				@PaidByUserID int,
				@PaidAmount smallMoney
as
begin
	declare @RowAffected int = 0;
	insert into Payments (FineID,paidAmount,PaidByUserID) values(@FineID,@PaidAmount,@PaidByUserID)
	set @RowAffected += @@ROWCOUNT;
	update Fines Set PaidAmount += @PaidAmount where FineID = @FineID;
	set @RowAffected += @@ROWCOUNT;
	return @RowAffected;
end


GO
/****** Object:  StoredProcedure [dbo].[sp_RepairBookCopy]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_RepairBookCopy]
					@CopyID int, 
					@Description nvarchar(50),
					@Cost smallmoney,
					@Date datetime,
					@ReservedForMemberID int Out
as
begin
	declare @RowsAffected int ;
	insert into Maintenances (CopyID,Desctiption,Date,Cost) values (@CopyID,@Description,@Date,@Cost)

	update BookCopies set IsDamaged = 0 where BookCopyID = @CopyID;
	set @RowsAffected = @@ROWCOUNT;
	exec sp_ReserveCopyToMember 
			@SelectedCopyID = @CopyID,
			@SelectedMemberID    =  @ReservedForMemberID out;
	return @RowsAffected;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ReserveCopyToMember]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_ReserveCopyToMember]
					@SelectedCopyID int,
					@SelectedMemberID int out
as
begin
	declare @BookID int = (select top 1 BookID from BookCopies where BookCopyID = @SelectedCopyID);
	set @SelectedMemberID  = (select dbo.GetNextMemberFromReservationsList(@BookID));
			if @SelectedMemberID is not null
			begin
				Update BookCopies 
					set ReservedForMemberID = @SelectedMemberID
					where BookCopyID = @SelectedCopyID;
				update Reservations set ReservationStatus = 2 
					where MemberID = @SelectedMemberID and BookID = @BookID and ReservationStatus  = 1;
			end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ReturnBook]    Script Date: 6/5/2025 8:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_ReturnBook]
	@BorrowID int,
	@ReturnNote nvarchar(50),
	@IsDamaged bit,
	@ReturnedByUserID int, 
	@TotalReturnFees smallmoney out,
	@ReservedForMemberID int out	
as
begin
	declare @MemberID int = (select MemberID from Borrows where BorrowID = @BorrowID);
	declare  @ReturnFees smallmoney = 0;
	declare @BookCopyID int = (select CopyID from Borrows where BorrowID = @BorrowID);
	declare @ReturnDate datetime = (select Getdate());
	declare @DueDateFineAmount smallmoney;
	Update BookCopies 
			set IsAvailable = 1 , IsDamaged = @IsDamaged where BookCopyID = @BookCopyID;
	if @IsDamaged  =1
		begin
			INSERT INTO Fines
           (MemberID,BorrowID,FineAmount,Reason)
			 VALUES(@MemberID,@BorrowID,(select FineForDamagedBook from [LibrarySettings]),1);
			 set @ReturnFees += (select FineForDamagedBook from LibrarySettings);
		end
	else
		begin
			exec sp_ReserveCopyToMember 
					@SelectedCopyID = @BookCopyID,
					@SelectedMemberID    =  @ReservedForMemberID out;			
			--if @ReservedForMemberID is not NULL
			--	begin
			--		update Reservations set ReservationStatus = 2 where MemberID = @ReservedForMemberID;
			--	end
			--	else
			--	begin
			--		set @ReservedForMemberID = -1;
			--	end
		end
	
	if @ReturnDate > (select DueDate from Borrows where BorrowID = @BorrowID)
	begin
		set @DueDateFineAmount  = (select FineAmountPerDay * ( DATEDIFF(DAY,(select DueDate from Borrows where BorrowID = @BorrowID) ,GETDATE())) from [LibrarySettings]);
		set @ReturnFees += @DueDateFineAmount;
		INSERT INTO Fines
           (MemberID,BorrowID,FineAmount,IsPaid,Reason)
			 VALUES(@MemberID,@BorrowID,@DueDateFineAmount,0,0);
	end
	
	Update  Borrows  
                set ReturnNotes = @ReturnNote, 
                    ReturnDate = @ReturnDate, 
                    ReturnFees = @ReturnFees,                                                              
                    ReturnedByUserID = @ReturnedByUserID                           
                    where BorrowID = @BorrowID;
	set @TotalReturnFees = @ReturnFees;
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 - Over Due Date
1 - DamagedBook' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Fines', @level2type=N'COLUMN',@level2name=N'Reason'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 - Pending,
2- Available
,3-Complete,4 - Cancelled' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Reservations', @level2type=N'COLUMN',@level2name=N'ReservationStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Authors"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 148
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "People"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Authors_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Authors_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -120
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Books"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 328
               Right = 309
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BookCategories"
            Begin Extent = 
               Top = 56
               Left = 664
               Bottom = 175
               Right = 859
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Book_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Book_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[24] 4[3] 2[55] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Books"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BookCategories"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 126
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BookData_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BookData_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Borrows"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 263
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Members"
            Begin Extent = 
               Top = 7
               Left = 311
               Bottom = 170
               Right = 518
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "People"
            Begin Extent = 
               Top = 30
               Left = 647
               Bottom = 193
               Right = 841
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "BookCopies"
            Begin Extent = 
               Top = 129
               Left = 871
               Bottom = 292
               Right = 1118
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Books"
            Begin Extent = 
               Top = 9
               Left = 1074
               Bottom = 172
               Right = 1268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 13' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Borrows_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'50
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Borrows_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Borrows_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Fines"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Fines_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Fines_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Members"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 255
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "People"
            Begin Extent = 
               Top = 20
               Left = 382
               Bottom = 183
               Right = 576
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Memberships"
            Begin Extent = 
               Top = 7
               Left = 624
               Bottom = 170
               Right = 901
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MembershipClasses"
            Begin Extent = 
               Top = 7
               Left = 949
               Bottom = 170
               Right = 1255
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Members_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Members_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Publishers"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 148
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "People"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Publishers_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Publishers_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Reservations"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 260
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Reservations_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Reservations_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Users"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "People"
            Begin Extent = 
               Top = 11
               Left = 495
               Bottom = 174
               Right = 689
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Users_View'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Users_View'
GO
USE [master]
GO
ALTER DATABASE [LibraryManagementSystem] SET  READ_WRITE 
GO
