IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[AppBranch] (
        [Id] int NOT NULL,
        [Code] nvarchar(max) NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        [IsArchived] bit NOT NULL,
        [ParentBranchFk] int NULL,
        CONSTRAINT [PK_AppBranch] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AppBranch_AppBranch_ParentBranchFk] FOREIGN KEY ([ParentBranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ApplicationSettingsCategory] (
        [Id] int NOT NULL IDENTITY,
        [ParentCategoryFk] int NULL,
        [CategoryTitle] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_ApplicationSettingsCategory] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[StatementMeliN] (
        [Id] int NOT NULL IDENTITY,
        [Transaction_Date] datetime2 NULL,
        [Transaction_Time] datetime2 NULL,
        [Trace_No] nvarchar(255) NULL,
        [Tran_Channel] nvarchar(255) NULL,
        [Description2] nvarchar(255) NULL,
        [Deposit_Amount] nvarchar(255) NULL,
        [Description] nvarchar(max) NULL,
        [ItemModifiedBy] int NULL,
        [ItemModifiedWhen] datetime2 NULL,
        [ItemGUID] uniqueidentifier NOT NULL,
        [Verification_Status] int NULL,
        CONSTRAINT [PK_StatementMeliN] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[StatementParsianM] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        [Transaction_Date] datetime2 NULL,
        [Transaction_Time] datetime2 NULL,
        [Deposit_Amount] int NULL,
        [Withdrawal_Amount] nvarchar(255) NULL,
        [Reference_Number] nvarchar(255) NULL,
        [Agent_Branch] nvarchar(255) NULL,
        [Customer_Description] nvarchar(255) NULL,
        CONSTRAINT [PK_StatementParsianM] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[Widgets] (
        [Id] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NOT NULL,
        [Title] nvarchar(max) NOT NULL,
        [TitleClass] nvarchar(max) NULL,
        [Height] nvarchar(max) NULL,
        [IconName] nvarchar(max) NULL,
        [Icon] nvarchar(max) NULL,
        [IconColor] int NOT NULL,
        [IconSize] int NULL,
        [BreakPoints] nvarchar(max) NULL,
        [IsInline] bit NULL,
        [AllowRemove] bit NOT NULL,
        [AllowHidden] bit NOT NULL,
        [BelongToRoles] nvarchar(max) NULL,
        CONSTRAINT [PK_Widgets] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[AdvanceRegistrations] (
        [Id] int NOT NULL IDENTITY,
        [Allow] bit NULL,
        [Title] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [UserName] nvarchar(max) NOT NULL,
        [DateTime] datetime2 NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_AdvanceRegistrations] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AdvanceRegistrations_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[Permissions] (
        [Id] int NOT NULL IDENTITY,
        [Allow] bit NOT NULL,
        [Title] nvarchar(max) NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_Permissions] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Permissions_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[Roles] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Roles_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_AccountingCode] (
        [Id] int NOT NULL IDENTITY,
        [AccountingCodeGuid] uniqueidentifier NOT NULL,
        [AccountingCodeLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [AccountingCodeParentID] int NULL,
        [Title] nvarchar(512) NULL,
        [AccountType] int NULL,
        [Describtion] nvarchar(max) NULL,
        [Code] nvarchar(20) NULL,
        [SubjectRecFk] int NULL,
        [LastSQ] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_AccountingCode] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_AccountingCode_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_AccountingTransaction] (
        [Id] int NOT NULL IDENTITY,
        [AccountingTransactionGuid] uniqueidentifier NOT NULL,
        [AccountingTransactionLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [AccountingCodeFk] int NULL,
        [Code] nvarchar(20) NULL,
        [SubjectRecFk] int NULL,
        [Debit] int NULL,
        [Credit] int NULL,
        [Balance] int NULL,
        [TermId] int NULL,
        [TransactionDate] datetime2 NULL,
        [Description] nvarchar(max) NULL,
        [ShortTxKey] nvarchar(512) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_AccountingTransaction] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_AccountingTransaction_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_BookClass] (
        [Id] int NOT NULL IDENTITY,
        [BookClassGuid] uniqueidentifier NOT NULL,
        [BookClassLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [BookName] nvarchar(200) NULL,
        [BookPic] nvarchar(1024) NULL,
        [BookDes] nvarchar(200) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_BookClass] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_BookClass_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_ClassRoom] (
        [Id] int NOT NULL IDENTITY,
        [ClassRoomGuid] uniqueidentifier NOT NULL,
        [ClassRoomLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [ClassRoomName] nvarchar(200) NOT NULL DEFAULT ((N'')),
        [Capacity] int NULL,
        [MinCapacity] int NULL,
        [MaxCapacity] int NULL,
        [Describtion] nvarchar(max) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_ClassRoom] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_ClassRoom_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_Employee] (
        [Id] int NOT NULL IDENTITY,
        [EmployeeGuid] uniqueidentifier NOT NULL,
        [EmployeeLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [Title] nvarchar(200) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_Employee] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_Employee_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_FileAttachment] (
        [Id] int NOT NULL IDENTITY,
        [Guid] uniqueidentifier NOT NULL,
        [LastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [FileTitle] nvarchar(512) NULL,
        [FileContent] varbinary(max) NULL,
        [Folder] nvarchar(512) NULL,
        [DataUrl] nvarchar(max) NULL,
        [FileName] nvarchar(512) NULL,
        [ContentType] nvarchar(max) NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_FileAttachment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_FileAttachment_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_Finance_Flat] (
        [Id] int NOT NULL IDENTITY,
        [Finance_FlatGuid] uniqueidentifier NOT NULL,
        [Finance_FlatLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [StudentID] nvarchar(200) NULL,
        [StudentName] nvarchar(512) NULL,
        [StudentFamily] nvarchar(512) NULL,
        [CreditCardPostFixNo] nvarchar(16) NULL,
        [PaymentDateTime] datetime2 NULL,
        [PaymentForTermID] int NULL,
        [PaymentForYearID] int NULL,
        [PaymentTypeID] int NOT NULL DEFAULT (((1))),
        [PaymentCauseID] int NOT NULL DEFAULT (((1))),
        [PaymentAmount] bigint NOT NULL,
        [Verification_Status] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_Finance_Flat] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_Finance_Flat_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_Interval] (
        [Id] int NOT NULL IDENTITY,
        [IntervalGuid] uniqueidentifier NOT NULL,
        [IntervalLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [Title] nvarchar(200) NULL,
        [TimeInterval] nvarchar(200) NULL,
        [TermId] int NOT NULL DEFAULT (((21))),
        [StartTime] time NULL,
        [EndTime] time NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_Interval] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_Interval_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_LessonPlanSectionType] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_LessonPlanSectionType] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlanSectionType_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_LevelClass] (
        [Id] int NOT NULL IDENTITY,
        [LevelClassGuid] uniqueidentifier NOT NULL,
        [LevelClassLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [LevelName] nvarchar(200) NOT NULL DEFAULT ((N'')),
        [LevelDes] nvarchar(512) NULL,
        [Grouping] nvarchar(max) NULL,
        [BookID] int NOT NULL,
        [NextLevelFK] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_LevelClass] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LevelClass_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LevelClass_ShokouhPardis_LevelClass_NextLevelFK] FOREIGN KEY ([NextLevelFK]) REFERENCES [dbo].[ShokouhPardis_LevelClass] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_schedule] (
        [Id] int NOT NULL IDENTITY,
        [TermFk] int NOT NULL,
        [ScheduleGuid] uniqueidentifier NOT NULL,
        [ScheduleLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [Title] nvarchar(200) NOT NULL DEFAULT ((N'')),
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_schedule] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_schedule_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_SessionActivity] (
        [Id] int NOT NULL IDENTITY,
        [ActivityTitle] nvarchar(max) NOT NULL,
        [Levels] nvarchar(max) NULL,
        [LevelGroups] nvarchar(max) NULL,
        [SessionNo] int NULL,
        [Description] nvarchar(max) NULL,
        [Color] int NULL,
        [IconName] nvarchar(max) NULL,
        [Icon] nvarchar(max) NULL,
        [IconColor] int NULL,
        [IconSize] int NULL,
        [ValueType] nvarchar(max) NOT NULL,
        [ValueOptionsCanMultiple] bit NULL,
        [ValueControl] nvarchar(max) NULL,
        [SessionActivityGuid] uniqueidentifier NOT NULL,
        [SessionActivityLastModified] datetime2 NOT NULL,
        [IsDefault] bit NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_SessionActivity] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_SessionActivity_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_StudentClass] (
        [Id] int NOT NULL IDENTITY,
        [StudentClassGuid] uniqueidentifier NOT NULL,
        [StudentClassLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [StudentName] nvarchar(512) NOT NULL DEFAULT ((N'')),
        [StudentFamily] nvarchar(512) NOT NULL DEFAULT ((N'')),
        [StudentBirthDay] datetime2 NULL,
        [StudentFatherName] nvarchar(512) NULL,
        [StudentMotherFullName] nvarchar(512) NULL,
        [StudentIDNo] nvarchar(10) NOT NULL DEFAULT ((N'0')),
        [FatherJob] nvarchar(200) NULL,
        [MotherJob] nvarchar(200) NULL,
        [StudentAddress] nvarchar(1024) NULL,
        [StudentFrom] nvarchar(200) NULL,
        [StudentSHNo] int NULL,
        [StudentPhone] nvarchar(200) NULL,
        [FatherPhone] nvarchar(200) NULL,
        [MotherPhone] nvarchar(200) NULL,
        [HomePhone] nvarchar(200) NULL,
        [WhatsAppPhone] nvarchar(200) NULL,
        [Gender] bit NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_StudentClass] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentClass_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_StudentClass_Dto] (
        [Id] int NOT NULL IDENTITY,
        [StudentIDNo] bigint NOT NULL,
        [StudentName] nvarchar(512) NOT NULL DEFAULT ((N'')),
        [StudentFamily] nvarchar(512) NOT NULL DEFAULT ((N'')),
        [StudentSHNo] int NULL,
        [StudentBirthDay] datetime2 NULL,
        [StudentFatherName] nvarchar(512) NULL,
        [FatherJob] nvarchar(200) NULL,
        [StudentMotherFullName] nvarchar(512) NULL,
        [MotherJob] nvarchar(200) NULL,
        [StudentAddress] nvarchar(1024) NULL,
        [StudentFrom] nvarchar(200) NULL,
        [StudentClassGuid] uniqueidentifier NOT NULL,
        [StudentClassLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_StudentClass_Dto] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentClass_Dto_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_StudentClass_OnlineForm] (
        [Id] int NOT NULL IDENTITY,
        [StudentIDNo] nvarchar(10) NOT NULL DEFAULT ((N'0')),
        [StudentName] nvarchar(512) NOT NULL DEFAULT ((N'')),
        [StudentFamily] nvarchar(512) NOT NULL DEFAULT ((N'')),
        [StudentSHNo] int NULL,
        [StudentBirthDay] datetime2 NULL,
        [StudentFatherName] nvarchar(512) NULL,
        [FatherJob] nvarchar(200) NULL,
        [StudentMotherFullName] nvarchar(512) NULL,
        [MotherJob] nvarchar(200) NULL,
        [StudentAddress] nvarchar(1024) NULL,
        [StudentFrom] nvarchar(200) NULL,
        [StudentPhone] nvarchar(200) NULL,
        [FatherPhone] nvarchar(200) NULL,
        [MotherPhone] nvarchar(200) NULL,
        [HomePhone] nvarchar(200) NULL,
        [WhatsAppPhone] nvarchar(200) NULL,
        [StudentClassGuid] uniqueidentifier NOT NULL,
        [StudentClassLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [SchholStart] datetime2 NULL,
        [SchoolEnd] datetime2 NULL,
        [UniqueKey] uniqueidentifier NULL,
        [ProfilePicture] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [RecordVersion] int NULL,
        [IsGirl] bit NOT NULL DEFAULT (((1))),
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_StudentClass_OnlineForm] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentClass_OnlineForm_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TeacherClass] (
        [Id] int NOT NULL IDENTITY,
        [TeacherNationalId] nvarchar(max) NULL,
        [TeacherClassGuid] uniqueidentifier NOT NULL,
        [TeacherClassLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [TeacherName] nvarchar(200) NOT NULL DEFAULT ((N'')),
        [TeacherFamily] nvarchar(200) NOT NULL DEFAULT ((N'')),
        [TeacherSex] bit NOT NULL DEFAULT (((1))),
        [TeacherBirthDay] datetime2 NULL,
        [TeacherPic] nvarchar(1024) NULL,
        [TermId] int NOT NULL DEFAULT (((20))),
        [UserId] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TeacherClass] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherClass_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TeacherLevels] (
        [Id] int NOT NULL IDENTITY,
        [TeacherLevelsGuid] uniqueidentifier NOT NULL,
        [TeacherLevelsLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [TeacherID] int NOT NULL,
        [LevelID] int NOT NULL,
        [ProficiencyLevel] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TeacherLevels] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherLevels_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_WeekDay] (
        [Id] int NOT NULL IDENTITY,
        [WeekDayGuid] uniqueidentifier NOT NULL,
        [WeekDayLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [Title] nvarchar(200) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_WeekDay] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_WeekDay_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_YearClass] (
        [Id] int NOT NULL IDENTITY,
        [YearClassGuid] uniqueidentifier NOT NULL,
        [YearClassLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [YearName] nvarchar(200) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_YearClass] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_YearClass_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[Users] (
        [Id] int NOT NULL IDENTITY,
        [Gender] bit NULL,
        [UserName] nvarchar(max) NOT NULL,
        [Password] nvarchar(max) NOT NULL,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [IsActive] bit NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Users_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ApplicationSettings] (
        [Id] int NOT NULL IDENTITY,
        [SettingCategoryFk] int NOT NULL,
        [SettingKey] nvarchar(max) NOT NULL,
        [SettingValue] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_ApplicationSettings] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ApplicationSettings_ApplicationSettingsCategory_SettingCategoryFk] FOREIGN KEY ([SettingCategoryFk]) REFERENCES [dbo].[ApplicationSettingsCategory] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[DashboardTemplates] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [BelongsToRoleId] int NOT NULL,
        CONSTRAINT [PK_DashboardTemplates] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_DashboardTemplates_Roles_BelongsToRoleId] FOREIGN KEY ([BelongsToRoleId]) REFERENCES [dbo].[Roles] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[PermissionRole] (
        [PermissionsId] int NOT NULL,
        [RolesId] int NOT NULL,
        CONSTRAINT [PK_PermissionRole] PRIMARY KEY ([PermissionsId], [RolesId]),
        CONSTRAINT [FK_PermissionRole_Permissions_PermissionsId] FOREIGN KEY ([PermissionsId]) REFERENCES [dbo].[Permissions] ([Id]),
        CONSTRAINT [FK_PermissionRole_Roles_RolesId] FOREIGN KEY ([RolesId]) REFERENCES [dbo].[Roles] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_JVFromSite] (
        [Id] int NOT NULL IDENTITY,
        [StudentName] nvarchar(200) NOT NULL DEFAULT ((N'')),
        [StudentFamil] nvarchar(200) NOT NULL DEFAULT ((N'')),
        [CreateDate] datetime2 NULL,
        [StudentIdNumber] nvarchar(10) NULL,
        [FeeFor] nvarchar(200) NULL,
        [Fee] int NULL,
        [PhoneNumber] nvarchar(11) NULL,
        [DateOfSettle] datetime2 NULL,
        [TXCode] nvarchar(15) NULL,
        [Description] nvarchar(512) NULL,
        [CardPostfix] nvarchar(200) NULL,
        [DailyJVGuid] uniqueidentifier NOT NULL,
        [DailyJVLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [AttachmentFk] int NULL,
        [ApprovedBy] nvarchar(200) NULL,
        [IsApproved] bit NULL,
        [IsRequiredInvestigation] bit NULL,
        [AdminDescription] nvarchar(max) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_JVFromSite] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_JVFromSite_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_JVFromSite_ShokouhPardis_FileAttachment_AttachmentFk] FOREIGN KEY ([AttachmentFk]) REFERENCES [dbo].[ShokouhPardis_FileAttachment] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_LessonPlan] (
        [Id] int NOT NULL IDENTITY,
        [LevelFk] int NOT NULL,
        [SessionNumber] int NOT NULL,
        [Title] nvarchar(max) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_LessonPlan] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlan_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlan_ShokouhPardis_LevelClass_LevelFk] FOREIGN KEY ([LevelFk]) REFERENCES [dbo].[ShokouhPardis_LevelClass] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_SessionActivityValueOption] (
        [Id] int NOT NULL IDENTITY,
        [SessionActivityFk] int NOT NULL,
        [Title] nvarchar(max) NULL,
        [Color] nvarchar(max) NULL,
        [Value] nvarchar(max) NULL,
        [ShowByValue] nvarchar(max) NULL,
        [BroadcastToRoles] nvarchar(max) NULL,
        [IconName] nvarchar(max) NULL,
        [Icon] nvarchar(max) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_SessionActivityValueOption] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_SessionActivityValueOption_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_SessionActivityValueOption_ShokouhPardis_SessionActivity_SessionActivityFk] FOREIGN KEY ([SessionActivityFk]) REFERENCES [dbo].[ShokouhPardis_SessionActivity] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_DaySession] (
        [Id] int NOT NULL IDENTITY,
        [DaySessionGuid] uniqueidentifier NOT NULL,
        [DaySessionLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [WeekdayID] int NOT NULL,
        [IntervalID] int NOT NULL,
        [TermFk] int NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_DaySession] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_DaySession_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_DaySession_ShokouhPardis_Interval_IntervalID] FOREIGN KEY ([IntervalID]) REFERENCES [dbo].[ShokouhPardis_Interval] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_DaySession_ShokouhPardis_WeekDay_WeekdayID] FOREIGN KEY ([WeekdayID]) REFERENCES [dbo].[ShokouhPardis_WeekDay] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TermClass] (
        [Id] int NOT NULL IDENTITY,
        [TermClassGuid] uniqueidentifier NOT NULL,
        [TermClassLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [TermName] nvarchar(200) NULL,
        [YearID] int NOT NULL,
        [StartDate] datetime2 NULL,
        [EndDate] datetime2 NULL,
        [NextTermFk] int NULL,
        [LastTermFk] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TermClass] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TermClass_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TermClass_ShokouhPardis_YearClass_YearID] FOREIGN KEY ([YearID]) REFERENCES [dbo].[ShokouhPardis_YearClass] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[EntityChanges] (
        [Id] int NOT NULL IDENTITY,
        [EntityName] nvarchar(max) NOT NULL,
        [EntityKey] nvarchar(max) NULL,
        [Action] nvarchar(max) NOT NULL,
        [Field] nvarchar(max) NULL,
        [OldValue] nvarchar(max) NULL,
        [NewValue] nvarchar(max) NULL,
        [ActionByFk] int NULL,
        [ActionWhen] datetime2 NOT NULL,
        CONSTRAINT [PK_EntityChanges] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_EntityChanges_Users_ActionByFk] FOREIGN KEY ([ActionByFk]) REFERENCES [dbo].[Users] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[MessageBoxes] (
        [Id] int NOT NULL IDENTITY,
        [OwnerId] int NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_MessageBoxes] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_MessageBoxes_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_MessageBoxes_Users_OwnerId] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Users] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[RoleUser] (
        [RolesId] int NOT NULL,
        [UsersId] int NOT NULL,
        CONSTRAINT [PK_RoleUser] PRIMARY KEY ([RolesId], [UsersId]),
        CONSTRAINT [FK_RoleUser_Roles_RolesId] FOREIGN KEY ([RolesId]) REFERENCES [dbo].[Roles] ([Id]),
        CONSTRAINT [FK_RoleUser_Users_UsersId] FOREIGN KEY ([UsersId]) REFERENCES [dbo].[Users] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[Dashboards] (
        [Id] int NOT NULL IDENTITY,
        [UserFk] int NOT NULL,
        [DashboardTemplateId] int NOT NULL,
        CONSTRAINT [PK_Dashboards] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Dashboards_DashboardTemplates_DashboardTemplateId] FOREIGN KEY ([DashboardTemplateId]) REFERENCES [dbo].[DashboardTemplates] ([Id]),
        CONSTRAINT [FK_Dashboards_Users_UserFk] FOREIGN KEY ([UserFk]) REFERENCES [dbo].[Users] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[WidgetGroup] (
        [Id] int NOT NULL IDENTITY,
        [Order] int NOT NULL,
        [Title] nvarchar(max) NOT NULL,
        [BelongToRoleId] int NOT NULL,
        [IconName] nvarchar(max) NULL,
        [Icon] nvarchar(max) NULL,
        [IconColor] int NULL,
        [IconSize] int NULL,
        [GroupType] int NOT NULL,
        [DashboardTemplateId] int NULL,
        CONSTRAINT [PK_WidgetGroup] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_WidgetGroup_DashboardTemplates_DashboardTemplateId] FOREIGN KEY ([DashboardTemplateId]) REFERENCES [dbo].[DashboardTemplates] ([Id]),
        CONSTRAINT [FK_WidgetGroup_Roles_BelongToRoleId] FOREIGN KEY ([BelongToRoleId]) REFERENCES [dbo].[Roles] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_LessonPlanSection] (
        [Id] int NOT NULL IDENTITY,
        [LessonPlanFk] int NOT NULL,
        [Order] int NOT NULL,
        [SectionTypeFk] int NOT NULL,
        [SectionTitle] nvarchar(max) NOT NULL,
        [Duration] nvarchar(max) NULL,
        [SectionObjective] nvarchar(max) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_LessonPlanSection] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlanSection_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlanSection_ShokouhPardis_LessonPlanSectionType_SectionTypeFk] FOREIGN KEY ([SectionTypeFk]) REFERENCES [dbo].[ShokouhPardis_LessonPlanSectionType] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlanSection_ShokouhPardis_LessonPlan_LessonPlanFk] FOREIGN KEY ([LessonPlanFk]) REFERENCES [dbo].[ShokouhPardis_LessonPlan] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_Program] (
        [Id] int NOT NULL IDENTITY,
        [ProgramGuid] uniqueidentifier NOT NULL,
        [ProgramLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [ScheduleID] int NOT NULL DEFAULT (((0))),
        [DaysessionID] int NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_Program] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_Program_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_Program_ShokouhPardis_DaySession_DaysessionID] FOREIGN KEY ([DaysessionID]) REFERENCES [dbo].[ShokouhPardis_DaySession] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_Program_ShokouhPardis_schedule_ScheduleID] FOREIGN KEY ([ScheduleID]) REFERENCES [dbo].[ShokouhPardis_schedule] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_LevelBookPrice] (
        [Id] int NOT NULL IDENTITY,
        [LevelBookPriceGuid] uniqueidentifier NOT NULL,
        [LevelBookPriceLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [TermID] int NOT NULL,
        [LevelID] int NOT NULL,
        [TuitionAmount] int NOT NULL,
        [BookPrice] int NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_LevelBookPrice] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LevelBookPrice_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LevelBookPrice_ShokouhPardis_LevelClass_LevelID] FOREIGN KEY ([LevelID]) REFERENCES [dbo].[ShokouhPardis_LevelClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LevelBookPrice_ShokouhPardis_TermClass_TermID] FOREIGN KEY ([TermID]) REFERENCES [dbo].[ShokouhPardis_TermClass] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TeacherTermClass] (
        [Id] int NOT NULL IDENTITY,
        [Guid] uniqueidentifier NOT NULL,
        [LastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [TeacherFk] int NOT NULL,
        [TermFk] int NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TeacherTermClass] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherTermClass_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherTermClass_ShokouhPardis_TeacherClass_TeacherFk] FOREIGN KEY ([TeacherFk]) REFERENCES [dbo].[ShokouhPardis_TeacherClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherTermClass_ShokouhPardis_TermClass_TermFk] FOREIGN KEY ([TermFk]) REFERENCES [dbo].[ShokouhPardis_TermClass] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TeacherTimeSheet] (
        [Id] int NOT NULL IDENTITY,
        [TeacherTimeSheetGuid] uniqueidentifier NOT NULL,
        [TeacherTimeSheetLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [TeacherID] int NOT NULL,
        [TermID] int NOT NULL,
        [WeekDayID] int NOT NULL,
        [IntervalID] int NOT NULL,
        [IsAvailable] bit NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TeacherTimeSheet] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherTimeSheet_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherTimeSheet_ShokouhPardis_Interval_IntervalID] FOREIGN KEY ([IntervalID]) REFERENCES [dbo].[ShokouhPardis_Interval] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherTimeSheet_ShokouhPardis_TeacherClass_TeacherID] FOREIGN KEY ([TeacherID]) REFERENCES [dbo].[ShokouhPardis_TeacherClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherTimeSheet_ShokouhPardis_TermClass_TermID] FOREIGN KEY ([TermID]) REFERENCES [dbo].[ShokouhPardis_TermClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TeacherTimeSheet_ShokouhPardis_WeekDay_WeekDayID] FOREIGN KEY ([WeekDayID]) REFERENCES [dbo].[ShokouhPardis_WeekDay] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TermSessionTemplate] (
        [Id] int NOT NULL IDENTITY,
        [TermFk] int NOT NULL,
        [TemplateName] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [WeekdayIds] nvarchar(max) NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TermSessionTemplate] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TermSessionTemplate_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TermSessionTemplate_ShokouhPardis_TermClass_TermFk] FOREIGN KEY ([TermFk]) REFERENCES [dbo].[ShokouhPardis_TermClass] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TimeTable] (
        [Id] int NOT NULL IDENTITY,
        [TimeTableGuid] uniqueidentifier NOT NULL,
        [TimeTableLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [TermId] int NOT NULL,
        [TeacherId] int NOT NULL,
        [ScheduleId] int NOT NULL,
        [Title] nvarchar(200) NULL,
        [Description] nvarchar(max) NULL,
        [LevelID] int NOT NULL,
        [ClassRoomId] int NOT NULL,
        [IsPrivate] bit NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TimeTable] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTable_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTable_ShokouhPardis_ClassRoom_ClassRoomId] FOREIGN KEY ([ClassRoomId]) REFERENCES [dbo].[ShokouhPardis_ClassRoom] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTable_ShokouhPardis_LevelClass_LevelID] FOREIGN KEY ([LevelID]) REFERENCES [dbo].[ShokouhPardis_LevelClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTable_ShokouhPardis_TeacherClass_TeacherId] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[ShokouhPardis_TeacherClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTable_ShokouhPardis_TermClass_TermId] FOREIGN KEY ([TermId]) REFERENCES [dbo].[ShokouhPardis_TermClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTable_ShokouhPardis_schedule_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [dbo].[ShokouhPardis_schedule] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[Messages] (
        [Id] int NOT NULL IDENTITY,
        [FromId] int NOT NULL,
        [ToId] int NOT NULL,
        [Title] nvarchar(max) NULL,
        [Body] nvarchar(max) NULL,
        [Severity] int NOT NULL,
        [CreateDateTime] datetime2 NOT NULL,
        [SentDateTime] datetime2 NULL,
        [DeliveredDateTime] datetime2 NULL,
        [ReadDateTime] datetime2 NULL,
        [Type] int NOT NULL,
        [Command] nvarchar(max) NULL,
        [CommandArg] nvarchar(max) NULL,
        [ReplyToMessageId] int NULL,
        [ReplyOriginalMessage] nvarchar(max) NULL,
        [MessageBoxId] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Messages_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_Messages_MessageBoxes_MessageBoxId] FOREIGN KEY ([MessageBoxId]) REFERENCES [dbo].[MessageBoxes] ([Id]),
        CONSTRAINT [FK_Messages_Messages_ReplyToMessageId] FOREIGN KEY ([ReplyToMessageId]) REFERENCES [dbo].[Messages] ([Id]),
        CONSTRAINT [FK_Messages_Users_FromId] FOREIGN KEY ([FromId]) REFERENCES [dbo].[Users] ([Id]),
        CONSTRAINT [FK_Messages_Users_ToId] FOREIGN KEY ([ToId]) REFERENCES [dbo].[Users] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[DashboardTemplateWidgets] (
        [DashboardTemplateId] int NOT NULL,
        [WidgetId] int NOT NULL,
        [WidgetGroupId] int NULL,
        CONSTRAINT [PK_DashboardTemplateWidgets] PRIMARY KEY ([DashboardTemplateId], [WidgetId]),
        CONSTRAINT [FK_DashboardTemplateWidgets_DashboardTemplates_DashboardTemplateId] FOREIGN KEY ([DashboardTemplateId]) REFERENCES [dbo].[DashboardTemplates] ([Id]),
        CONSTRAINT [FK_DashboardTemplateWidgets_WidgetGroup_WidgetGroupId] FOREIGN KEY ([WidgetGroupId]) REFERENCES [dbo].[WidgetGroup] ([Id]),
        CONSTRAINT [FK_DashboardTemplateWidgets_Widgets_WidgetId] FOREIGN KEY ([WidgetId]) REFERENCES [dbo].[Widgets] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[DashboardWidgetSettings] (
        [DashboardId] int NOT NULL,
        [WidgetId] int NOT NULL,
        [WidgetGroupId] int NULL,
        [Order] int NOT NULL,
        [Title] nvarchar(max) NULL,
        [TitleClass] nvarchar(max) NULL,
        [Height] nvarchar(max) NULL,
        [IconName] nvarchar(max) NULL,
        [IconColor] int NULL,
        [Icon] nvarchar(max) NULL,
        [IconSize] int NULL,
        [BreakPoints] nvarchar(max) NULL,
        [Hidden] bit NULL,
        [IsInline] bit NULL,
        CONSTRAINT [PK_DashboardWidgetSettings] PRIMARY KEY ([DashboardId], [WidgetId]),
        CONSTRAINT [FK_DashboardWidgetSettings_Dashboards_DashboardId] FOREIGN KEY ([DashboardId]) REFERENCES [dbo].[Dashboards] ([Id]),
        CONSTRAINT [FK_DashboardWidgetSettings_WidgetGroup_WidgetGroupId] FOREIGN KEY ([WidgetGroupId]) REFERENCES [dbo].[WidgetGroup] ([Id]),
        CONSTRAINT [FK_DashboardWidgetSettings_Widgets_WidgetId] FOREIGN KEY ([WidgetId]) REFERENCES [dbo].[Widgets] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_LessonPlanSectionItem] (
        [Id] int NOT NULL IDENTITY,
        [LessonPlanSectionFk] int NOT NULL,
        [Order] int NOT NULL,
        [SectionItemTitle] nvarchar(max) NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_LessonPlanSectionItem] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlanSectionItem_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlanSectionItem_ShokouhPardis_LessonPlanSection_LessonPlanSectionFk] FOREIGN KEY ([LessonPlanSectionFk]) REFERENCES [dbo].[ShokouhPardis_LessonPlanSection] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TermSessionTemplateDate] (
        [Id] int NOT NULL IDENTITY,
        [TermSessionTemplateFk] int NOT NULL,
        [SessionNumber] int NOT NULL,
        [Date] datetime2 NULL,
        [Description] nvarchar(max) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TermSessionTemplateDate] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TermSessionTemplateDate_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TermSessionTemplateDate_ShokouhPardis_TermSessionTemplate_TermSessionTemplateFk] FOREIGN KEY ([TermSessionTemplateFk]) REFERENCES [dbo].[ShokouhPardis_TermSessionTemplate] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_DailyJV] (
        [Id] int NOT NULL IDENTITY,
        [DailyJVGuid] uniqueidentifier NOT NULL,
        [DailyJVLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [TermId] int NOT NULL,
        [StudentID] int NOT NULL,
        [CurrentDate] datetime2 NULL,
        [PaymentType] nvarchar(200) NULL,
        [Fee] int NOT NULL,
        [BillNo] int NULL,
        [FeeFor] nvarchar(200) NULL,
        [DateOfSettle] datetime2 NULL,
        [TXCode] nvarchar(15) NULL,
        [Description] nvarchar(512) NULL,
        [PosCode] int NULL,
        [CardPostfix] nvarchar(200) NULL,
        [JvFromSiteFk] int NULL,
        [TimeTableFk] int NULL,
        [IsPreRegister] bit NULL,
        [VPay] bit NULL,
        [PayBy] nvarchar(max) NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_DailyJV] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_DailyJV_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_DailyJV_ShokouhPardis_StudentClass_StudentID] FOREIGN KEY ([StudentID]) REFERENCES [dbo].[ShokouhPardis_StudentClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_DailyJV_ShokouhPardis_TermClass_TermId] FOREIGN KEY ([TermId]) REFERENCES [dbo].[ShokouhPardis_TermClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_DailyJV_ShokouhPardis_TimeTable_TimeTableFk] FOREIGN KEY ([TimeTableFk]) REFERENCES [dbo].[ShokouhPardis_TimeTable] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TimeTableSession] (
        [Id] int NOT NULL IDENTITY,
        [SessionNumber] int NOT NULL,
        [TimeTableFk] int NOT NULL,
        [TeacherFk] int NOT NULL,
        [ReplacementTimeTableSessionFk] int NULL,
        [ClassRoomFk] int NOT NULL,
        [SessionStatus] nvarchar(max) NOT NULL,
        [SessionDescription] nvarchar(max) NULL,
        [SessionDate] datetime2 NULL,
        [SessionTime] time NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TimeTableSession] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTableSession_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTableSession_ShokouhPardis_ClassRoom_ClassRoomFk] FOREIGN KEY ([ClassRoomFk]) REFERENCES [dbo].[ShokouhPardis_ClassRoom] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTableSession_ShokouhPardis_TeacherClass_TeacherFk] FOREIGN KEY ([TeacherFk]) REFERENCES [dbo].[ShokouhPardis_TeacherClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTableSession_ShokouhPardis_TimeTableSession_ReplacementTimeTableSessionFk] FOREIGN KEY ([ReplacementTimeTableSessionFk]) REFERENCES [dbo].[ShokouhPardis_TimeTableSession] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTableSession_ShokouhPardis_TimeTable_TimeTableFk] FOREIGN KEY ([TimeTableFk]) REFERENCES [dbo].[ShokouhPardis_TimeTable] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_TimeTableStudents] (
        [Id] int NOT NULL IDENTITY,
        [TimeTableId] int NOT NULL,
        [StudentId] int NOT NULL,
        [StudentPercentDiscount] int NULL,
        [StudentAmountDiscount] int NULL,
        [IsBookPaymentComplete] bit NULL,
        [IsPaymentComplete] bit NULL,
        [Description] nvarchar(max) NULL,
        [TimeTableStudentsGuid] uniqueidentifier NOT NULL,
        [TimeTableStudentsLastModified] datetime2 NOT NULL DEFAULT (('1/1/0001 12:00:00 AM')),
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_TimeTableStudents] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTableStudents_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTableStudents_ShokouhPardis_StudentClass_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[ShokouhPardis_StudentClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_TimeTableStudents_ShokouhPardis_TimeTable_TimeTableId] FOREIGN KEY ([TimeTableId]) REFERENCES [dbo].[ShokouhPardis_TimeTable] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[MessageActions] (
        [Id] int NOT NULL IDENTITY,
        [ActionType] nvarchar(max) NOT NULL,
        [MessageId] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_MessageActions] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_MessageActions_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_MessageActions_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [dbo].[Messages] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_MediaAttachment] (
        [Id] int NOT NULL IDENTITY,
        [FileName] nvarchar(max) NULL,
        [FileData] varbinary(max) NULL,
        [Url] nvarchar(max) NULL,
        [MessageId] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_MediaAttachment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_MediaAttachment_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_MediaAttachment_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [dbo].[Messages] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_PreRegistration] (
        [Id] int NOT NULL IDENTITY,
        [DailyJVFk] int NOT NULL,
        [StudentFk] int NOT NULL,
        [TermFk] int NOT NULL,
        [LevelFk] int NOT NULL,
        [IsArchive] bit NULL,
        [PreRegistrationGuid] uniqueidentifier NOT NULL,
        [PreRegistrationLastModified] datetime2 NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_PreRegistration] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_PreRegistration_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_PreRegistration_ShokouhPardis_DailyJV_DailyJVFk] FOREIGN KEY ([DailyJVFk]) REFERENCES [dbo].[ShokouhPardis_DailyJV] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_PreRegistration_ShokouhPardis_LevelClass_LevelFk] FOREIGN KEY ([LevelFk]) REFERENCES [dbo].[ShokouhPardis_LevelClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_PreRegistration_ShokouhPardis_StudentClass_StudentFk] FOREIGN KEY ([StudentFk]) REFERENCES [dbo].[ShokouhPardis_StudentClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_PreRegistration_ShokouhPardis_TermClass_TermFk] FOREIGN KEY ([TermFk]) REFERENCES [dbo].[ShokouhPardis_TermClass] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_StudentSessionActivity] (
        [Id] int NOT NULL IDENTITY,
        [ActivityValueOptionFk] int NOT NULL,
        [TimeTableSessionFk] int NOT NULL,
        [StudentFk] int NOT NULL,
        [ActivityFk] int NOT NULL,
        [ActivityValue] nvarchar(max) NULL,
        [Status] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [TimeTableFk] int NOT NULL,
        [ActivityDateTime] datetime2 NULL,
        [ActivityDeletedDateTime] datetime2 NULL,
        [StudentSessionActivityGuid] uniqueidentifier NOT NULL,
        [StudentSessionActivityLastModified] datetime2 NOT NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_StudentSessionActivity] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentSessionActivity_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivityValueOption_ActivityValueOptionFk] FOREIGN KEY ([ActivityValueOptionFk]) REFERENCES [dbo].[ShokouhPardis_SessionActivityValueOption] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivity_ActivityFk] FOREIGN KEY ([ActivityFk]) REFERENCES [dbo].[ShokouhPardis_SessionActivity] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_StudentClass_StudentFk] FOREIGN KEY ([StudentFk]) REFERENCES [dbo].[ShokouhPardis_StudentClass] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTableSession_TimeTableFk] FOREIGN KEY ([TimeTableFk]) REFERENCES [dbo].[ShokouhPardis_TimeTableSession] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTableSession_TimeTableSessionFk] FOREIGN KEY ([TimeTableSessionFk]) REFERENCES [dbo].[ShokouhPardis_TimeTableSession] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[MessageActionOptions] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NOT NULL,
        [Value] nvarchar(max) NULL,
        [Color] nvarchar(max) NULL,
        [Icon] nvarchar(max) NULL,
        [ActionUrl] nvarchar(max) NULL,
        [MessageActionId] int NULL,
        [Guid] uniqueidentifier NOT NULL,
        [IsDeleted] bit NOT NULL,
        [CreatedByUserId] int NOT NULL,
        [CreatedWhen] datetime2 NOT NULL,
        [ModifiedByUserId] int NULL,
        [ModifiedWhen] datetime2 NULL,
        [BCode] nvarchar(max) NULL,
        [BranchFk] int NOT NULL,
        CONSTRAINT [PK_MessageActionOptions] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_MessageActionOptions_AppBranch_BranchFk] FOREIGN KEY ([BranchFk]) REFERENCES [dbo].[AppBranch] ([Id]),
        CONSTRAINT [FK_MessageActionOptions_MessageActions_MessageActionId] FOREIGN KEY ([MessageActionId]) REFERENCES [dbo].[MessageActions] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE TABLE [dbo].[ShokouhPardis_LessonPlanAttachments] (
        [LessonPlanId] int NOT NULL,
        [AttachmentId] int NOT NULL,
        CONSTRAINT [PK_ShokouhPardis_LessonPlanAttachments] PRIMARY KEY ([LessonPlanId], [AttachmentId]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlanAttachments_ShokouhPardis_LessonPlan_LessonPlanId] FOREIGN KEY ([LessonPlanId]) REFERENCES [dbo].[ShokouhPardis_LessonPlan] ([Id]),
        CONSTRAINT [FK_ShokouhPardis_LessonPlanAttachments_ShokouhPardis_MediaAttachment_AttachmentId] FOREIGN KEY ([AttachmentId]) REFERENCES [dbo].[ShokouhPardis_MediaAttachment] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_AdvanceRegistrations_BranchFk] ON [dbo].[AdvanceRegistrations] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_AppBranch_ParentBranchFk] ON [dbo].[AppBranch] ([ParentBranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ApplicationSettings_SettingCategoryFk] ON [dbo].[ApplicationSettings] ([SettingCategoryFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Dashboards_DashboardTemplateId] ON [dbo].[Dashboards] ([DashboardTemplateId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Dashboards_UserFk] ON [dbo].[Dashboards] ([UserFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_DashboardTemplates_BelongsToRoleId] ON [dbo].[DashboardTemplates] ([BelongsToRoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_DashboardTemplateWidgets_WidgetGroupId] ON [dbo].[DashboardTemplateWidgets] ([WidgetGroupId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_DashboardTemplateWidgets_WidgetId] ON [dbo].[DashboardTemplateWidgets] ([WidgetId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_DashboardWidgetSettings_WidgetGroupId] ON [dbo].[DashboardWidgetSettings] ([WidgetGroupId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_DashboardWidgetSettings_WidgetId] ON [dbo].[DashboardWidgetSettings] ([WidgetId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_EntityChanges_ActionByFk] ON [dbo].[EntityChanges] ([ActionByFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_MessageActionOptions_BranchFk] ON [dbo].[MessageActionOptions] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_MessageActionOptions_MessageActionId] ON [dbo].[MessageActionOptions] ([MessageActionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_MessageActions_BranchFk] ON [dbo].[MessageActions] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_MessageActions_MessageId] ON [dbo].[MessageActions] ([MessageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_MessageBoxes_BranchFk] ON [dbo].[MessageBoxes] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_MessageBoxes_OwnerId] ON [dbo].[MessageBoxes] ([OwnerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Messages_BranchFk] ON [dbo].[Messages] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Messages_FromId] ON [dbo].[Messages] ([FromId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Messages_MessageBoxId] ON [dbo].[Messages] ([MessageBoxId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Messages_ReplyToMessageId] ON [dbo].[Messages] ([ReplyToMessageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Messages_ToId] ON [dbo].[Messages] ([ToId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_PermissionRole_RolesId] ON [dbo].[PermissionRole] ([RolesId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Permissions_BranchFk] ON [dbo].[Permissions] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Roles_BranchFk] ON [dbo].[Roles] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_RoleUser_UsersId] ON [dbo].[RoleUser] ([UsersId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_AccountingCode_BranchFk] ON [dbo].[ShokouhPardis_AccountingCode] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_AccountingTransaction_BranchFk] ON [dbo].[ShokouhPardis_AccountingTransaction] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_BookClass_BranchFk] ON [dbo].[ShokouhPardis_BookClass] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_ClassRoom_BranchFk] ON [dbo].[ShokouhPardis_ClassRoom] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_DailyJV_BranchFk] ON [dbo].[ShokouhPardis_DailyJV] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_DailyJV_StudentID] ON [dbo].[ShokouhPardis_DailyJV] ([StudentID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_DailyJV_TermId] ON [dbo].[ShokouhPardis_DailyJV] ([TermId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_DailyJV_TimeTableFk] ON [dbo].[ShokouhPardis_DailyJV] ([TimeTableFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_DaySession_BranchFk] ON [dbo].[ShokouhPardis_DaySession] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_DaySession_IntervalID] ON [dbo].[ShokouhPardis_DaySession] ([IntervalID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_DaySession_WeekdayID] ON [dbo].[ShokouhPardis_DaySession] ([WeekdayID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_Employee_BranchFk] ON [dbo].[ShokouhPardis_Employee] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_FileAttachment_BranchFk] ON [dbo].[ShokouhPardis_FileAttachment] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_Finance_Flat_BranchFk] ON [dbo].[ShokouhPardis_Finance_Flat] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_Interval_BranchFk] ON [dbo].[ShokouhPardis_Interval] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_JVFromSite_AttachmentFk] ON [dbo].[ShokouhPardis_JVFromSite] ([AttachmentFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_JVFromSite_BranchFk] ON [dbo].[ShokouhPardis_JVFromSite] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlan_BranchFk] ON [dbo].[ShokouhPardis_LessonPlan] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlan_LevelFk] ON [dbo].[ShokouhPardis_LessonPlan] ([LevelFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlanAttachments_AttachmentId] ON [dbo].[ShokouhPardis_LessonPlanAttachments] ([AttachmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlanSection_BranchFk] ON [dbo].[ShokouhPardis_LessonPlanSection] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlanSection_LessonPlanFk] ON [dbo].[ShokouhPardis_LessonPlanSection] ([LessonPlanFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlanSection_SectionTypeFk] ON [dbo].[ShokouhPardis_LessonPlanSection] ([SectionTypeFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlanSectionItem_BranchFk] ON [dbo].[ShokouhPardis_LessonPlanSectionItem] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlanSectionItem_LessonPlanSectionFk] ON [dbo].[ShokouhPardis_LessonPlanSectionItem] ([LessonPlanSectionFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LessonPlanSectionType_BranchFk] ON [dbo].[ShokouhPardis_LessonPlanSectionType] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LevelBookPrice_BranchFk] ON [dbo].[ShokouhPardis_LevelBookPrice] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LevelBookPrice_LevelID] ON [dbo].[ShokouhPardis_LevelBookPrice] ([LevelID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LevelBookPrice_TermID] ON [dbo].[ShokouhPardis_LevelBookPrice] ([TermID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LevelClass_BranchFk] ON [dbo].[ShokouhPardis_LevelClass] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_LevelClass_NextLevelFK] ON [dbo].[ShokouhPardis_LevelClass] ([NextLevelFK]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_MediaAttachment_BranchFk] ON [dbo].[ShokouhPardis_MediaAttachment] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_MediaAttachment_MessageId] ON [dbo].[ShokouhPardis_MediaAttachment] ([MessageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_PreRegistration_BranchFk] ON [dbo].[ShokouhPardis_PreRegistration] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_PreRegistration_DailyJVFk] ON [dbo].[ShokouhPardis_PreRegistration] ([DailyJVFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_PreRegistration_LevelFk] ON [dbo].[ShokouhPardis_PreRegistration] ([LevelFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_PreRegistration_StudentFk] ON [dbo].[ShokouhPardis_PreRegistration] ([StudentFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_PreRegistration_TermFk] ON [dbo].[ShokouhPardis_PreRegistration] ([TermFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_Program_BranchFk] ON [dbo].[ShokouhPardis_Program] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_Program_DaysessionID] ON [dbo].[ShokouhPardis_Program] ([DaysessionID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_Program_ScheduleID] ON [dbo].[ShokouhPardis_Program] ([ScheduleID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_schedule_BranchFk] ON [dbo].[ShokouhPardis_schedule] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_SessionActivity_BranchFk] ON [dbo].[ShokouhPardis_SessionActivity] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_SessionActivityValueOption_BranchFk] ON [dbo].[ShokouhPardis_SessionActivityValueOption] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_SessionActivityValueOption_SessionActivityFk] ON [dbo].[ShokouhPardis_SessionActivityValueOption] ([SessionActivityFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentClass_BranchFk] ON [dbo].[ShokouhPardis_StudentClass] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentClass_Dto_BranchFk] ON [dbo].[ShokouhPardis_StudentClass_Dto] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentClass_OnlineForm_BranchFk] ON [dbo].[ShokouhPardis_StudentClass_OnlineForm] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentSessionActivity_ActivityFk] ON [dbo].[ShokouhPardis_StudentSessionActivity] ([ActivityFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentSessionActivity_ActivityValueOptionFk] ON [dbo].[ShokouhPardis_StudentSessionActivity] ([ActivityValueOptionFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentSessionActivity_BranchFk] ON [dbo].[ShokouhPardis_StudentSessionActivity] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentSessionActivity_StudentFk] ON [dbo].[ShokouhPardis_StudentSessionActivity] ([StudentFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentSessionActivity_TimeTableFk] ON [dbo].[ShokouhPardis_StudentSessionActivity] ([TimeTableFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_StudentSessionActivity_TimeTableSessionFk] ON [dbo].[ShokouhPardis_StudentSessionActivity] ([TimeTableSessionFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherClass_BranchFk] ON [dbo].[ShokouhPardis_TeacherClass] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherLevels_BranchFk] ON [dbo].[ShokouhPardis_TeacherLevels] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherTermClass_BranchFk] ON [dbo].[ShokouhPardis_TeacherTermClass] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherTermClass_TeacherFk] ON [dbo].[ShokouhPardis_TeacherTermClass] ([TeacherFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherTermClass_TermFk] ON [dbo].[ShokouhPardis_TeacherTermClass] ([TermFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherTimeSheet_BranchFk] ON [dbo].[ShokouhPardis_TeacherTimeSheet] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherTimeSheet_IntervalID] ON [dbo].[ShokouhPardis_TeacherTimeSheet] ([IntervalID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherTimeSheet_TeacherID] ON [dbo].[ShokouhPardis_TeacherTimeSheet] ([TeacherID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherTimeSheet_TermID] ON [dbo].[ShokouhPardis_TeacherTimeSheet] ([TermID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TeacherTimeSheet_WeekDayID] ON [dbo].[ShokouhPardis_TeacherTimeSheet] ([WeekDayID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TermClass_BranchFk] ON [dbo].[ShokouhPardis_TermClass] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TermClass_YearID] ON [dbo].[ShokouhPardis_TermClass] ([YearID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TermSessionTemplate_BranchFk] ON [dbo].[ShokouhPardis_TermSessionTemplate] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TermSessionTemplate_TermFk] ON [dbo].[ShokouhPardis_TermSessionTemplate] ([TermFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TermSessionTemplateDate_BranchFk] ON [dbo].[ShokouhPardis_TermSessionTemplateDate] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TermSessionTemplateDate_TermSessionTemplateFk] ON [dbo].[ShokouhPardis_TermSessionTemplateDate] ([TermSessionTemplateFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTable_BranchFk] ON [dbo].[ShokouhPardis_TimeTable] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTable_ClassRoomId] ON [dbo].[ShokouhPardis_TimeTable] ([ClassRoomId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTable_LevelID] ON [dbo].[ShokouhPardis_TimeTable] ([LevelID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTable_ScheduleId] ON [dbo].[ShokouhPardis_TimeTable] ([ScheduleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTable_TeacherId] ON [dbo].[ShokouhPardis_TimeTable] ([TeacherId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTable_TermId] ON [dbo].[ShokouhPardis_TimeTable] ([TermId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTableSession_BranchFk] ON [dbo].[ShokouhPardis_TimeTableSession] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTableSession_ClassRoomFk] ON [dbo].[ShokouhPardis_TimeTableSession] ([ClassRoomFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTableSession_ReplacementTimeTableSessionFk] ON [dbo].[ShokouhPardis_TimeTableSession] ([ReplacementTimeTableSessionFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTableSession_TeacherFk] ON [dbo].[ShokouhPardis_TimeTableSession] ([TeacherFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTableSession_TimeTableFk] ON [dbo].[ShokouhPardis_TimeTableSession] ([TimeTableFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTableStudents_BranchFk] ON [dbo].[ShokouhPardis_TimeTableStudents] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTableStudents_StudentId] ON [dbo].[ShokouhPardis_TimeTableStudents] ([StudentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_TimeTableStudents_TimeTableId] ON [dbo].[ShokouhPardis_TimeTableStudents] ([TimeTableId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_WeekDay_BranchFk] ON [dbo].[ShokouhPardis_WeekDay] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_ShokouhPardis_YearClass_BranchFk] ON [dbo].[ShokouhPardis_YearClass] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_Users_BranchFk] ON [dbo].[Users] ([BranchFk]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_WidgetGroup_BelongToRoleId] ON [dbo].[WidgetGroup] ([BelongToRoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    CREATE INDEX [IX_WidgetGroup_DashboardTemplateId] ON [dbo].[WidgetGroup] ([DashboardTemplateId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194218_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20241002194218_Initial', N'7.0.20');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241002194700_StartPoint')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20241002194700_StartPoint', N'7.0.20');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241011125211_mtn-dailyjv-upate')
BEGIN
    ALTER TABLE [dbo].[ShokouhPardis_DailyJV] ADD [InCardPostFix] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20241011125211_mtn-dailyjv-upate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20241011125211_mtn-dailyjv-upate', N'7.0.20');
END;
GO

COMMIT;
GO

