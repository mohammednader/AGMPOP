 ---- Scaffold-DbContext "Server=.;Database=AGMPOP;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/Domain -force -project AGMPOP.BL


USE [AGMPOP]
GO
/****** Object:  Table [dbo].[AppUser]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUser](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](256) NULL,
	[PasswordHash] [nvarchar](256) NULL,
	[FullName] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[IsActive] [bit] NULL,
	[IsSysAdmin] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreationDate] [datetime] NULL,
	[LastModifiedBy] [int] NULL,
	[LastModificationDate] [datetime] NULL,
	[IsChangedPassword] [bit] NULL,
	[IsEmailConfirmed] [bit] NULL,
	[IsPhoneNumberConfirmed] [bit] NULL,
	[IsTwoFactorEnabled] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[JobTitleID] [int] NULL,
 CONSTRAINT [PK_AppUser] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cycle_Product]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cycle_Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[CycleId] [int] NULL,
	[Qunt] [int] NULL,
	[RemainQunt] [int] NULL,
 CONSTRAINT [PK_dbo.Cycle_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cycle_User]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cycle_User](
	[UserId] [int] NOT NULL,
	[CycleId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Cycle_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[CycleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cycles]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cycles](
	[CycleId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Type] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[ReconciliationDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Inactive] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Cycles] PRIMARY KEY CLUSTERED 
(
	[CycleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobTitle]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobTitle](
	[JobTitleId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_dbo.JobTitles] PRIMARY KEY CLUSTERED 
(
	[JobTitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LNK_RolePermission]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LNK_RolePermission](
	[RoleID] [int] NOT NULL,
	[PermissionID] [int] NOT NULL,
 CONSTRAINT [PK_LNK_RolePermission] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LNK_UserRole]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LNK_UserRole](
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_LNK_UserRole] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[ParentID] [int] NULL,
	[Order] [int] NULL,
	[PermissionType] [int] NULL,
	[PermissionURL] [nvarchar](max) NULL,
	[StyleClass] [nvarchar](100) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[TypeId] [int] NULL,
	[Image] [nvarchar](max) NULL,
	[ImageSize] [nvarchar](max) NULL,
	[Inactive] [bit] NOT NULL,
	[DepartmentID] [int] NULL,
	[InventoryQnty] [decimal](10, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[Modified] [datetime] NULL,
 CONSTRAINT [PK_dbo.Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 30/01/2020 11:10:12 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[RequestId] [int] IDENTITY(1,1) NOT NULL,
	[CycleId] [int] NULL,
	[Status] [bit] NOT NULL,
	[CreatedById] [int] NULL,
	[CreateDate] [datetime] NULL,
	[ModfiedById] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Request] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request_Detail]    Script Date: 30/01/2020 11:10:13 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request_Detail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestId] [int] NULL,
	[ProductId] [int] NULL,
	[Request_Amount] [int] NULL,
 CONSTRAINT [PK_dbo.Request_Detail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 30/01/2020 11:10:13 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](500) NULL,
	[IsSysRole] [bit] NULL,
	[DefaultPageID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreationDate] [datetime] NULL,
	[LastModifiedBy] [int] NULL,
	[LastModificationDate] [datetime] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Territories]    Script Date: 30/01/2020 11:10:13 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Territories](
	[TerritoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NULL,
	[Inactive] [bit] NULL,
	[ParentId] [int] NULL,
 CONSTRAINT [PK_dbo.Territories] PRIMARY KEY CLUSTERED 
(
	[TerritoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 30/01/2020 11:10:13 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[TransactionId] [bigint] IDENTITY(1,1) NOT NULL,
	[CycleId] [int] NULL,
	[FromUserId] [int] NULL,
	[ToUserId] [int] NULL,
	[FromTerritoryId] [int] NULL,
	[ToTerritoryId] [int] NULL,
	[TransType] [int] NULL,
	[Status] [int] NULL,
	[CreatedById] [int] NULL,
	[CreateDate] [datetime] NULL,
	[ModfiedById] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ConfirmDate] [datetime] NULL,
 CONSTRAINT [PK_dbo.Transaction] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction_Detail]    Script Date: 30/01/2020 11:10:13 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction_Detail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransactionId] [bigint] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Trans_Amount] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Transaction_Detail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Territory]    Script Date: 30/01/2020 11:10:13 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Territory](
	[UserId] [int] NOT NULL,
	[TerritoryId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.User_Territory] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[TerritoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[JobTitle] ADD  CONSTRAINT [DF_JobTitle_Type]  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Inactive]  DEFAULT ((0)) FOR [Inactive]
GO
ALTER TABLE [dbo].[Request] ADD  CONSTRAINT [DF_Request_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[AppUser]  WITH CHECK ADD  CONSTRAINT [FK_User_JobTitle] FOREIGN KEY([JobTitleID])
REFERENCES [dbo].[JobTitle] ([JobTitleId])
GO
ALTER TABLE [dbo].[AppUser] CHECK CONSTRAINT [FK_User_JobTitle]
GO
ALTER TABLE [dbo].[Cycle_Product]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cycle_Product_dbo.Cycles_CycleId] FOREIGN KEY([CycleId])
REFERENCES [dbo].[Cycles] ([CycleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cycle_Product] CHECK CONSTRAINT [FK_dbo.Cycle_Product_dbo.Cycles_CycleId]
GO
ALTER TABLE [dbo].[Cycle_Product]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cycle_Product_dbo.Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cycle_Product] CHECK CONSTRAINT [FK_dbo.Cycle_Product_dbo.Product_ProductId]
GO
ALTER TABLE [dbo].[Cycle_User]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cycle_User_dbo.Cycles_CycleId] FOREIGN KEY([CycleId])
REFERENCES [dbo].[Cycles] ([CycleId])
GO
ALTER TABLE [dbo].[Cycle_User] CHECK CONSTRAINT [FK_dbo.Cycle_User_dbo.Cycles_CycleId]
GO
ALTER TABLE [dbo].[Cycle_User]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cycle_User_dbo.USERS_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([ID])
GO
ALTER TABLE [dbo].[Cycle_User] CHECK CONSTRAINT [FK_dbo.Cycle_User_dbo.USERS_UserId]
GO
ALTER TABLE [dbo].[LNK_RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_LNK_RolePermission_Permission] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[Permission] ([ID])
GO
ALTER TABLE [dbo].[LNK_RolePermission] CHECK CONSTRAINT [FK_LNK_RolePermission_Permission]
GO
ALTER TABLE [dbo].[LNK_RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_LNK_RolePermission_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[LNK_RolePermission] CHECK CONSTRAINT [FK_LNK_RolePermission_Role]
GO
ALTER TABLE [dbo].[LNK_UserRole]  WITH CHECK ADD  CONSTRAINT [FK_LNK_UserRole_Role] FOREIGN KEY([UserID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[LNK_UserRole] CHECK CONSTRAINT [FK_LNK_UserRole_Role]
GO
ALTER TABLE [dbo].[LNK_UserRole]  WITH CHECK ADD  CONSTRAINT [FK_LNK_UserRole_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[AppUser] ([ID])
GO
ALTER TABLE [dbo].[LNK_UserRole] CHECK CONSTRAINT [FK_LNK_UserRole_User]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Department]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Request_dbo.Cycles_CycleId] FOREIGN KEY([CycleId])
REFERENCES [dbo].[Cycles] ([CycleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_dbo.Request_dbo.Cycles_CycleId]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_CreatedById] FOREIGN KEY([CreatedById])
REFERENCES [dbo].[AppUser] ([ID])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_CreatedById]
GO
ALTER TABLE [dbo].[Request_Detail]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Request_Detail_dbo.Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[Request_Detail] CHECK CONSTRAINT [FK_dbo.Request_Detail_dbo.Product_ProductId]
GO
ALTER TABLE [dbo].[Request_Detail]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Request_Detail_dbo.Request_RequestId] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([RequestId])
GO
ALTER TABLE [dbo].[Request_Detail] CHECK CONSTRAINT [FK_dbo.Request_Detail_dbo.Request_RequestId]
GO
ALTER TABLE [dbo].[Role]  WITH CHECK ADD  CONSTRAINT [FK_Role_DefaultPage] FOREIGN KEY([DefaultPageID])
REFERENCES [dbo].[Permission] ([ID])
GO
ALTER TABLE [dbo].[Role] CHECK CONSTRAINT [FK_Role_DefaultPage]
GO
ALTER TABLE [dbo].[Territories]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Territories_dbo.Territories_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[Territories] ([TerritoryId])
GO
ALTER TABLE [dbo].[Territories] CHECK CONSTRAINT [FK_dbo.Territories_dbo.Territories_ParentId]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transaction_dbo.Cycles_CycleId] FOREIGN KEY([CycleId])
REFERENCES [dbo].[Cycles] ([CycleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_dbo.Transaction_dbo.Cycles_CycleId]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transaction_dbo.USERS_CreatedById] FOREIGN KEY([CreatedById])
REFERENCES [dbo].[AppUser] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_dbo.Transaction_dbo.USERS_CreatedById]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transaction_dbo.USERS_FromUserId] FOREIGN KEY([FromUserId])
REFERENCES [dbo].[AppUser] ([ID])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_dbo.Transaction_dbo.USERS_FromUserId]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transaction_dbo.USERS_ToUserId] FOREIGN KEY([ToUserId])
REFERENCES [dbo].[AppUser] ([ID])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_dbo.Transaction_dbo.USERS_ToUserId]
GO
ALTER TABLE [dbo].[Transaction_Detail]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transaction_Detail_dbo.Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[Transaction_Detail] CHECK CONSTRAINT [FK_dbo.Transaction_Detail_dbo.Product_ProductId]
GO
ALTER TABLE [dbo].[Transaction_Detail]  WITH CHECK ADD  CONSTRAINT [FK_TransactionDetails_TransactionId] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transaction] ([TransactionId])
GO
ALTER TABLE [dbo].[Transaction_Detail] CHECK CONSTRAINT [FK_TransactionDetails_TransactionId]
GO
ALTER TABLE [dbo].[User_Territory]  WITH CHECK ADD  CONSTRAINT [FK_dbo.User_Territory_dbo.Territories_TerritoryId] FOREIGN KEY([TerritoryId])
REFERENCES [dbo].[Territories] ([TerritoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[User_Territory] CHECK CONSTRAINT [FK_dbo.User_Territory_dbo.Territories_TerritoryId]
GO
ALTER TABLE [dbo].[User_Territory]  WITH CHECK ADD  CONSTRAINT [FK_User_Territory] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([ID])
GO
ALTER TABLE [dbo].[User_Territory] CHECK CONSTRAINT [FK_User_Territory]
GO
USE [master]
GO
ALTER DATABASE [AGMPOP] SET  READ_WRITE 
GO


----end scaffold all script  -- salah 30/1/2020 

-- new scripts with alter here


----start scaffold  add request id to trans-- salah 2/2/2020 

 USE AGMPOP

----start scaffold  add request id to trans-- salah 2/2/2020 

  alter table  [AGMPOP].[dbo].[Transaction]
  add [RequestId] int  null 
 
 ----start scaffold  add [Approved_Amount] request detalis-- salah 2/2/2020 

   alter table  [AGMPOP].[dbo].[Request_Detail]
  add [Approved_Amount] int  null 


  ----start scaffold  add [[LogTransaction]] -- nader 2/2/2020 
CREATE TABLE [dbo].InventoryLog (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[OldQnty][int] Null,
	[NewQnty][int] Null,
	[Quantity] [int] Null,
	[TransactionType][int] Null,
	[UserId] [int] Null,
	[CreatedDate][datetime] Null,
	[ActionType] [int] Null,
	[TransactionId][bigint] Null
 CONSTRAINT [PK_dbo.LogTransaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO

ALTER TABLE [dbo].InventoryLog  WITH CHECK ADD  CONSTRAINT [FK_InventoryLog_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO

ALTER TABLE [dbo].InventoryLog  WITH CHECK ADD  CONSTRAINT [FK_InventoryLog_transaction] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transaction] ([TransactionId])
GO
----end 

-------- yasser 4/2/2020 
 drop table [LogTransaction]

 -- add cycle  Territory table 
CREATE TABLE [dbo].[Cycle_Territory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TerritoryId] [int] NOT NULL,
	[CycleId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Cycle_Territory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Cycle_Territory]  WITH CHECK ADD  CONSTRAINT [FK_Cycle_Territory_CycleId] FOREIGN KEY([CycleId])
REFERENCES [dbo].[Cycles] ([CycleId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Cycle_Territory] CHECK CONSTRAINT [FK_Cycle_Territory_CycleId]
GO

ALTER TABLE [dbo].[Cycle_Territory]  WITH CHECK ADD  CONSTRAINT [FK_Cycle_Territory_TerritoryId] FOREIGN KEY([TerritoryId])
REFERENCES [dbo].[Territories] ([TerritoryId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Cycle_Territory] CHECK CONSTRAINT [FK_Cycle_Territory_TerritoryId]
GO

EXEC sp_RENAME 'Cycles.Inactive' , 'IsActive', 'COLUMN'


--- end yasser
----end 

/*** Omar Allam : Fix User Role relation 2 / 2 / 2020 */
ALTER TABLE [LNK_UserRole]
DROP CONSTRAINT [FK_LNK_UserRole_Role];

