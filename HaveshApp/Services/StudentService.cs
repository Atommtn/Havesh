using Microsoft.EntityFrameworkCore;
using Olive;
using HaveshApp.Classes;
using System.Xml;
using System.Linq;
using Serilog; 
using Havesh.Application.Services;
using Havesh.Model.Model;
using HaveshApp.Admin.Authentication;
using HaveshApp.Admin.Student;

namespace Havesh.Domain.Services;

public class StudentService
{
	readonly MyDbContext _dbConntext;
	readonly UserSessionService _userSession;
	public StudentService(MyDbContextFactory dbConntextFactory,UserSessionService userSession )
	{
		var branchName = Environment.GetEnvironmentVariable("BranchName")!;
		_userSession = userSession;
		_dbConntext = dbConntextFactory.CreateDbContextForBranch(branchName);
	}

	public List<ShokouhPardisStudentClass> GetStudents()
	{
		var list = _dbConntext.ShokouhPardisStudentClasses.ToList();
		return list;
	}


	public int GetTotalStudentCount( List<int?>? studentIds = null)
	{
		var iQ = _dbConntext.ShokouhPardisStudentClasses.AsQueryable();
		if (studentIds is { })
		{
			iQ = iQ.Where(x => studentIds.Contains(x.Id));
		}
            
		return iQ.Count();
	}

	public List<ShokouhPardisStudentClass> GetStudentPaged(int page, int size, string? searchText,
		List<int?>? studentIds = null)
	{
		var queryable = _dbConntext.ShokouhPardisStudentClasses.AsQueryable();
		if (studentIds is { })
		{
			queryable = queryable.Where(x => studentIds.Contains(x.Id));
		}

           
		if (searchText is not null)
		{
			var words = searchText.Trim().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var word in words)
			{
				queryable = queryable.Where(x => x.StudentName.Contains(word) ||
				                                 x.StudentFamily.Contains(word) ||
				                                 x.StudentPhone.Contains(word) ||
				                                 x.FatherPhone.Contains(word) ||
				                                 x.MotherPhone.Contains(word) ||
				                                 x.HomePhone.Contains(word) ||
				                                 x.StudentIdno.Contains(word) ||
				                                 x.StudentMotherFullName.Contains(word));

			}
		}
		var list = queryable

