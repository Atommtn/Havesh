using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HaveshApp.Model
{
    public partial class MyDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options , IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }


        public virtual DbSet<OnlineTeacherLink> OnlineTeacherLinks { get; set; } = null!;
        public virtual DbSet<OnlineTermTable> OnlineTermTables { get; set; } = null!;
        public virtual DbSet<PageBookCalssRecord> PageBookCalssRecords { get; set; } = null!;
        public virtual DbSet<PageBookPageType> PageBookPageTypes { get; set; } = null!;
        public virtual DbSet<ShokouhBranchNode> ShokouhBranchNodes { get; set; } = null!;
        public virtual DbSet<ShokouhPardisAccountingCode> ShokouhPardisAccountingCodes { get; set; } = null!;
        public virtual DbSet<ShokouhPardisAccountingTransaction> ShokouhPardisAccountingTransactions { get; set; } = null!;
        public virtual DbSet<ShokouhPardisBookClass> ShokouhPardisBookClasses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisClassRoom> ShokouhPardisClassRooms { get; set; } = null!;
        public virtual DbSet<ShokouhPardisCourse> ShokouhPardisCourses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisCourseStudent> ShokouhPardisCourseStudents { get; set; } = null!;
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
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=94.232.174.176;Initial Catalog=ShoukouhPardis12DB;Integrated Security=False;Persist Security Info=False;User ID=ShoukouhPardis12DBAdmin;Password=ShoukouhPardis12DB@pass;Connect Timeout=60;Encrypt=False;Current Language=English;");
                var conStr = _configuration["ConnectionStrings:ArvanConnection"];
                //optionsBuilder.UseSqlServer("Data Source=94.101.189.165;Initial Catalog=ShoukouhPardis12DB;Integrated Security=False;Persist Security Info=False;User ID=ShoukouhPardis12DBAdmin;Password=ShoukouhPardis12DB@pass;Connect Timeout=60;Encrypt=False;Current Language=English;");
                optionsBuilder.UseSqlServer(conStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ShoukouhPardis12DBAdmin")
                .UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<OnlineTeacherLink>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Online_TeacherLink");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Book).HasDefaultValueSql("(N'')");

                entity.Property(e => e.DocName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SessionNo).HasColumnName("sessionNo");

                entity.Property(e => e.Url)
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<OnlineTermTable>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Online_TermTable");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.DayOf)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.Property(e => e.Level)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NewProgram).HasMaxLength(1024);

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TimOf)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PageBookCalssRecord>(entity =>
            {
                entity.HasKey(e => e.BookCalssRecordId);

                entity.ToTable("Page_BookCalssRecord");

                entity.Property(e => e.BookCalssRecordId).HasColumnName("BookCalssRecordID");

                entity.Property(e => e.RecordUrl).HasDefaultValueSql("(N'')");

                entity.Property(e => e.SessionNo).HasMaxLength(200);

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PageBookPageType>(entity =>
            {
                entity.HasKey(e => e.BookPageTypeId);

                entity.ToTable("Page_BookPageType");

                entity.Property(e => e.BookPageTypeId).HasColumnName("BookPageTypeID");

                entity.Property(e => e.BookName)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BookType).HasMaxLength(200);
            });


            modelBuilder.Entity<ShokouhBranchNode>(entity =>
            {
                entity.HasKey(e => e.BranchNodeId);

                entity.ToTable("Shokouh_BranchNode");

                entity.Property(e => e.BranchNodeId).HasColumnName("BranchNodeID");

                entity.Property(e => e.BranchAdd).HasMaxLength(1024);

                entity.Property(e => e.BranchManager).HasMaxLength(200);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BranchPicUrl)
                    .HasMaxLength(1024)
                    .HasColumnName("branchPicUrl");

                entity.Property(e => e.BranchTel).HasMaxLength(200);

                entity.Property(e => e.BranchType)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'شعبه')");

                entity.Property(e => e.Latitude).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<ShokouhPardisAccountingCode>(entity =>
            {
                entity.HasKey(e => e.AccountingCodeId);

                entity.ToTable("ShokouhPardis_AccountingCode");

                entity.Property(e => e.AccountingCodeId).HasColumnName("AccountingCodeID");

                entity.Property(e => e.AccountingCodeLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.AccountingCodeParentId).HasColumnName("AccountingCodeParentID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.LastSq).HasColumnName("LastSQ");

                entity.Property(e => e.Title).HasMaxLength(512);
            });

            modelBuilder.Entity<ShokouhPardisAccountingTransaction>(entity =>
            {
                entity.HasKey(e => e.AccountingTransactionId);

                entity.ToTable("ShokouhPardis_AccountingTransaction");

                entity.Property(e => e.AccountingTransactionId).HasColumnName("AccountingTransactionID");

                entity.Property(e => e.AccountingTransactionLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.ShortTxKey).HasMaxLength(512);
            });

            modelBuilder.Entity<ShokouhPardisBookClass>(entity =>
            {
                entity.HasKey(e => e.BookClassId);

                entity.ToTable("ShokouhPardis_BookClass", "dbo");

                entity.Property(e => e.BookClassId).HasColumnName("BookClassID");

                entity.Property(e => e.BookClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.BookDes).HasMaxLength(200);

                entity.Property(e => e.BookName).HasMaxLength(200);

                entity.Property(e => e.BookPic).HasMaxLength(1024);
            });

            modelBuilder.Entity<ShokouhPardisClassRoom>(entity =>
            {
                entity.HasKey(e => e.ClassRoomId);

                entity.ToTable("ShokouhPardis_ClassRoom", "dbo");

                entity.Property(e => e.ClassRoomId).HasColumnName("ClassRoomID");

                entity.Property(e => e.ClassRoomLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.ClassRoomName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ShokouhPardisCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("ShokouhPardis_Course", "dbo");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.ClassRoomId).HasColumnName("ClassRoomID");

                entity.Property(e => e.CourseLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.CourseTitle).HasMaxLength(200);

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TermId).HasColumnName("TermID");
            });

            modelBuilder.Entity<ShokouhPardisCourseStudent>(entity =>
            {
                entity.HasKey(e => e.CourseStudentId);

                entity.ToTable("ShokouhPardis_CourseStudent", "dbo");

                entity.Property(e => e.CourseStudentId).HasColumnName("CourseStudentID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseStudentLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<ShokouhPardisDailyJv>(entity =>
            {
                entity.HasKey(e => e.DailyJvid);

                entity.ToTable("ShokouhPardis_DailyJV");

                entity.Property(e => e.DailyJvid).HasColumnName("DailyJVID");

                entity.Property(e => e.CardPostfix).HasMaxLength(200);

                entity.Property(e => e.DailyJvguid).HasColumnName("DailyJVGuid");

                entity.Property(e => e.DailyJvlastModified)
                    .HasColumnName("DailyJVLastModified")
                    .HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.FeeFor).HasMaxLength(200);

                entity.Property(e => e.PaymentType).HasMaxLength(200);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Txcode)
                    .HasMaxLength(15)
                    .HasColumnName("TXCode");
            });

            modelBuilder.Entity<ShokouhPardisDaySession>(entity =>
            {
                entity.HasKey(e => e.DaySessionId);

                entity.ToTable("ShokouhPardis_DaySession", "dbo");

                entity.Property(e => e.DaySessionId).HasColumnName("DaySessionID");

                entity.Property(e => e.DaySessionLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.IntervalId).HasColumnName("IntervalID");

                entity.Property(e => e.WeekdayId).HasColumnName("WeekdayID");
            });

            modelBuilder.Entity<ShokouhPardisEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("ShokouhPardis_Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisFileAttachment>(entity =>
            {
                entity.ToTable("ShokouhPardis_FileAttachment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName).HasMaxLength(512);

                entity.Property(e => e.FileTitle).HasMaxLength(512);

                entity.Property(e => e.Folder).HasMaxLength(512);

                entity.Property(e => e.LastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisFinanceFlat>(entity =>
            {
                entity.HasKey(e => e.FinanceFlatId);

                entity.ToTable("ShokouhPardis_Finance_Flat");

                entity.Property(e => e.FinanceFlatId).HasColumnName("Finance_FlatID");

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
                entity.HasKey(e => e.IntervalId);

                entity.ToTable("ShokouhPardis_Interval", "dbo");

                entity.Property(e => e.IntervalId).HasColumnName("IntervalID");

                entity.Property(e => e.IntervalLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TermId).HasDefaultValueSql("((21))");

                entity.Property(e => e.TimeInterval).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisJvfromSite>(entity =>
            {
                entity.HasKey(e => e.DailyJvid);

                entity.ToTable("ShokouhPardis_JVFromSite");

                entity.Property(e => e.DailyJvid).HasColumnName("DailyJVID");

                entity.Property(e => e.ApprovedBy).HasMaxLength(200);

                entity.Property(e => e.CardPostfix).HasMaxLength(200);

                entity.Property(e => e.DailyJvguid).HasColumnName("DailyJVGuid");

                entity.Property(e => e.DailyJvlastModified)
                    .HasColumnName("DailyJVLastModified")
                    .HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.FeeFor).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.StudentFamil)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentIdNumber).HasMaxLength(10);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Txcode)
                    .HasMaxLength(15)
                    .HasColumnName("TXCode");
            });

            modelBuilder.Entity<ShokouhPardisLevelBookPrice>(entity =>
            {
                entity.HasKey(e => e.LevelBookPriceId);

                entity.ToTable("ShokouhPardis_LevelBookPrice");

                entity.Property(e => e.LevelBookPriceId).HasColumnName("LevelBookPriceID");

                entity.Property(e => e.LevelBookPriceLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.TermId).HasColumnName("TermID");
            });

            modelBuilder.Entity<ShokouhPardisLevelClass>(entity =>
            {
                entity.HasKey(e => e.LevelClassId);

                entity.ToTable("ShokouhPardis_LevelClass", "dbo");

                entity.Property(e => e.LevelClassId).HasColumnName("LevelClassID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.LevelClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.LevelDes).HasMaxLength(512);

                entity.Property(e => e.LevelName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NextLevelFk).HasColumnName("NextLevelFK");
            });

            modelBuilder.Entity<ShokouhPardisProgram>(entity =>
            {
                entity.HasKey(e => e.ProgramId);

                entity.ToTable("ShokouhPardis_Program", "dbo");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.DaysessionId).HasColumnName("DaysessionID");

                entity.Property(e => e.ProgramLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("ScheduleID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ShokouhPardisSchedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleId);

                entity.ToTable("ShokouhPardis_schedule", "dbo");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.ScheduleLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ShokouhPardisStudentClass>(entity =>
            {
                entity.HasKey(e => e.StudentClassId);

                entity.ToTable("ShokouhPardis_StudentClass", "dbo");

                entity.Property(e => e.StudentClassId).HasColumnName("StudentClassID");

                entity.Property(e => e.FatherJob).HasMaxLength(200);

                entity.Property(e => e.FatherPhone).HasMaxLength(200);

                entity.Property(e => e.HomePhone).HasMaxLength(200);

                entity.Property(e => e.MotherJob).HasMaxLength(200);

                entity.Property(e => e.MotherPhone).HasMaxLength(200);

                entity.Property(e => e.StudentAddress).HasMaxLength(1024);

                entity.Property(e => e.StudentClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.StudentFamily)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentFatherName).HasMaxLength(512);

                entity.Property(e => e.StudentFrom).HasMaxLength(200);

                entity.Property(e => e.StudentIdno)
                    .HasMaxLength(10)
                    .HasColumnName("StudentIDNo")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.StudentMotherFullName).HasMaxLength(512);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentPhone).HasMaxLength(200);

                entity.Property(e => e.StudentShno).HasColumnName("StudentSHNo");

                entity.Property(e => e.WhatsAppPhone).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisStudentClassDto>(entity =>
            {
                entity.HasKey(e => e.StudentClassId);

                entity.ToTable("ShokouhPardis_StudentClass_Dto");

                entity.Property(e => e.StudentClassId).HasColumnName("StudentClassID");

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
                entity.HasKey(e => e.StudentClassId);

                entity.ToTable("ShokouhPardis_StudentClass_OnlineForm");

                entity.Property(e => e.StudentClassId).HasColumnName("StudentClassID");

                entity.Property(e => e.FatherJob).HasMaxLength(200);

                entity.Property(e => e.FatherPhone).HasMaxLength(200);

                entity.Property(e => e.HomePhone).HasMaxLength(200);

                entity.Property(e => e.IsGirl)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MotherJob).HasMaxLength(200);

                entity.Property(e => e.MotherPhone).HasMaxLength(200);

                entity.Property(e => e.StudentAddress).HasMaxLength(1024);

                entity.Property(e => e.StudentClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.StudentFamily)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentFatherName).HasMaxLength(512);

                entity.Property(e => e.StudentFrom).HasMaxLength(200);

                entity.Property(e => e.StudentIdno)
                    .HasMaxLength(10)
                    .HasColumnName("StudentIDNo")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.StudentMotherFullName).HasMaxLength(512);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentPhone).HasMaxLength(200);

                entity.Property(e => e.StudentShno).HasColumnName("StudentSHNo");

                entity.Property(e => e.WhatsAppPhone).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisTeacherClass>(entity =>
            {
                entity.HasKey(e => e.TeacherClassId);

                entity.ToTable("ShokouhPardis_TeacherClass", "dbo");

                entity.Property(e => e.TeacherClassId).HasColumnName("TeacherClassID");

                entity.Property(e => e.TeacherClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TeacherFamily)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TeacherPic).HasMaxLength(1024);

                entity.Property(e => e.TeacherSex)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TermId).HasDefaultValueSql("((20))");
            });

            modelBuilder.Entity<ShokouhPardisTeacherLevel>(entity =>
            {
                entity.HasKey(e => e.TeacherLevelsId);

                entity.ToTable("ShokouhPardis_TeacherLevels");

                entity.Property(e => e.TeacherLevelsId).HasColumnName("TeacherLevelsID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TeacherLevelsLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisTeacherTermClass>(entity =>
            {
                entity.ToTable("ShokouhPardis_TeacherTermClass");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisTeacherTimeSheet>(entity =>
            {
                entity.HasKey(e => e.TeacherTimeSheetId);

                entity.ToTable("ShokouhPardis_TeacherTimeSheet");

                entity.Property(e => e.TeacherTimeSheetId).HasColumnName("TeacherTimeSheetID");

                entity.Property(e => e.IntervalId).HasColumnName("IntervalID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TeacherTimeSheetLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.Property(e => e.WeekDayId).HasColumnName("WeekDayID");
            });

            modelBuilder.Entity<ShokouhPardisTermClass>(entity =>
            {
                entity.HasKey(e => e.TermClassId);

                entity.ToTable("ShokouhPardis_TermClass", "dbo");

                entity.Property(e => e.TermClassId).HasColumnName("TermClassID");

                entity.Property(e => e.TermClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TermName).HasMaxLength(200);

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<ShokouhPardisTimeTable>(entity =>
            {
                entity.HasKey(e => e.TimeTableId);

                entity.ToTable("ShokouhPardis_TimeTable");

                entity.Property(e => e.TimeTableId).HasColumnName("TimeTableID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.TimeTableLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisTimeTableStudent>(entity =>
            {
                entity.HasKey(e => e.TimeTableStudentsId);

                entity.ToTable("ShokouhPardis_TimeTableStudents");

                entity.Property(e => e.TimeTableStudentsId).HasColumnName("TimeTableStudentsID");

                entity.Property(e => e.TimeTableStudentsLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisWeekDay>(entity =>
            {
                entity.HasKey(e => e.WeekDayId);

                entity.ToTable("ShokouhPardis_WeekDay", "dbo");

                entity.Property(e => e.WeekDayId).HasColumnName("WeekDayID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.WeekDayLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisYearClass>(entity =>
            {
                entity.HasKey(e => e.YearClassId);

                entity.ToTable("ShokouhPardis_YearClass", "dbo");

                entity.Property(e => e.YearClassId).HasColumnName("YearClassID");

                entity.Property(e => e.YearClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.YearName).HasMaxLength(200);
            });

            modelBuilder.Entity<StatementMeliN>(entity =>
            {
                entity.ToTable("StatementMeliN");

                entity.Property(e => e.Id).HasColumnName("ID");

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

                entity.Property(e => e.Id).HasColumnName("ID");

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
}