GO

ALTER TABLE [LNK_UserRole]
ADD CONSTRAINT [FK_LNK_UserRole_Role]
FOREIGN KEY ([RoleID])
REFERENCES [dbo].[Role]([ID])

GO

---- END OMAR ALLAM

/**** Rename Inactive in products to Active * Omar Allam 6 / 6 / 2020 */
EXEC sp_RENAME 'Product.Inactive' , 'IsActive', 'COLUMN'

/*** Add department id in cycles and users *** Omar Allam 9 / 2 / 2020 */
ALTER TABLE [Cycles]
ADD [DepartmentID] INT NULL;

GO 

ALTER TABLE [Cycles]
ADD CONSTRAINT [FK_Cycle_Department]
FOREIGN KEY ([DepartmentID])
REFERENCES [dbo].[Department]([ID]);

---

ALTER TABLE [AppUser]
ADD [DepartmentID] INT NULL;

GO 

ALTER TABLE [AppUser]
ADD CONSTRAINT [FK_User_Department]
FOREIGN KEY ([DepartmentID])
REFERENCES [dbo].[Department]([ID])


-- END OMAR ALLAM

/*** drop foreign key for transaction created by *** Omar Allam 9 / 2 / 2020 */
ALTER TABLE [Transaction]
DROP CONSTRAINT [FK_dbo.Transaction_dbo.USERS_CreatedById]


