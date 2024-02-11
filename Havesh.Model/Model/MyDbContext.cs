using Havesh.Model.Contract;
using Havesh.Model.Data;
using Havesh.Model.Filter;
using Havesh.Model.Interceptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Havesh.Model.Model;

public partial class MyDbContext : DbContext
{
	private readonly IConfiguration _configuration;
    public IUserSessionService UserSessionService { get; }

    public MyDbContext(DbContextOptions<MyDbContext> options, 
		IConfiguration configuration
	)
		: base(options)
    {
        _configuration = configuration;
    }


	public virtual DbSet<ShokouhPardisAccountingCode> ShokouhPardisAccountingCodes { get; set; } = null!;
	public virtual DbSet<ShokouhPardisAccountingTransaction> ShokouhPardisAccountingTransactions { get; set; } = null!;
	public virtual DbSet<ShokouhPardisBookClass> ShokouhPardisBookClasses { get; set; } = null!;
	public virtual DbSet<ShokouhPardisClassRoom> ShokouhPardisClassRooms { get; set; } = null!;
	public virtual DbSet<ShokouhPardisDailyJv> ShokouhPardisDailyJvs { get; set; } = null!;
	public virtual DbSet<ShokouhPardisDaySession> ShokouhPardisDaySessions { get; set; } = null!;
	public virtual DbSet<ShokouhPardisEmployee> ShokouhPardisEmployees { get; set; } = null!;
	public virtual DbSet<ShokouhPardisFileAttachment> ShokouhPardisFileAttachments { get; set; } = null!;
	public virtual DbSet<ShokouhPardisFinanceFlat> ShokouhPardisFinanceFlats { get; set; } = null!;
	public virtual DbSet<ShokouhPardisInterval> ShokouhPardisIntervals { get; set; } = null!;
	public virtual DbSet<ShokouhPardisJvfromSite> ShokouhPardisJvfromSites { get; set; } = null!;
	public virtual DbSet<ShokouhPardisLevelBookPrice> ShokouhPardisLevelBookPrices { get; set; } = null!;
	public virtual DbSet<ShokouhPardisLevelClass> ShokouhPardisLevelClasses { get; set; } = null!;
	public virtual DbSet<ShokouhPardisProgram> ShokouhPardisPrograms { get; set; } = null!;
	public virtual DbSet<ShokouhPardisSchedule> ShokouhPardisSchedules { get; set; } = null!;
	public virtual DbSet<ShokouhPardisStudentClass> ShokouhPardisStudentClasses { get; set; } = null!;
	public virtual DbSet<ShokouhPardisStudentClassDto> ShokouhPardisStudentClassDtos { get; set; } = null!;
	public virtual DbSet<ShokouhPardisStudentClassOnlineForm> ShokouhPardisStudentClassOnlineForms { get; set; } = null!;
	public virtual DbSet<ShokouhPardisTeacherClass> ShokouhPardisTeacherClasses { get; set; } = null!;
	public virtual DbSet<ShokouhPardisTeacherLevel> ShokouhPardisTeacherLevels { get; set; } = null!;
	public virtual DbSet<ShokouhPardisTeacherTermClass> ShokouhPardisTeacherTermClasses { get; set; } = null!;
	public virtual DbSet<ShokouhPardisTeacherTimeSheet> ShokouhPardisTeacherTimeSheets { get; set; } = null!;
	public virtual DbSet<ShokouhPardisTermClass> ShokouhPardisTermClasses { get; set; } = null!;
	public virtual DbSet<ShokouhPardisTimeTable> ShokouhPardisTimeTables { get; set; } = null!;
	public virtual DbSet<ShokouhPardisTimeTableStudent> ShokouhPardisTimeTableStudents { get; set; } = null!;
	public virtual DbSet<ShokouhPardisWeekDay> ShokouhPardisWeekDays { get; set; } = null!;
	public virtual DbSet<ShokouhPardisYearClass> ShokouhPardisYearClasses { get; set; } = null!;
        