			.Skip(page * size).Take(size).ToList();
		return list;
	}

	public void SaveStudent(ShokouhPardisStudentClass student)
	{
		bool isNew = student.Id <= 0;
		student.StudentClassLastModified = DateTime.Now;
		_dbConntext.ShokouhPardisStudentClasses.Update(student);
		_dbConntext.SaveChanges();
		Serilog.Log.ForContext("Activity", true).ForContext("EntityType", "Student").ForContext("EntityId", student.Id)
			.Warning("User {UserName} {Action} Student {StudentId} ({StudentName} {StudentFamily})",
				_userSession.Payload?.UserName, isNew ? "Created" : "Updated", student.Id, student.StudentName, student.StudentFamily);
	}

	public int GetStudentsInTimeTableCount(ShokouhPardisTimeTable timeTable)
	{
		var students = GetStudentInTimeTableQuery(timeTable);
            
		return students.Count();
	}

	public List<ShokouhPardisStudentClass> GetStudentsInTimeTable(int timeTableId)
	{
		var students = GetStudentInTimeTableQuery(timeTableId);

		var data = students.Select(x => x.Student)
			.ToList();
		return data;
	}

	public List<ShokouhPardisStudentClass> GetStudentsInTimeTable(ShokouhPardisTimeTable timeTable)
	{
		return GetStudentsInTimeTable(timeTable.Id);
	}

	public List<ShokouhPardisStudentClass> GetStudentsInTimeTablePaged(ShokouhPardisTimeTable timeTable, int page,
		int pageSize, string? searchText)
	{
		var students = GetStudentInTimeTableQuery(timeTable, searchText);
            
		var data = students
			.Skip(page * pageSize)
			.Take(pageSize)
			.Select(x => x.Student)
			.ToList();
		return data;
	}

	IQueryable<ShokouhPardisTimeTableStudent> GetStudentInTimeTableQuery(int timeTableId)
	{
		var students = _dbConntext
			.ShokouhPardisTimeTableStudents
			.Include(x => x.Student)
			.Where(x => x.TimeTableId == timeTableId);
		return students;
	}
	IQueryable<ShokouhPardisTimeTableStudent> GetStudentInTimeTableQuery(ShokouhPardisTimeTable timeTable)
	{
		return GetStudentInTimeTableQuery(timeTable.Id);
	}
	IQueryable<ShokouhPardisTimeTableStudent> GetStudentInTimeTableQuery(ShokouhPardisTimeTable timeTable, string? searchText)
	{
		var queryable = _dbConntext
			.ShokouhPardisTimeTableStudents
			.Include(x => x.Student)
			.Where(x => x.TimeTableId == timeTable.Id);
		if (searchText is not null)
		{
			queryable = queryable.Where(x => x.Student.StudentName.Contains(searchText) ||
			                                 x.Student.StudentFamily.Contains(searchText) ||
			                                 (x.Student.StudentPhone != null && x.Student.StudentPhone.Contains(searchText)) ||
			                                 (x.Student.FatherPhone != null && x.Student.FatherPhone.Contains(searchText)) ||
			                                 (x.Student.MotherPhone != null && x.Student.MotherPhone.Contains(searchText)) ||
			                                 (x.Student.HomePhone != null && x.Student.HomePhone.Contains(searchText)) ||
			                                 (x.Student.StudentIdno != null && x.Student.StudentIdno.Contains(searchText)) ||
			                                 (x.Student.StudentMotherFullName != null && x.Student.StudentMotherFullName.Contains(searchText)));
		}
		return queryable;
           
	}
	public bool IsDuplicatedStudent(ShokouhPardisStudentClass student, int stuId = 0)
	{
		var iQueryable = _dbConntext.ShokouhPardisStudentClasses
			.Where(x =>
				x.StudentName.Contains(student.StudentName) &&
				x.StudentFamily.Contains(student.StudentFamily));
		if (student.StudentFatherName is { })
			iQueryable = iQueryable.Where(x => x.StudentFatherName.Contains(student.StudentFatherName));
		var result = iQueryable.ToList();

		if (!result.Any()) return false;

		if (result.Count == 1 && result.First().Id == stuId) return false;

		return true;
	}

	public void DeleteStudent(ShokouhPardisStudentClass student)
	{
		_dbConntext.ShokouhPardisStudentClasses.Remove(student);
		_dbConntext.SaveChanges();

		Serilog.Log.ForContext("Activity", true).ForContext("EntityType", "Student").ForContext("EntityId", student.Id)
			.Warning("User {UserName} Deleted Student {StudentId} ({StudentName} {StudentFamily})",_userSession.Payload?.UserName, student.Id, student.StudentName, student.StudentFamily);
		
	}
	public List<ShokouhPardisStudentClassOnlineForm> GetStudentsprofile()
	{

		var list = _dbConntext.ShokouhPardisStudentClassOnlineForms.ToList();
		return list;
	}

	public int GetTotalStudentsProfile(List<int> studentIds = null)
	{
		var iQ = _dbConntext.ShokouhPardisStudentClassOnlineForms.AsQueryable();
		if (studentIds is { })
		{
			iQ = iQ.Where(x => studentIds.Contains(x.Id));
		}
		return iQ.Count();
	}

	public List<ShokouhPardisStudentClassOnlineForm> GetPagedStudentProfile(int page, int size, string? searchText, List<int> studentIds)
	{

		var queryable = _dbConntext.ShokouhPardisStudentClassOnlineForms.AsQueryable();
		if (studentIds is { })
		{
			queryable = queryable.Where(x => studentIds.Contains(x.Id));
		}
		if (searchText is not null)
		{
			queryable = queryable.Where(x => x.StudentName.Contains(searchText) ||
			                                 x.StudentFamily.Contains(searchText) ||
			                                 x.StudentPhone.Contains(searchText) ||
			                                 x.FatherPhone.Contains(searchText) ||
			                                 x.MotherPhone.Contains(searchText) ||
			                                 x.HomePhone.Contains(searchText) ||
			                                 x.StudentAddress.Contains(searchText) ||
			                                 x.StudentMotherFullName.Contains(searchText));
		}
		var list = queryable.Skip(page * size).Take(size).ToList();
		return list;
	}

	public void SaveOnlineProfile(ShokouhPardisStudentClassOnlineForm student)
	{
		_dbConntext.ShokouhPardisStudentClassOnlineForms.Update(student);
		_dbConntext.SaveChanges();
	}

	public int GetStudentsInTermCount(ShokouhPardisTermClass term, string? search, bool hasnotIdNo)
	{
		var count = StudentsInTermQuery(term, search, hasnotIdNo).Count();
		return count;

	}
	public List<ShokouhPardisStudentClass> GetStudentsInTerm(ShokouhPardisTermClass term, string? search)
	{
		var students = StudentsInTermQuery(term,search,false);
		var data = students
			.Select(x => x.Student)
			.ToList();
		return data;

	}
	public List<ShokouhPardisStudentClass> GetStudentsInTermPaged(ShokouhPardisTermClass term, int page,
		int pageSize, string? search, bool hasnotIdNo)
	{
		var students = StudentsInTermQuery(term, search, hasnotIdNo);
		var data = students
			.Skip(page * pageSize)
			.Take(pageSize)
			.Select(x => x.Student)
			.ToList();
		return data;

	}

	IQueryable<ShokouhPardisTimeTableStudent> StudentsInTermQuery(ShokouhPardisTermClass term,string? searchText,bool hasnotIdNo)
	{
		var queryable = _dbConntext
				.ShokouhPardisTimeTableStudents
				.Include(x => x.Student)
				.Include(x => x.TimeTable)
				.ThenInclude(x => x.Term)
				.Where(x => x.TimeTable.Term.Id == term.Id)
			;
		if (searchText is not null)
		{
			queryable = queryable.Where(x => x.Student.StudentName.Contains(searchText) ||
			                                 x.Student.StudentFamily.Contains(searchText) ||
			                                 (x.Student.StudentPhone != null && x.Student.StudentPhone.Contains(searchText)) ||
			                                 (x.Student.FatherPhone != null && x.Student.FatherPhone.Contains(searchText)) ||
			                                 (x.Student.MotherPhone !=null && x.Student.MotherPhone.Contains(searchText)) ||
			                                 (x.Student.HomePhone !=null && x.Student.HomePhone.Contains(searchText)) ||
			                                 (x.Student.StudentIdno !=null && x.Student.StudentIdno.Contains(searchText)) ||
			                                 (x.Student.StudentMotherFullName!=null && x.Student.StudentMotherFullName.Contains(searchText)));
		}
		if (hasnotIdNo)
		{
			queryable = queryable.Where(x => x.Student.StudentIdno.Length <= 9);
		}
		return queryable;
	}

	public int GetTotalPreRegisterStudentCount(ShokouhPardisTimeTable tt)
	{
		var iQ = _dbConntext.PreRegistrations.AsQueryable();
		if (tt.Level is { })
		{
			iQ = iQ.Where(x => (x.IsArchive == null || x.IsArchive == false) &&
			                   x.Level.Id == tt.Level.Id);
		}
		return iQ.Count();
	}
    public int GetTotalPreRegisterStudentCount(ShokouhPardisTermClass term)
    {
        return _dbConntext.ShokouhPardisDailyJvs.Count(x => (x.IsPreRegister == true) && x.TermId == term.Id);
    }
    public List<ShokouhPardisStudentClass> GetPreRegisterStudentPaged(int page, int size, string? searchText, ShokouhPardisTermClass term)
    {

        IQueryable<ShokouhPardisStudentClass?> queryable = _dbConntext.ShokouhPardisDailyJvs
            .Include(x => x.Student)
            .Where(x => x.TermId == term.Id && x.IsPreRegister == true)
            .Select(x => x.Student).AsQueryable();

        if (searchText is not null)
        {
            var words = searchText.Trim().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                queryable = queryable.Where(x => x.StudentName.Contains(word) ||
                                                 x.StudentFamily.Contains(word) ||
                                                 x.StudentPhone.Contains(word) ||
                                                 x.FatherPhone.Contains(word) ||
                                                 x.MotherPhone.Contains(word) ||
                                                 x.HomePhone.Contains(word) ||
                                                 x.StudentIdno.Contains(word) ||
                                                 x.StudentMotherFullName.Contains(word));

            }
        }
        var list = queryable.Skip(page * size).Take(size).ToList();
        return list;
    }
    public List<ShokouhPardisStudentClass> GetPreRegisterStudentPaged(int page, int size, string? searchText, ShokouhPardisTimeTable tt)
	{


		IQueryable<ShokouhPardisStudentClass> queryable = _dbConntext.PreRegistrations
			.Include(x => x.Student)
			.Where(x => (x.IsArchive == null || x.IsArchive == false) &&
			            x.LevelFk == tt.Level.Id &&
			            x.TermFk == tt.TermId)
			.Select(x => x.Student).AsQueryable();
            
		if (searchText is not null)
		{
			var words = searchText.Trim().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var word in words)
			{
				queryable = queryable.Where(x => x.StudentName.Contains(word) ||
				                                 x.StudentFamily.Contains(word) ||
				                                 x.StudentPhone.Contains(word) ||
				                                 x.FatherPhone.Contains(word) ||
				                                 x.MotherPhone.Contains(word) ||
				                                 x.HomePhone.Contains(word) ||
				                                 x.StudentIdno.Contains(word) ||
				                                 x.StudentMotherFullName.Contains(word));

			}
		}
		var list = queryable.Skip(page * size).Take(size).ToList();
		return list;
	}

    public FollowUp GetFollowUp(ShokouhPardisStudentClass student)
    {
		//_dbConntext.FollowUp
        throw new NotImplementedException();
    }
}