/** add [Notifications] Table  Mohammed Salah 16 / 2 / 2020 */
 
 
USE [AGMPOP]
GO

/****** Object:  Table [dbo].[Notifications]    Script Date: 16/02/2020 03:40:14 م ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Notifications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransactionId] [bigint] NULL,
	[ToUserId] [int] NULL,
	[notificationtype] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[SeenDate] [datetime] NULL,
	[IsSeen] [bit] NULL,
 CONSTRAINT [PK_dbo.Notifications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Notifications_dbo.AppUser_ToUserId] FOREIGN KEY([ToUserId])
REFERENCES [dbo].[AppUser] ([ID])
GO

ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_dbo.Notifications_dbo.AppUser_ToUserId]
GO

ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Notifications_dbo.Transaction_TransactionId] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transaction] ([TransactionId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_dbo.Notifications_dbo.Transaction_TransactionId]
GO



/*** Omar Allam: drop username - 19/2/2020 ***/
ALTER TABLE [AppUser]
DROP COLUMN [Username]

GO
--- End Omar Allam







/*** Omar Allam: user clearance table - 23/2/2020 ***/
CREATE TABLE [UserClearance] (
	[UserID] INT NOT NULL,
	[CycleID] INT NOT NULL,
	[ProductID] INT NOT NULL,
	[ClearanceQuantity] decimal NULL,

	CONSTRAINT [PK_UserClearance]
	PRIMARY KEY ([UserID], [CycleID], [ProductID])
);