	public virtual DbSet<StatementMeliN> StatementMeliNs { get; set; } = null!;
	public virtual DbSet<StatementParsianM> StatementParsianMs { get; set; } = null!;
        
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (optionsBuilder.IsConfigured) 
			return;

		var conStr = _configuration.GetConnectionString("ArvanConnection");
		optionsBuilder
			.UseSqlServer(conStr)
			//.UseChangeTrackingProxies(false,false)
			//.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
			.EnableSensitiveDataLogging();

		optionsBuilder.UseLoggerFactory(
			LoggerFactory.Create(builder => builder.AddConsole()));
		optionsBuilder.ConfigureWarnings(warnings =>
		{
			warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored);
		});
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasDefaultSchema("dbo")
			.UseCollation("Latin1_General_CI_AS");


        modelBuilder.Entity<ShokouhPardisAccountingCode>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_AccountingCode");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.AccountingCodeLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property(e => e.AccountingCodeParentId).HasColumnName("AccountingCodeParentID");

			entity.Property(e => e.Code).HasMaxLength(20);

			entity.Property(e => e.LastSq).HasColumnName("LastSQ");

			entity.Property(e => e.Title).HasMaxLength(512);
		});

		modelBuilder.Entity<ShokouhPardisAccountingTransaction>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_AccountingTransaction");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.AccountingTransactionLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property(e => e.Code).HasMaxLength(20);

			entity.Property(e => e.ShortTxKey).HasMaxLength(512);
		});

		modelBuilder.Entity<ShokouhPardisBookClass>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_BookClass", "dbo");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.BookClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property(e => e.BookDes).HasMaxLength(200);

			entity.Property(e => e.BookName).HasMaxLength(200);

			entity.Property(e => e.BookPic).HasMaxLength(1024);
		});

		modelBuilder.Entity<ShokouhPardisClassRoom>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_ClassRoom", "dbo");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.ClassRoomLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property(e => e.ClassRoomName)
				.HasMaxLength(200)
				.HasDefaultValueSql("(N'')");
		});

		modelBuilder.Entity<ShokouhPardisDailyJv>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_DailyJV");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<string>(e => e.CardPostfix).HasMaxLength(200);

			entity.Property<Guid>(e => e.DailyJvguid).HasColumnName("DailyJVGuid");

			entity.Property<DateTime>(e => e.DailyJvlastModified)
				.HasColumnName("DailyJVLastModified")
				.HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.Description).HasMaxLength(512);

			entity.Property<string>(e => e.FeeFor).HasMaxLength(200);

			entity.Property<string>(e => e.PaymentType).HasMaxLength(200);

			entity.Property<int>(e => e.StudentId).HasColumnName("StudentID");

			entity.Property<string>(e => e.Txcode)
				.HasMaxLength(15)
				.HasColumnName("TXCode");
		});

		modelBuilder.Entity<ShokouhPardisDaySession>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_DaySession", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.DaySessionLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<int>(e => e.IntervalId).HasColumnName("IntervalID");

			entity.Property<int>(e => e.WeekdayId).HasColumnName("WeekdayID");
		});

		modelBuilder.Entity<ShokouhPardisEmployee>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_Employee");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.EmployeeLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property(e => e.Title).HasMaxLength(200);
		});

		modelBuilder.Entity<ShokouhPardisFileAttachment>(entity =>
		{
			entity.ToTable("ShokouhPardis_FileAttachment");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<string>(e => e.FileName).HasMaxLength(512);

			entity.Property<string>(e => e.FileTitle).HasMaxLength(512);

			entity.Property<string>(e => e.Folder).HasMaxLength(512);

			entity.Property<DateTime>(e => e.LastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
		});

		modelBuilder.Entity<ShokouhPardisFinanceFlat>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_Finance_Flat");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.CreditCardPostFixNo).HasMaxLength(16);

			entity.Property(e => e.FinanceFlatGuid).HasColumnName("Finance_FlatGuid");

			entity.Property(e => e.FinanceFlatLastModified)
				.HasColumnName("Finance_FlatLastModified")
				.HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property(e => e.PaymentCauseId)
				.HasColumnName("PaymentCauseID")
				.HasDefaultValueSql("((1))");

			entity.Property(e => e.PaymentForTermId).HasColumnName("PaymentForTermID");

			entity.Property(e => e.PaymentForYearId).HasColumnName("PaymentForYearID");

			entity.Property(e => e.PaymentTypeId)
				.HasColumnName("PaymentTypeID")
				.HasDefaultValueSql("((1))");

			entity.Property(e => e.StudentFamily).HasMaxLength(512);

			entity.Property(e => e.StudentId)
				.HasMaxLength(200)
				.HasColumnName("StudentID");

			entity.Property(e => e.StudentName).HasMaxLength(512);

			entity.Property(e => e.VerificationStatus).HasColumnName("Verification_Status");
		});

		modelBuilder.Entity<ShokouhPardisInterval>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_Interval", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.IntervalLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<int>(e => e.TermId).HasDefaultValueSql("((21))");

			entity.Property<string>(e => e.TimeInterval).HasMaxLength(200);

			entity.Property<string>(e => e.Title).HasMaxLength(200);
		});

		modelBuilder.Entity<ShokouhPardisJvfromSite>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_JVFromSite");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<string>(e => e.ApprovedBy).HasMaxLength(200);

			entity.Property<string>(e => e.CardPostfix).HasMaxLength(200);

			entity.Property<Guid>(e => e.DailyJvguid).HasColumnName("DailyJVGuid");

			entity.Property<DateTime>(e => e.DailyJvlastModified)
				.HasColumnName("DailyJVLastModified")
				.HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.Description).HasMaxLength(512);

			entity.Property<string>(e => e.FeeFor).HasMaxLength(200);

			entity.Property<string>(e => e.PhoneNumber).HasMaxLength(11);

			entity.Property<string>(e => e.StudentFamil)
				.HasMaxLength(200)
				.HasDefaultValueSql("(N'')");

			entity.Property<string>(e => e.StudentIdNumber).HasMaxLength(10);

			entity.Property<string>(e => e.StudentName)
				.HasMaxLength(200)
				.HasDefaultValueSql("(N'')");

			entity.Property<string>(e => e.Txcode)
				.HasMaxLength(15)
				.HasColumnName("TXCode");
		});

		modelBuilder.Entity<ShokouhPardisLevelBookPrice>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_LevelBookPrice");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.LevelBookPriceLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<int>(e => e.LevelId).HasColumnName("LevelID");

			entity.Property<int>(e => e.TermId).HasColumnName("TermID");
		});

		modelBuilder.Entity<ShokouhPardisLevelClass>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_LevelClass", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<int>(e => e.BookId).HasColumnName("BookID");

			entity.Property<DateTime>(e => e.LevelClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.LevelDes).HasMaxLength(512);

			entity.Property<string>(e => e.LevelName)
				.HasMaxLength(200)
				.HasDefaultValueSql("(N'')");

			entity.Property<int?>(e => e.NextLevelFk).HasColumnName("NextLevelFK");
		});

		modelBuilder.Entity<ShokouhPardisProgram>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_Program", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<int>(e => e.DaysessionId).HasColumnName("DaysessionID");

			entity.Property<DateTime>(e => e.ProgramLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<int>(e => e.ScheduleId)
				.HasColumnName("ScheduleID")
				.HasDefaultValueSql("((0))");
		});

		modelBuilder.Entity<ShokouhPardisSchedule>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_schedule", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.ScheduleLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.Title)
				.HasMaxLength(200)
				.HasDefaultValueSql("(N'')");
		});

		modelBuilder.Entity<ShokouhPardisStudentClass>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_StudentClass", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<string>(e => e.FatherJob).HasMaxLength(200);

			entity.Property<string>(e => e.FatherPhone).HasMaxLength(200);

			entity.Property<string>(e => e.HomePhone).HasMaxLength(200);

			entity.Property<string>(e => e.MotherJob).HasMaxLength(200);

			entity.Property<string>(e => e.MotherPhone).HasMaxLength(200);

			entity.Property<string>(e => e.StudentAddress).HasMaxLength(1024);

			entity.Property<DateTime>(e => e.StudentClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.StudentFamily)
				.HasMaxLength(512)
				.HasDefaultValueSql("(N'')");

			entity.Property<string>(e => e.StudentFatherName).HasMaxLength(512);

			entity.Property<string>(e => e.StudentFrom).HasMaxLength(200);

			entity.Property<string>(e => e.StudentIdno)
				.HasMaxLength(10)
				.HasColumnName("StudentIDNo")
				.HasDefaultValueSql("(N'0')");

			entity.Property<string>(e => e.StudentMotherFullName).HasMaxLength(512);

			entity.Property<string>(e => e.StudentName)
				.HasMaxLength(512)
				.HasDefaultValueSql("(N'')");

			entity.Property<string>(e => e.StudentPhone).HasMaxLength(200);

			entity.Property<int?>(e => e.StudentShno).HasColumnName("StudentSHNo");

			entity.Property<string>(e => e.WhatsAppPhone).HasMaxLength(200);
		});

		modelBuilder.Entity<ShokouhPardisStudentClassDto>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_StudentClass_Dto");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.FatherJob).HasMaxLength(200);

			entity.Property(e => e.MotherJob).HasMaxLength(200);

			entity.Property(e => e.StudentAddress).HasMaxLength(1024);

			entity.Property(e => e.StudentClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property(e => e.StudentFamily)
				.HasMaxLength(512)
				.HasDefaultValueSql("(N'')");

			entity.Property(e => e.StudentFatherName).HasMaxLength(512);

			entity.Property(e => e.StudentFrom).HasMaxLength(200);

			entity.Property(e => e.StudentIdno).HasColumnName("StudentIDNo");

			entity.Property(e => e.StudentMotherFullName).HasMaxLength(512);

			entity.Property(e => e.StudentName)
				.HasMaxLength(512)
				.HasDefaultValueSql("(N'')");

			entity.Property(e => e.StudentShno).HasColumnName("StudentSHNo");
		});

		modelBuilder.Entity<ShokouhPardisStudentClassOnlineForm>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_StudentClass_OnlineForm");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<string>(e => e.FatherJob).HasMaxLength(200);

			entity.Property<string>(e => e.FatherPhone).HasMaxLength(200);

			entity.Property<string>(e => e.HomePhone).HasMaxLength(200);

			entity.Property<bool?>(e => e.IsGirl)
				.IsRequired()
				.HasDefaultValueSql("((1))");

			entity.Property<string>(e => e.MotherJob).HasMaxLength(200);

			entity.Property<string>(e => e.MotherPhone).HasMaxLength(200);

			entity.Property<string>(e => e.StudentAddress).HasMaxLength(1024);

			entity.Property<DateTime>(e => e.StudentClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.StudentFamily)
				.HasMaxLength(512)
				.HasDefaultValueSql("(N'')");

			entity.Property<string>(e => e.StudentFatherName).HasMaxLength(512);

			entity.Property<string>(e => e.StudentFrom).HasMaxLength(200);

			entity.Property<string>(e => e.StudentIdno)
				.HasMaxLength(10)
				.HasColumnName("StudentIDNo")
				.HasDefaultValueSql("(N'0')");

			entity.Property<string>(e => e.StudentMotherFullName).HasMaxLength(512);

			entity.Property<string>(e => e.StudentName)
				.HasMaxLength(512)
				.HasDefaultValueSql("(N'')");

			entity.Property<string>(e => e.StudentPhone).HasMaxLength(200);

			entity.Property<int?>(e => e.StudentShno).HasColumnName("StudentSHNo");

			entity.Property<string>(e => e.WhatsAppPhone).HasMaxLength(200);
		});

		modelBuilder.Entity<ShokouhPardisTeacherClass>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_TeacherClass", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.TeacherClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.TeacherFamily)
				.HasMaxLength(200)
				.HasDefaultValueSql("(N'')");

			entity.Property<string>(e => e.TeacherName)
				.HasMaxLength(200)
				.HasDefaultValueSql("(N'')");

			entity.Property<string>(e => e.TeacherPic).HasMaxLength(1024);

			entity.Property<bool?>(e => e.TeacherSex)
				.IsRequired()
				.HasDefaultValueSql("((1))");

			entity.Property<int>(e => e.TermId).HasDefaultValueSql("((20))");
		});

		modelBuilder.Entity<ShokouhPardisTeacherLevel>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_TeacherLevels");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.LevelId).HasColumnName("LevelID");

			entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

			entity.Property(e => e.TeacherLevelsLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
		});

		modelBuilder.Entity<ShokouhPardisTeacherTermClass>(entity =>
		{
			entity.ToTable("ShokouhPardis_TeacherTermClass");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.LastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
		});

		modelBuilder.Entity<ShokouhPardisTeacherTimeSheet>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_TeacherTimeSheet");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<int>(e => e.IntervalId).HasColumnName("IntervalID");

			entity.Property<int>(e => e.TeacherId).HasColumnName("TeacherID");

			entity.Property<DateTime>(e => e.TeacherTimeSheetLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<int>(e => e.TermId).HasColumnName("TermID");

			entity.Property<int>(e => e.WeekDayId).HasColumnName("WeekDayID");
		});

		modelBuilder.Entity<ShokouhPardisTermClass>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_TermClass", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.TermClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.TermName).HasMaxLength(200);

			entity.Property<int>(e => e.YearId).HasColumnName("YearID");
		});

		modelBuilder.Entity<ShokouhPardisTimeTable>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_TimeTable");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<int>(e => e.LevelId).HasColumnName("LevelID");

			entity.Property<DateTime>(e => e.TimeTableLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.Title).HasMaxLength(200);
		});

		modelBuilder.Entity<ShokouhPardisTimeTableStudent>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_TimeTableStudents");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.TimeTableStudentsLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
		});

		modelBuilder.Entity<ShokouhPardisWeekDay>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_WeekDay", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<string>(e => e.Title).HasMaxLength(200);

			entity.Property<DateTime>(e => e.WeekDayLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
		});

		modelBuilder.Entity<ShokouhPardisYearClass>(entity =>
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("ShokouhPardis_YearClass", "dbo");

			entity.Property<int>(e => e.Id).HasColumnName("Id");

			entity.Property<DateTime>(e => e.YearClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

			entity.Property<string>(e => e.YearName).HasMaxLength(200);
		});

		modelBuilder.Entity<StatementMeliN>(entity =>
		{
			entity.ToTable("StatementMeliN");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.DepositAmount)
				.HasMaxLength(255)
				.HasColumnName("Deposit_Amount");

			entity.Property(e => e.Description2).HasMaxLength(255);

			entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

			entity.Property(e => e.TraceNo)
				.HasMaxLength(255)
				.HasColumnName("Trace_No");

			entity.Property(e => e.TranChannel)
				.HasMaxLength(255)
				.HasColumnName("Tran_Channel");

			entity.Property(e => e.TransactionDate).HasColumnName("Transaction_Date");

			entity.Property(e => e.TransactionTime).HasColumnName("Transaction_Time");

			entity.Property(e => e.VerificationStatus).HasColumnName("Verification_Status");
		});

		modelBuilder.Entity<StatementParsianM>(entity =>
		{
			entity.ToTable("StatementParsianM");

			entity.Property(e => e.Id).HasColumnName("Id");

			entity.Property(e => e.AgentBranch)
				.HasMaxLength(255)
				.HasColumnName("Agent_Branch");

			entity.Property(e => e.CustomerDescription)
				.HasMaxLength(255)
				.HasColumnName("Customer_Description");

			entity.Property(e => e.DepositAmount).HasColumnName("Deposit_Amount");

			entity.Property(e => e.ReferenceNumber)
				.HasMaxLength(255)
				.HasColumnName("Reference_Number");

			entity.Property(e => e.TransactionDate).HasColumnName("Transaction_Date");

			entity.Property(e => e.TransactionTime).HasColumnName("Transaction_Time");

			entity.Property(e => e.WithdrawalAmount)
				.HasMaxLength(255)
				.HasColumnName("Withdrawal_Amount");
		});


		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}