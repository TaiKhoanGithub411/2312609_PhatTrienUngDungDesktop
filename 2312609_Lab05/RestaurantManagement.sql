--create database RestaurantManagement
--go
USE [RestaurantManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[FullName] [nvarchar](1000) NOT NULL,
	[Email] [nvarchar](1000) NULL,
	[Tell] [nvarchar](200) NULL,
	[DateCreated] [smalldatetime] NULL,
 CONSTRAINT [PK_Account_1] PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_InvoiceInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Discount] [float] NULL,
	[Tax] [float] NULL,
	[Status] [bit] NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[Account] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_FoodCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[FoodCategoryID] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_FoodStuffs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](1000) NOT NULL,
	[Path] [nvarchar](3000) NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_RoleAccount] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NOT NULL,
	[Capacity] [int] NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'lgcong', N'legiacong', N'Lê Gia Công', N'conglg@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'pttnga', N'phanthithanhnga', N'Phan Thị Thanh Nga', N'ngaptt@dlu.edu.vn', NULL, CAST(N'2020-06-04T00:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'tdquy', N'thaiduyquy', N'Thái Duy Quý', N'quytd@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'ttplinh', N'tranthiphuonglinh', N'Trần Thị Phương Linh', N'linhttp@dlu.edu.vn', NULL, NULL)
SET IDENTITY_INSERT [dbo].[BillDetails] ON 

INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (1, 1, 3, 2)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (2, 1, 4, 1)
-- Chi tiết cho Hóa đơn ID = 2
INSERT INTO [dbo].[BillDetails] ([InvoiceID], [FoodID], [Quantity]) VALUES
(2, 1, 2),(2, 8, 1); 
GO
-- Chi tiết cho Hóa đơn ID = 3
INSERT INTO [dbo].[BillDetails] ([InvoiceID], [FoodID], [Quantity]) VALUES
(3, 2, 1), (3, 7, 1), (3, 9, 5); 
GO

-- Chi tiết cho Hóa đơn ID = 4
INSERT INTO [dbo].[BillDetails] ([InvoiceID], [FoodID], [Quantity]) VALUES
(4, 5, 1), -- Sò lông nướng
(4, 6, 1); -- Càng cua hấp
GO

-- Chi tiết cho Hóa đơn ID = 5
INSERT INTO [dbo].[BillDetails] ([InvoiceID], [FoodID], [Quantity]) VALUES
(5, 11, 2), -- Súp cua x2
(5, 12, 1); -- Thịt kho x1
GO

-- Chi tiết cho Hóa đơn ID = 6
INSERT INTO [dbo].[BillDetails] ([InvoiceID], [FoodID], [Quantity]) VALUES
(6, 4, 2), (6, 10, 4); 
GO