GO

ALTER TABLE [UserClearance]
ADD [TotalQuantity] decimal NULL;
--- End Omar Allam




/*** Omar Allam: V_CycleProductQuantity - 23/2/2020 ***/
GO
CREATE VIEW [dbo].[V_CycleProductQuantity]
WITH SCHEMABINDING
AS
Select
	cu.UserId
	,c.[CycleId]
    ,c.[Name] as CycleName
    ,c.[Type] as CycleType
    ,c.[Status] as CycleStatus
    ,c.[StartDate] as CycleStartDate
    ,c.[ReconciliationDate] as CycleReconciliationDate
    ,c.[EndDate] as CycleEndDate
    ,c.[IsActive] as CycleIsActive
    ,c.[DepartmentID]
	,j.JobTitleID
    ,j.Name as JobTitleName
	,p.ProductId
	,p.Name as ProductName
	,p.Code as ProductCode
	,p.Image as ProductImage
	,p.TypeId as ProductTypeId
	,(case when LOWER(j.Name) = 'bbx'
		   then cp.Qunt
		   else uc.TotalQuantity
		   end) as ProductTotalQuantity
	
	,(case when LOWER(j.Name) = 'bbx'
		   then cp.RemainQunt
		   else uc.ClearanceQuantity
		   end) as ProductAvailableQuantity
