using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AppBranch",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ParentBranchFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBranch_AppBranch_ParentBranchFk",
                        column: x => x.ParentBranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationSettingsCategory",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCategoryFk = table.Column<int>(type: "int", nullable: true),
                    CategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationSettingsCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatementMeliN",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Transaction_Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Trace_No = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tran_Channel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Deposit_Amount = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ItemModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Verification_Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatementMeliN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatementParsianM",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Transaction_Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deposit_Amount = table.Column<int>(type: "int", nullable: true),
                    Withdrawal_Amount = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Reference_Number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Agent_Branch = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Customer_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatementParsianM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconColor = table.Column<int>(type: "int", nullable: false),
                    IconSize = table.Column<int>(type: "int", nullable: true),
                    BreakPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInline = table.Column<bool>(type: "bit", nullable: true),
                    AllowRemove = table.Column<bool>(type: "bit", nullable: false),
                    AllowHidden = table.Column<bool>(type: "bit", nullable: false),
                    BelongToRoles = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvanceRegistrations",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Allow = table.Column<bool>(type: "bit", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceRegistrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvanceRegistrations_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Allow = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_AccountingCode",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountingCodeGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountingCodeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    AccountingCodeParentID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    AccountType = table.Column<int>(type: "int", nullable: true),
                    Describtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SubjectRecFk = table.Column<int>(type: "int", nullable: true),
                    LastSQ = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_AccountingCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_AccountingCode_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_AccountingTransaction",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountingTransactionGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountingTransactionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    AccountingCodeFk = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SubjectRecFk = table.Column<int>(type: "int", nullable: true),
                    Debit = table.Column<int>(type: "int", nullable: true),
                    Credit = table.Column<int>(type: "int", nullable: true),
                    Balance = table.Column<int>(type: "int", nullable: true),
                    TermId = table.Column<int>(type: "int", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortTxKey = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_AccountingTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_AccountingTransaction_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_BookClass",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookClassGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    BookName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BookPic = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    BookDes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_BookClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_BookClass_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_ClassRoom",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassRoomGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassRoomLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    ClassRoomName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    MinCapacity = table.Column<int>(type: "int", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: true),
                    Describtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_ClassRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_ClassRoom_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_Employee",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_Employee_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_FileAttachment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FileTitle = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Folder = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DataUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_FileAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_FileAttachment_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_Finance_Flat",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Finance_FlatGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Finance_FlatLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    StudentID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    StudentFamily = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreditCardPostFixNo = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    PaymentDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentForTermID = table.Column<int>(type: "int", nullable: true),
                    PaymentForYearID = table.Column<int>(type: "int", nullable: true),
                    PaymentTypeID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    PaymentCauseID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    PaymentAmount = table.Column<long>(type: "bigint", nullable: false),
                    Verification_Status = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_Finance_Flat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_Finance_Flat_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_Interval",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntervalGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IntervalLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeInterval = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TermId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((21))"),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_Interval", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_Interval_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlanSectionType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlanSectionType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSectionType_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LevelClass",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelClassGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    LevelName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    LevelDes = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Grouping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    NextLevelFK = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LevelClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LevelClass_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LevelClass_ShokouhPardis_LevelClass_NextLevelFK",
                        column: x => x.NextLevelFK,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LevelClass",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_schedule",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermFk = table.Column<int>(type: "int", nullable: false),
                    ScheduleGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_schedule_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_SessionActivity",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Levels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelGroups = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionNo = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<int>(type: "int", nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconColor = table.Column<int>(type: "int", nullable: true),
                    IconSize = table.Column<int>(type: "int", nullable: true),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueOptionsCanMultiple = table.Column<bool>(type: "bit", nullable: true),
                    ValueControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionActivityGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SessionActivityLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_SessionActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_SessionActivity_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_StudentClass",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentClassGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    StudentName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValueSql: "(N'')"),
                    StudentFamily = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValueSql: "(N'')"),
                    StudentBirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentFatherName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    StudentMotherFullName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    StudentIDNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "(N'0')"),
                    FatherJob = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MotherJob = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentAddress = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    StudentFrom = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentSHNo = table.Column<int>(type: "int", nullable: true),
                    StudentPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FatherPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MotherPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WhatsAppPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_StudentClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentClass_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_StudentClass_Dto",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentIDNo = table.Column<long>(type: "bigint", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValueSql: "(N'')"),
                    StudentFamily = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValueSql: "(N'')"),
                    StudentSHNo = table.Column<int>(type: "int", nullable: true),
                    StudentBirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentFatherName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FatherJob = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentMotherFullName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    MotherJob = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentAddress = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    StudentFrom = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentClassGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_StudentClass_Dto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentClass_Dto_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_StudentClass_OnlineForm",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentIDNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "(N'0')"),
                    StudentName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValueSql: "(N'')"),
                    StudentFamily = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false, defaultValueSql: "(N'')"),
                    StudentSHNo = table.Column<int>(type: "int", nullable: true),
                    StudentBirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentFatherName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FatherJob = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentMotherFullName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    MotherJob = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentAddress = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    StudentFrom = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FatherPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MotherPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WhatsAppPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentClassGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    SchholStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SchoolEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UniqueKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordVersion = table.Column<int>(type: "int", nullable: true),
                    IsGirl = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_StudentClass_OnlineForm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentClass_OnlineForm_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TeacherClass",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherNationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherClassGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    TeacherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    TeacherFamily = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    TeacherSex = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    TeacherBirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeacherPic = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    TermId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((20))"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TeacherClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherClass_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TeacherLevels",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherLevelsGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherLevelsLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    ProficiencyLevel = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TeacherLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherLevels_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_WeekDay",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekDayGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeekDayLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_WeekDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_WeekDay_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_YearClass",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearClassGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    YearName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_YearClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_YearClass_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationSettings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingCategoryFk = table.Column<int>(type: "int", nullable: false),
                    SettingKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SettingValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationSettings_ApplicationSettingsCategory_SettingCategoryFk",
                        column: x => x.SettingCategoryFk,
                        principalSchema: "dbo",
                        principalTable: "ApplicationSettingsCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DashboardTemplates",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BelongsToRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DashboardTemplates_Roles_BelongsToRoleId",
                        column: x => x.BelongsToRoleId,
                        principalSchema: "dbo",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRole",
                schema: "dbo",
                columns: table => new
                {
                    PermissionsId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRole", x => new { x.PermissionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_PermissionRole_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalSchema: "dbo",
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PermissionRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalSchema: "dbo",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_JVFromSite",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    StudentFamil = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentIdNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FeeFor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Fee = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    DateOfSettle = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TXCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CardPostfix = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DailyJVGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyJVLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    AttachmentFk = table.Column<int>(type: "int", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    IsRequiredInvestigation = table.Column<bool>(type: "bit", nullable: true),
                    AdminDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_JVFromSite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_JVFromSite_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_JVFromSite_ShokouhPardis_FileAttachment_AttachmentFk",
                        column: x => x.AttachmentFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_FileAttachment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlan",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelFk = table.Column<int>(type: "int", nullable: false),
                    SessionNumber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlan_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlan_ShokouhPardis_LevelClass_LevelFk",
                        column: x => x.LevelFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LevelClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_SessionActivityValueOption",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionActivityFk = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowByValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BroadcastToRoles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_SessionActivityValueOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_SessionActivityValueOption_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_SessionActivityValueOption_ShokouhPardis_SessionActivity_SessionActivityFk",
                        column: x => x.SessionActivityFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_SessionActivity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_DaySession",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaySessionGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaySessionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    WeekdayID = table.Column<int>(type: "int", nullable: false),
                    IntervalID = table.Column<int>(type: "int", nullable: false),
                    TermFk = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_DaySession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_DaySession_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_DaySession_ShokouhPardis_Interval_IntervalID",
                        column: x => x.IntervalID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_Interval",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_DaySession_ShokouhPardis_WeekDay_WeekdayID",
                        column: x => x.WeekdayID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_WeekDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TermClass",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermClassGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TermClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    TermName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    YearID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NextTermFk = table.Column<int>(type: "int", nullable: true),
                    LastTermFk = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TermClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TermClass_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TermClass_ShokouhPardis_YearClass_YearID",
                        column: x => x.YearID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_YearClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EntityChanges",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionByFk = table.Column<int>(type: "int", nullable: true),
                    ActionWhen = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityChanges_Users_ActionByFk",
                        column: x => x.ActionByFk,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MessageBoxes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageBoxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageBoxes_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MessageBoxes_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                schema: "dbo",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalSchema: "dbo",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Dashboards",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFk = table.Column<int>(type: "int", nullable: false),
                    DashboardTemplateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dashboards_DashboardTemplates_DashboardTemplateId",
                        column: x => x.DashboardTemplateId,
                        principalSchema: "dbo",
                        principalTable: "DashboardTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Dashboards_Users_UserFk",
                        column: x => x.UserFk,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "WidgetGroup",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BelongToRoleId = table.Column<int>(type: "int", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconColor = table.Column<int>(type: "int", nullable: true),
                    IconSize = table.Column<int>(type: "int", nullable: true),
                    GroupType = table.Column<int>(type: "int", nullable: false),
                    DashboardTemplateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WidgetGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WidgetGroup_DashboardTemplates_DashboardTemplateId",
                        column: x => x.DashboardTemplateId,
                        principalSchema: "dbo",
                        principalTable: "DashboardTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WidgetGroup_Roles_BelongToRoleId",
                        column: x => x.BelongToRoleId,
                        principalSchema: "dbo",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlanSection",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonPlanFk = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SectionTypeFk = table.Column<int>(type: "int", nullable: false),
                    SectionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionObjective = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlanSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSection_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSection_ShokouhPardis_LessonPlanSectionType_SectionTypeFk",
                        column: x => x.SectionTypeFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LessonPlanSectionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSection_ShokouhPardis_LessonPlan_LessonPlanFk",
                        column: x => x.LessonPlanFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LessonPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_Program",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProgramLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    ScheduleID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    DaysessionID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_Program", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_Program_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_Program_ShokouhPardis_DaySession_DaysessionID",
                        column: x => x.DaysessionID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_DaySession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_Program_ShokouhPardis_schedule_ScheduleID",
                        column: x => x.ScheduleID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LevelBookPrice",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelBookPriceGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelBookPriceLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    TermID = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    TuitionAmount = table.Column<int>(type: "int", nullable: false),
                    BookPrice = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LevelBookPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LevelBookPrice_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LevelBookPrice_ShokouhPardis_LevelClass_LevelID",
                        column: x => x.LevelID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LevelClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LevelBookPrice_ShokouhPardis_TermClass_TermID",
                        column: x => x.TermID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TeacherTermClass",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    TeacherFk = table.Column<int>(type: "int", nullable: false),
                    TermFk = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TeacherTermClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherTermClass_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherTermClass_ShokouhPardis_TeacherClass_TeacherFk",
                        column: x => x.TeacherFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TeacherClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherTermClass_ShokouhPardis_TermClass_TermFk",
                        column: x => x.TermFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TeacherTimeSheet",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherTimeSheetGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherTimeSheetLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    TermID = table.Column<int>(type: "int", nullable: false),
                    WeekDayID = table.Column<int>(type: "int", nullable: false),
                    IntervalID = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TeacherTimeSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherTimeSheet_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherTimeSheet_ShokouhPardis_Interval_IntervalID",
                        column: x => x.IntervalID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_Interval",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherTimeSheet_ShokouhPardis_TeacherClass_TeacherID",
                        column: x => x.TeacherID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TeacherClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherTimeSheet_ShokouhPardis_TermClass_TermID",
                        column: x => x.TermID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TeacherTimeSheet_ShokouhPardis_WeekDay_WeekDayID",
                        column: x => x.WeekDayID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_WeekDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TermSessionTemplate",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermFk = table.Column<int>(type: "int", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeekdayIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TermSessionTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TermSessionTemplate_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TermSessionTemplate_ShokouhPardis_TermClass_TermFk",
                        column: x => x.TermFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TimeTable",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeTableGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeTableLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    TermId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    ClassRoomId = table.Column<int>(type: "int", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TimeTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTable_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTable_ShokouhPardis_ClassRoom_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_ClassRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTable_ShokouhPardis_LevelClass_LevelID",
                        column: x => x.LevelID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LevelClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTable_ShokouhPardis_TeacherClass_TeacherId",
                        column: x => x.TeacherId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TeacherClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTable_ShokouhPardis_TermClass_TermId",
                        column: x => x.TermId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTable_ShokouhPardis_schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromId = table.Column<int>(type: "int", nullable: false),
                    ToId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Severity = table.Column<int>(type: "int", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SentDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveredDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReadDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Command = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommandArg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplyToMessageId = table.Column<int>(type: "int", nullable: true),
                    ReplyOriginalMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageBoxId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Messages_MessageBoxes_MessageBoxId",
                        column: x => x.MessageBoxId,
                        principalSchema: "dbo",
                        principalTable: "MessageBoxes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Messages_ReplyToMessageId",
                        column: x => x.ReplyToMessageId,
                        principalSchema: "dbo",
                        principalTable: "Messages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Users_FromId",
                        column: x => x.FromId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Messages_Users_ToId",
                        column: x => x.ToId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DashboardTemplateWidgets",
                schema: "dbo",
                columns: table => new
                {
                    DashboardTemplateId = table.Column<int>(type: "int", nullable: false),
                    WidgetId = table.Column<int>(type: "int", nullable: false),
                    WidgetGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardTemplateWidgets", x => new { x.DashboardTemplateId, x.WidgetId });
                    table.ForeignKey(
                        name: "FK_DashboardTemplateWidgets_DashboardTemplates_DashboardTemplateId",
                        column: x => x.DashboardTemplateId,
                        principalSchema: "dbo",
                        principalTable: "DashboardTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DashboardTemplateWidgets_WidgetGroup_WidgetGroupId",
                        column: x => x.WidgetGroupId,
                        principalSchema: "dbo",
                        principalTable: "WidgetGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DashboardTemplateWidgets_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalSchema: "dbo",
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DashboardWidgetSettings",
                schema: "dbo",
                columns: table => new
                {
                    DashboardId = table.Column<int>(type: "int", nullable: false),
                    WidgetId = table.Column<int>(type: "int", nullable: false),
                    WidgetGroupId = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconColor = table.Column<int>(type: "int", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconSize = table.Column<int>(type: "int", nullable: true),
                    BreakPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hidden = table.Column<bool>(type: "bit", nullable: true),
                    IsInline = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardWidgetSettings", x => new { x.DashboardId, x.WidgetId });
                    table.ForeignKey(
                        name: "FK_DashboardWidgetSettings_Dashboards_DashboardId",
                        column: x => x.DashboardId,
                        principalSchema: "dbo",
                        principalTable: "Dashboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DashboardWidgetSettings_WidgetGroup_WidgetGroupId",
                        column: x => x.WidgetGroupId,
                        principalSchema: "dbo",
                        principalTable: "WidgetGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DashboardWidgetSettings_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalSchema: "dbo",
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlanSectionItem",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonPlanSectionFk = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SectionItemTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlanSectionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSectionItem_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSectionItem_ShokouhPardis_LessonPlanSection_LessonPlanSectionFk",
                        column: x => x.LessonPlanSectionFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LessonPlanSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TermSessionTemplateDate",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermSessionTemplateFk = table.Column<int>(type: "int", nullable: false),
                    SessionNumber = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TermSessionTemplateDate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TermSessionTemplateDate_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TermSessionTemplateDate_ShokouhPardis_TermSessionTemplate_TermSessionTemplateFk",
                        column: x => x.TermSessionTemplateFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermSessionTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_DailyJV",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyJVGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DailyJVLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    TermId = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CurrentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Fee = table.Column<int>(type: "int", nullable: false),
                    BillNo = table.Column<int>(type: "int", nullable: true),
                    FeeFor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DateOfSettle = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TXCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PosCode = table.Column<int>(type: "int", nullable: true),
                    CardPostfix = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    JvFromSiteFk = table.Column<int>(type: "int", nullable: true),
                    TimeTableFk = table.Column<int>(type: "int", nullable: true),
                    IsPreRegister = table.Column<bool>(type: "bit", nullable: true),
                    VPay = table.Column<bool>(type: "bit", nullable: true),
                    PayBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_DailyJV", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_DailyJV_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_DailyJV_ShokouhPardis_StudentClass_StudentID",
                        column: x => x.StudentID,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_StudentClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_DailyJV_ShokouhPardis_TermClass_TermId",
                        column: x => x.TermId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_DailyJV_ShokouhPardis_TimeTable_TimeTableFk",
                        column: x => x.TimeTableFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TimeTable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TimeTableSession",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionNumber = table.Column<int>(type: "int", nullable: false),
                    TimeTableFk = table.Column<int>(type: "int", nullable: false),
                    TeacherFk = table.Column<int>(type: "int", nullable: false),
                    ReplacementTimeTableSessionFk = table.Column<int>(type: "int", nullable: true),
                    ClassRoomFk = table.Column<int>(type: "int", nullable: false),
                    SessionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TimeTableSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTableSession_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTableSession_ShokouhPardis_ClassRoom_ClassRoomFk",
                        column: x => x.ClassRoomFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_ClassRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTableSession_ShokouhPardis_TeacherClass_TeacherFk",
                        column: x => x.TeacherFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TeacherClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTableSession_ShokouhPardis_TimeTableSession_ReplacementTimeTableSessionFk",
                        column: x => x.ReplacementTimeTableSessionFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TimeTableSession",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTableSession_ShokouhPardis_TimeTable_TimeTableFk",
                        column: x => x.TimeTableFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TimeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_TimeTableStudents",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeTableId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentPercentDiscount = table.Column<int>(type: "int", nullable: true),
                    StudentAmountDiscount = table.Column<int>(type: "int", nullable: true),
                    IsBookPaymentComplete = table.Column<bool>(type: "bit", nullable: true),
                    IsPaymentComplete = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeTableStudentsGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeTableStudentsLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_TimeTableStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTableStudents_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTableStudents_ShokouhPardis_StudentClass_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_StudentClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_TimeTableStudents_ShokouhPardis_TimeTable_TimeTableId",
                        column: x => x.TimeTableId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TimeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MessageActions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageActions_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MessageActions_Messages_MessageId",
                        column: x => x.MessageId,
                        principalSchema: "dbo",
                        principalTable: "Messages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_MediaAttachment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_MediaAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_MediaAttachment_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_MediaAttachment_Messages_MessageId",
                        column: x => x.MessageId,
                        principalSchema: "dbo",
                        principalTable: "Messages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_PreRegistration",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyJVFk = table.Column<int>(type: "int", nullable: false),
                    StudentFk = table.Column<int>(type: "int", nullable: false),
                    TermFk = table.Column<int>(type: "int", nullable: false),
                    LevelFk = table.Column<int>(type: "int", nullable: false),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    PreRegistrationGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PreRegistrationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_PreRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_PreRegistration_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_DailyJV_DailyJVFk",
                        column: x => x.DailyJVFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_DailyJV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_LevelClass_LevelFk",
                        column: x => x.LevelFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LevelClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_StudentClass_StudentFk",
                        column: x => x.StudentFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_StudentClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_TermClass_TermFk",
                        column: x => x.TermFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_StudentSessionActivity",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityValueOptionFk = table.Column<int>(type: "int", nullable: false),
                    TimeTableSessionFk = table.Column<int>(type: "int", nullable: false),
                    StudentFk = table.Column<int>(type: "int", nullable: false),
                    ActivityFk = table.Column<int>(type: "int", nullable: false),
                    ActivityValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeTableFk = table.Column<int>(type: "int", nullable: false),
                    ActivityDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActivityDeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentSessionActivityGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentSessionActivityLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_StudentSessionActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentSessionActivity_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivityValueOption_ActivityValueOptionFk",
                        column: x => x.ActivityValueOptionFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_SessionActivityValueOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivity_ActivityFk",
                        column: x => x.ActivityFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_SessionActivity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_StudentClass_StudentFk",
                        column: x => x.StudentFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_StudentClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTableSession_TimeTableFk",
                        column: x => x.TimeTableFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TimeTableSession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTableSession_TimeTableSessionFk",
                        column: x => x.TimeTableSessionFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TimeTableSession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MessageActionOptions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageActionId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageActionOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageActionOptions_AppBranch_BranchFk",
                        column: x => x.BranchFk,
                        principalSchema: "dbo",
                        principalTable: "AppBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MessageActionOptions_MessageActions_MessageActionId",
                        column: x => x.MessageActionId,
                        principalSchema: "dbo",
                        principalTable: "MessageActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlanAttachments",
                schema: "dbo",
                columns: table => new
                {
                    LessonPlanId = table.Column<int>(type: "int", nullable: false),
                    AttachmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlanAttachments", x => new { x.LessonPlanId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanAttachments_ShokouhPardis_LessonPlan_LessonPlanId",
                        column: x => x.LessonPlanId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_LessonPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanAttachments_ShokouhPardis_MediaAttachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_MediaAttachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceRegistrations_BranchFk",
                schema: "dbo",
                table: "AdvanceRegistrations",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_AppBranch_ParentBranchFk",
                schema: "dbo",
                table: "AppBranch",
                column: "ParentBranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationSettings_SettingCategoryFk",
                schema: "dbo",
                table: "ApplicationSettings",
                column: "SettingCategoryFk");

            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_DashboardTemplateId",
                schema: "dbo",
                table: "Dashboards",
                column: "DashboardTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_UserFk",
                schema: "dbo",
                table: "Dashboards",
                column: "UserFk");

            migrationBuilder.CreateIndex(
                name: "IX_DashboardTemplates_BelongsToRoleId",
                schema: "dbo",
                table: "DashboardTemplates",
                column: "BelongsToRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_DashboardTemplateWidgets_WidgetGroupId",
                schema: "dbo",
                table: "DashboardTemplateWidgets",
                column: "WidgetGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DashboardTemplateWidgets_WidgetId",
                schema: "dbo",
                table: "DashboardTemplateWidgets",
                column: "WidgetId");

            migrationBuilder.CreateIndex(
                name: "IX_DashboardWidgetSettings_WidgetGroupId",
                schema: "dbo",
                table: "DashboardWidgetSettings",
                column: "WidgetGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DashboardWidgetSettings_WidgetId",
                schema: "dbo",
                table: "DashboardWidgetSettings",
                column: "WidgetId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityChanges_ActionByFk",
                schema: "dbo",
                table: "EntityChanges",
                column: "ActionByFk");

            migrationBuilder.CreateIndex(
                name: "IX_MessageActionOptions_BranchFk",
                schema: "dbo",
                table: "MessageActionOptions",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_MessageActionOptions_MessageActionId",
                schema: "dbo",
                table: "MessageActionOptions",
                column: "MessageActionId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageActions_BranchFk",
                schema: "dbo",
                table: "MessageActions",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_MessageActions_MessageId",
                schema: "dbo",
                table: "MessageActions",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageBoxes_BranchFk",
                schema: "dbo",
                table: "MessageBoxes",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_MessageBoxes_OwnerId",
                schema: "dbo",
                table: "MessageBoxes",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_BranchFk",
                schema: "dbo",
                table: "Messages",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromId",
                schema: "dbo",
                table: "Messages",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MessageBoxId",
                schema: "dbo",
                table: "Messages",
                column: "MessageBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReplyToMessageId",
                schema: "dbo",
                table: "Messages",
                column: "ReplyToMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToId",
                schema: "dbo",
                table: "Messages",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RolesId",
                schema: "dbo",
                table: "PermissionRole",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_BranchFk",
                schema: "dbo",
                table: "Permissions",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_BranchFk",
                schema: "dbo",
                table: "Roles",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                schema: "dbo",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_AccountingCode_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_AccountingCode",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_AccountingTransaction_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_AccountingTransaction",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_BookClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_ClassRoom_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_DailyJV_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_DailyJV",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_DailyJV_StudentID",
                schema: "dbo",
                table: "ShokouhPardis_DailyJV",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_DailyJV_TermId",
                schema: "dbo",
                table: "ShokouhPardis_DailyJV",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_DailyJV_TimeTableFk",
                schema: "dbo",
                table: "ShokouhPardis_DailyJV",
                column: "TimeTableFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_DaySession_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_DaySession_IntervalID",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                column: "IntervalID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_DaySession_WeekdayID",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                column: "WeekdayID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_Employee_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Employee",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_FileAttachment_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_FileAttachment",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_Finance_Flat_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Finance_Flat",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_Interval_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_JVFromSite_AttachmentFk",
                schema: "dbo",
                table: "ShokouhPardis_JVFromSite",
                column: "AttachmentFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_JVFromSite_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_JVFromSite",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlan_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlan",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlan_LevelFk",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlan",
                column: "LevelFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanAttachments_AttachmentId",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlanAttachments",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSection_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlanSection",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSection_LessonPlanFk",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlanSection",
                column: "LessonPlanFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSection_SectionTypeFk",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlanSection",
                column: "SectionTypeFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSectionItem_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlanSectionItem",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSectionItem_LessonPlanSectionFk",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlanSectionItem",
                column: "LessonPlanSectionFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSectionType_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LessonPlanSectionType",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LevelBookPrice_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LevelBookPrice",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LevelBookPrice_LevelID",
                schema: "dbo",
                table: "ShokouhPardis_LevelBookPrice",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LevelBookPrice_TermID",
                schema: "dbo",
                table: "ShokouhPardis_LevelBookPrice",
                column: "TermID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LevelClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LevelClass_NextLevelFK",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                column: "NextLevelFK");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_MediaAttachment_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_MediaAttachment",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_MediaAttachment_MessageId",
                schema: "dbo",
                table: "ShokouhPardis_MediaAttachment",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_PreRegistration_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_PreRegistration",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_PreRegistration_DailyJVFk",
                schema: "dbo",
                table: "ShokouhPardis_PreRegistration",
                column: "DailyJVFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_PreRegistration_LevelFk",
                schema: "dbo",
                table: "ShokouhPardis_PreRegistration",
                column: "LevelFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_PreRegistration_StudentFk",
                schema: "dbo",
                table: "ShokouhPardis_PreRegistration",
                column: "StudentFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_PreRegistration_TermFk",
                schema: "dbo",
                table: "ShokouhPardis_PreRegistration",
                column: "TermFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_Program_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_Program_DaysessionID",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                column: "DaysessionID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_Program_ScheduleID",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                column: "ScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_schedule_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_SessionActivity_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_SessionActivity",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_SessionActivityValueOption_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_SessionActivityValueOption",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_SessionActivityValueOption_SessionActivityFk",
                schema: "dbo",
                table: "ShokouhPardis_SessionActivityValueOption",
                column: "SessionActivityFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentClass_Dto_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass_Dto",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentClass_OnlineForm_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_ActivityFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "ActivityFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_ActivityValueOptionFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "ActivityValueOptionFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_StudentFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "StudentFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_TimeTableFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "TimeTableFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_TimeTableSessionFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "TimeTableSessionFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherLevels_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherLevels",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherTermClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherTermClass",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherTermClass_TeacherFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherTermClass",
                column: "TeacherFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherTermClass_TermFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherTermClass",
                column: "TermFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherTimeSheet_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherTimeSheet",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherTimeSheet_IntervalID",
                schema: "dbo",
                table: "ShokouhPardis_TeacherTimeSheet",
                column: "IntervalID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherTimeSheet_TeacherID",
                schema: "dbo",
                table: "ShokouhPardis_TeacherTimeSheet",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherTimeSheet_TermID",
                schema: "dbo",
                table: "ShokouhPardis_TeacherTimeSheet",
                column: "TermID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TeacherTimeSheet_WeekDayID",
                schema: "dbo",
                table: "ShokouhPardis_TeacherTimeSheet",
                column: "WeekDayID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TermClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TermClass_YearID",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                column: "YearID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TermSessionTemplate_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TermSessionTemplate",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TermSessionTemplate_TermFk",
                schema: "dbo",
                table: "ShokouhPardis_TermSessionTemplate",
                column: "TermFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TermSessionTemplateDate_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TermSessionTemplateDate",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TermSessionTemplateDate_TermSessionTemplateFk",
                schema: "dbo",
                table: "ShokouhPardis_TermSessionTemplateDate",
                column: "TermSessionTemplateFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTable_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TimeTable",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTable_ClassRoomId",
                schema: "dbo",
                table: "ShokouhPardis_TimeTable",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTable_LevelID",
                schema: "dbo",
                table: "ShokouhPardis_TimeTable",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTable_ScheduleId",
                schema: "dbo",
                table: "ShokouhPardis_TimeTable",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTable_TeacherId",
                schema: "dbo",
                table: "ShokouhPardis_TimeTable",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTable_TermId",
                schema: "dbo",
                table: "ShokouhPardis_TimeTable",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTableSession_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TimeTableSession",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTableSession_ClassRoomFk",
                schema: "dbo",
                table: "ShokouhPardis_TimeTableSession",
                column: "ClassRoomFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTableSession_ReplacementTimeTableSessionFk",
                schema: "dbo",
                table: "ShokouhPardis_TimeTableSession",
                column: "ReplacementTimeTableSessionFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTableSession_TeacherFk",
                schema: "dbo",
                table: "ShokouhPardis_TimeTableSession",
                column: "TeacherFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTableSession_TimeTableFk",
                schema: "dbo",
                table: "ShokouhPardis_TimeTableSession",
                column: "TimeTableFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTableStudents_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TimeTableStudents",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTableStudents_StudentId",
                schema: "dbo",
                table: "ShokouhPardis_TimeTableStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_TimeTableStudents_TimeTableId",
                schema: "dbo",
                table: "ShokouhPardis_TimeTableStudents",
                column: "TimeTableId");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_WeekDay_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_YearClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchFk",
                schema: "dbo",
                table: "Users",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_WidgetGroup_BelongToRoleId",
                schema: "dbo",
                table: "WidgetGroup",
                column: "BelongToRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WidgetGroup_DashboardTemplateId",
                schema: "dbo",
                table: "WidgetGroup",
                column: "DashboardTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvanceRegistrations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ApplicationSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DashboardTemplateWidgets",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DashboardWidgetSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EntityChanges",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MessageActionOptions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PermissionRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RoleUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_AccountingCode",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_AccountingTransaction",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_BookClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_Employee",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_Finance_Flat",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_JVFromSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlanAttachments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlanSectionItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LevelBookPrice",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_PreRegistration",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_Program",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_StudentClass_Dto",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_StudentClass_OnlineForm",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_StudentSessionActivity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TeacherLevels",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TeacherTermClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TeacherTimeSheet",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TermSessionTemplateDate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TimeTableStudents",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StatementMeliN",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StatementParsianM",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ApplicationSettingsCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Dashboards",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WidgetGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Widgets",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MessageActions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Permissions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_FileAttachment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_MediaAttachment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlanSection",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_DailyJV",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_DaySession",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_SessionActivityValueOption",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TimeTableSession",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TermSessionTemplate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DashboardTemplates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Messages",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlanSectionType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlan",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_StudentClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_Interval",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_WeekDay",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_SessionActivity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TimeTable",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MessageBoxes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_ClassRoom",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LevelClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TeacherClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_TermClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_schedule",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_YearClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AppBranch",
                schema: "dbo");
        }
    }
}