SET IDENTITY_INSERT [dbo].[BillDetails] OFF
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (1, N'Hóa đơn thanh toán', 5, 150000, 0.05, 0, 1, NULL, N'tdquy')
INSERT INTO [dbo].[Bills] ([Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account])
VALUES
(N'Hóa đơn thanh toán bàn 2', 2, 250000, 0.1, 0, 1, GETDATE(), N'lgcong'),
(N'Hóa đơn thanh toán bàn 4', 4, 180000, 0, 0, 1, GETDATE(), N'pttnga'),
(N'Hóa đơn thanh toán bàn 5', 5, 320000, 0.15, 0, 1, GETDATE(), N'tdquy'),
(N'Hóa đơn thanh toán bàn 6', 6, 95000, 0, 0, 1, GETDATE(), N'ttplinh'),
(N'Hóa đơn thanh toán bàn 8', 8, 500000, 0.2, 0, 1, GETDATE(), N'lgcong');
GO
SET IDENTITY_INSERT [dbo].[Bills] OFF;
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (1, N'Khai vị', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (2, N'Hải sản', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (3, N'Gà', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (4, N'Cơm', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (5, N'Thịt', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (6, N'Rau', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (8, N'Canh', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (9, N'Lẩu', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (10, N'Bia', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (11, N'Nước ngọt', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (12, N'Cà phê', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (13, N'Trà đá', 0)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (1, N'Rau muống xào tỏi', N'Đĩa', 6, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (2, N'Cơm chiên Dương châu', N'Đĩa nhỏ', 4, 35000, N'3 người ăn')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (3, N'Cơm chiên Dương châu', N'Đĩa lớn', 4, 40000, N'4 người ăn')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (4, N'Ếch thui rơm', N'Đĩa', 2, 70000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (5, N'Sò lông nướng mỡ hành', N'Đĩa', 2, 80000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (6, N'Càng cua hấp', N'Đĩa', 2, 100000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (7, N'Canh cải', N'Tô', 8, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (8, N'Gà nướng muối ớt', N'Con', 3, 180000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (9, N'Bia 333', N'Chai', 10, 12000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (10, N'Bia Heniken', N'Chai', 10, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (11, N'Súp cua', N'Tô', 1, 15000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (12, N'Thịt kho', N'Đĩa', 5, 25000, N'Theo thời giá')
SET IDENTITY_INSERT [dbo].[Food] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'Adminstrator', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'Kế toán', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (3, N'Nhân viên thanh toán', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (4, N'Nhân viên phục vụ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Role] OFF
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'lgcong', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'pttnga', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'ttplinh', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'lgcong', 0, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'pttnga', 0, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'ttplinh', 1, NULL)
SET IDENTITY_INSERT [dbo].[Table] ON 

INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1, N'01', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (2, N'02', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (4, N'03', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (5, N'04', 0, 6)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (6, N'05', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (8, N'06', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1002, N'07', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1003, N'08', 0, 12)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1004, N'09', 0, 12)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1005, N'10', 0, 15)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1006, N'VIP.1', 0, 20)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1007, N'VIP.2', 0, 20)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1008, N'VIP.3', 0, 10)
SET IDENTITY_INSERT [dbo].[Table] OFF
ALTER TABLE [dbo].[BillDetails] ADD  CONSTRAINT [DF_InvoiceDetails_Amount]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF_Food_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_FoodStuffs] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_FoodStuffs]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_Invoice]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Invoice_Table]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_FoodStuffs_FoodCategory] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_FoodStuffs_FoodCategory]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO


CREATE PROCEDURE InsertFood
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000)
AS
	INSERT INTO Food (Name, Unit, FoodCategoryID, Price,  Notes)
	VALUES ( @Name, @Unit, @FoodCategoryID, @Price,  @Notes)

	SELECT @ID = SCOPE_IDENTITY()

go
create procedure [UpdateFood]
	@ID int,
	@Name nvarchar(1000),
	@Unit nvarchar(100),
	@FoodCategoryID int,
	@Price int, @Notes nvarchar(3000)
as
Update [Food]
set
	[Name]=@Name, [Unit]=@Unit, [Price]=@Price, [FoodCategoryID]=@FoodCategoryID,
	[Notes]=@Notes
where ID=@ID
if @@ERROR <> 0
return 0
else 
Return 1
go

CREATE PROCEDURE InsertCategory
    @ID int OUTPUT,
    @Name nvarchar(1000),
    @Type int
AS
BEGIN
    INSERT INTO Category (Name, Type)
    VALUES (@Name, @Type)
    
    SELECT @ID = SCOPE_IDENTITY()
    
    IF @@ERROR <> 0
        RETURN 0
    ELSE
        RETURN 1
END
GO

CREATE PROCEDURE GetBillsByDateRange
    @FromDate DATETIME,
    @ToDate DATETIME
AS
BEGIN
    SELECT 
        b.ID,
        b.Name,
        t.Name AS TableName,
        b.Amount,
        ISNULL(b.Discount, 0) AS Discount,
        b.CheckoutDate,
        b.Account
    FROM Bills b
    INNER JOIN [Table] t ON b.TableID = t.ID
    WHERE b.Status = 1 
        AND b.CheckoutDate >= @FromDate 
        AND b.CheckoutDate <= @ToDate
    ORDER BY b.CheckoutDate DESC
END
GO

CREATE PROCEDURE GetRevenueSummary
    @FromDate DATETIME,
    @ToDate DATETIME,
    @TotalAmount BIGINT OUTPUT,
    @TotalDiscount BIGINT OUTPUT,
    @TotalRevenue BIGINT OUTPUT
AS
BEGIN
    SELECT 
        @TotalAmount = ISNULL(SUM(Amount), 0),
        @TotalDiscount = ISNULL(SUM(Amount * ISNULL(Discount, 0)), 0),
        @TotalRevenue = ISNULL(SUM(Amount * (1 - ISNULL(Discount, 0))), 0)
    FROM Bills
    WHERE Status = 1 
        AND CheckoutDate >= @FromDate 
        AND CheckoutDate <= @ToDate
END
GO

CREATE PROCEDURE GetBillDetails
    @InvoiceID INT
AS
BEGIN
    SELECT 
        bd.ID,
        f.Name AS FoodName,
        f.Unit,
        f.Price,
        bd.Quantity,
        (f.Price * bd.Quantity) AS TotalPrice
    FROM BillDetails bd
    INNER JOIN Food f ON bd.FoodID = f.ID
    WHERE bd.InvoiceID = @InvoiceID
END
GO

CREATE PROCEDURE GetAllAccounts
AS
BEGIN
    SELECT 
        AccountName,
        [Password],
        FullName,
        Email,
        Tell,
        DateCreated
    FROM Account
    ORDER BY AccountName
END
GO

CREATE PROCEDURE InsertAccount
    @AccountName NVARCHAR(100),
    @Password NVARCHAR(200),
    @FullName NVARCHAR(1000),
    @Email NVARCHAR(1000),
    @Tell NVARCHAR(200),
    @DateCreated SMALLDATETIME
AS
BEGIN
    BEGIN TRY
        INSERT INTO Account (AccountName, [Password], FullName, Email, Tell, DateCreated)
        VALUES (@AccountName, @Password, @FullName, @Email, @Tell, @DateCreated)
        RETURN 1
    END TRY
    BEGIN CATCH
        RETURN 0
    END CATCH
END
GO

CREATE PROCEDURE UpdateAccount
    @AccountName NVARCHAR(100),
    @FullName NVARCHAR(1000),
    @Email NVARCHAR(1000),
    @Tell NVARCHAR(200),
	@Password NVARCHAR(200)
AS
BEGIN
    BEGIN TRY
        UPDATE Account
        SET FullName = @FullName,
            Email = @Email,
            Tell = @Tell,
			[Password] = @Password
        WHERE AccountName = @AccountName
        RETURN 1
    END TRY
    BEGIN CATCH
        RETURN 0
    END CATCH
END

CREATE PROCEDURE ResetPassword
    @AccountName NVARCHAR(100),
    @NewPassword NVARCHAR(200)
AS
BEGIN
    BEGIN TRY
        UPDATE Account
        SET Password = @NewPassword
        WHERE AccountName = @AccountName
        RETURN 1
    END TRY
    BEGIN CATCH
        RETURN 0
    END CATCH
END
GO

CREATE PROCEDURE GetAllRoles
AS
BEGIN
    SELECT 
        ID,
        RoleName,
        Path,
        Notes
    FROM Role
    ORDER BY ID
END
GO

CREATE PROCEDURE GetRolesByAccount
    @AccountName NVARCHAR(100)
AS
BEGIN
    SELECT 
        r.ID,
        r.RoleName,
        r.Path,
        r.Notes,
        CASE WHEN ra.AccountName IS NOT NULL AND ra.Actived = 1 
             THEN 1 ELSE 0 END AS IsAssigned
    FROM Role r
    LEFT JOIN RoleAccount ra ON r.ID = ra.RoleID 
        AND ra.AccountName = @AccountName
    ORDER BY r.ID
END
GO

CREATE PROCEDURE InsertRole
    @RoleName NVARCHAR(1000),
    @Path NVARCHAR(3000),
    @Notes NVARCHAR(3000),
    @NewRoleID INT OUTPUT
AS
BEGIN
    BEGIN TRY
        INSERT INTO Role (RoleName, Path, Notes)
        VALUES (@RoleName, @Path, @Notes)
        
        SET @NewRoleID = SCOPE_IDENTITY()
        RETURN 1
    END TRY
    BEGIN CATCH
        RETURN 0
    END CATCH
END
GO

CREATE PROCEDURE UpdateAccountRoles
    @AccountName NVARCHAR(100),
    @RoleID INT,
    @Actived BIT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM RoleAccount 
                   WHERE RoleID = @RoleID AND AccountName = @AccountName)
        BEGIN
            UPDATE RoleAccount
            SET Actived = @Actived
            WHERE RoleID = @RoleID AND AccountName = @AccountName
        END
        ELSE
        BEGIN
            INSERT INTO RoleAccount (RoleID, AccountName, Actived, Notes)
            VALUES (@RoleID, @AccountName, @Actived, NULL)
        END
        RETURN 1
    END TRY
    BEGIN CATCH
        RETURN 0
    END CATCH
END
GO



CREATE PROCEDURE GetBillsByAccount
    @AccountName NVARCHAR(100)
AS
BEGIN
    SELECT 
        ID,
        Name,
        TableID,
        Amount,
        Discount,
        CheckoutDate
    FROM Bills
    WHERE Account = @AccountName 
        AND Status = 1
    ORDER BY CheckoutDate DESC
END
GO

CREATE PROCEDURE GetBillDetailsWithFood
    @InvoiceID INT
AS
BEGIN
    SELECT 
        bd.ID,
        f.Name AS FoodName,
        f.Unit,
        f.Price,
        bd.Quantity,
        (f.Price * bd.Quantity) AS TotalPrice
    FROM BillDetails bd
    INNER JOIN Food f ON bd.FoodID = f.ID
    WHERE bd.InvoiceID = @InvoiceID
END
GO

CREATE PROCEDURE GetAccountBillStatistics
    @AccountName NVARCHAR(100),
    @TotalBills INT OUTPUT,
    @TotalAmount BIGINT OUTPUT
AS
BEGIN
    SELECT 
        @TotalBills = COUNT(*),
        @TotalAmount = ISNULL(SUM(Amount * (1 - ISNULL(Discount, 0))), 0)
    FROM Bills
    WHERE Account = @AccountName 
        AND Status = 1
END
GO