from
[dbo].[Cycles] c
inner join [dbo].[Cycle_User] cu on c.CycleId = cu.CycleId
inner join [dbo].[AppUser] u on cu.UserId = u.ID
inner join [dbo].[JobTitle] j on u.JobTitleID = j.JobTitleId
inner join [dbo].[Cycle_Product] cp on cp.CycleId = c.CycleId
inner join [dbo].[Product] p on cp.ProductId = p.ProductId
left join  [dbo].[UserClearance] uc on uc.ProductID = cp.ProductId and uc.UserID = cu.UserId
GO


----- add relattion between clearance & product tables 

ALTER TABLE [dbo].UserClearance  WITH CHECK ADD  CONSTRAINT [FK_UserClearance_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].Product (ProductId)
GO
--- End Omar Allam

/**nader  : Alter table Department Add IsActive column   **/
Alter Table Department 
Add  IsActive bit NULL
--End nader

-- yasser  24 -2 -2020
-- chnage inveentory log amount type 
   
 ALTER TABLE InventoryLog
ALTER COLUMN OldQnty decimal(10, 2);

   
 ALTER TABLE InventoryLog
ALTER COLUMN NewQnty decimal(10, 2);

   
 ALTER TABLE InventoryLog
ALTER COLUMN Quantity decimal(10, 2);

-- end yasser 

/* Data Audit table : Omar Allam 3/3/2020 */

CREATE TABLE [DataAudit] (
	[ID] int not null IDENTITY(1,1),
	[AuditID] int null,
	[SessionID] nvarchar(50) null,
	[UserID] int null,
	[TableName] nvarchar(100) null,
	[ObjectKey] nvarchar(100) null,
	[ActionTypeID] int null,
	[OldData] nvarchar(max) null,
	[NewData] nvarchar(max) null,
	[Date] datetime null,

	CONSTRAINT [PK_DataAudit]
	PRIMARY KEY ([ID])
);
-- END OMAR ALLAM



ALTER TABLE [dbo].[DataAudit]  WITH CHECK ADD  CONSTRAINT [FK_DataAudit_UserId] FOREIGN KEY([UserID])
REFERENCES [dbo].[AppUser] ([ID])
GO

/**** Rename Inactive in Territories to Active * mohammed salah  11 / 3/ 2020 */
EXEC sp_RENAME 'Territories.Inactive' , 'IsActive', 'COLUMN'