using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Havesh.Model.Model;
using Olive;


namespace HaveshApp.Services;

public class DataProviderAsyncService
{
	readonly MyDbContext _dbConntext;

	public DataProviderAsyncService(MyDbContext dbConntext)
	{
		_dbConntext = dbConntext;
	}
	public async Task<List<ShokouhPardisYearClass>> GetYearsAsync()
	{
		return await _dbConntext.ShokouhPardisYearClasses.Include(x => x.Terms).ToListAsync();
	}

	public async Task<List<ShokouhPardisTermClass>> GetTermsAsync(ShokouhPardisYearClass year)
	{
		return await _dbConntext.ShokouhPardisTermClasses.Where(x => x.YearId == year.YearClassId).ToListAsync();
	}

	public async Task<int> GetTotalTimeTablesCount(int termTermClassId , bool isPrivate = false)
	{
		var count = await _dbConntext.ShokouhPardisTimeTables.Where(x=>
			x.TermId == termTermClassId  && x.IsPrivate == isPrivate).CountAsync();
		return count;
	}

	public async Task<IEnumerable<ShokouhPardisTimeTable>>
		GetTimeTablesAsync(int statePage, int statePageSize, string? searchText,
			ShokouhPardisTermClass term)
	{
		var queryable = _dbConntext
			.ShokouhPardisTimeTables

			.Include(x => x.Term)
			.ThenInclude(x => x.Year)
			.ThenInclude(x => x.Terms)

			.Include(x => x.Schedule)
			.ThenInclude(x => x.Programs)
			.ThenInclude(x => x.DaySession)
			.ThenInclude(x => x.Interval)

			.Include(x => x.Schedule)
			.ThenInclude(x => x.Programs)
			.ThenInclude(x => x.DaySession)
			.ThenInclude(x => x.WeekDay)

			.Include(x => x.Level)
                
			.Include(x => x.ClassRoom)

			.Include(x => x.Teacher)
			//.AsQueryable()
			.Where(x => x.TermId == term.TermClassId);
		if (searchText.IsEmpty())
		{
			queryable = queryable.Where(x =>
				x.Teacher.TeacherName.Contains(searchText) ||
				x.Teacher.TeacherFamily.Contains(searchText) ||
				(x.Term.TermName != null && x.Term.TermName.Contains(searchText)) ||
				x.Schedule.Title.Contains(searchText) ||
				x.Level.LevelName.Contains(searchText)
			);
		}
		return await queryable.Skip(statePage * statePageSize).Take(statePageSize).ToListAsync();
	}
	public async Task<ShokouhPardisYearClass> GetYearsInRangeAsync()
	{
		var pc = new PersianCalendar();
		var shamsiYear = pc.GetYear(DateTime.Today);

		var year = _dbConntext.ShokouhPardisYearClasses.AsQueryable();
		return await year.FirstAsync(x => x.YearName == shamsiYear.ToString());
	}

	public async Task<ShokouhPardisTermClass> GetTermsInRangeTodayAsync()
	{
		//dateToCheck >= startDate && dateToCheck < endDate;
		var term = _dbConntext.ShokouhPardisTermClasses.AsQueryable();
		return await term.FirstAsync(x => x.StartDate <= DateTime.Today &&
		                                  x.EndDate >= DateTime.Today);
	}
	public async Task<Dictionary<int, int>> GetTimeTableStudentsCount(ShokouhPardisTermClass term)
	{
		var xx = await _dbConntext.ShokouhPardisTimeTableStudents
			.Include(x=>x.TimeTable)
			.Where(x=>x.TimeTable.TermId == term.TermClassId)
			.GroupBy(x => ((int)x.TimeTableId)!)
			.Select(group => new
			{
				g = group.Key,
				Count = group.Count()
			})
			.ToDictionaryAsync(k => k.g, x => x.Count!);
		return xx;
	}
	public async Task<bool> CloneBookPriceAsync(ShokouhPardisTermClass SourceTerm, ShokouhPardisTermClass DestinationTerm)
	{
		await using var transaction = await _dbConntext.Database.BeginTransactionAsync();
		await transaction.CreateSavepointAsync("BeforeSave");

		try
		{
			var list =
				_dbConntext.ShokouhPardisLevelBookPrices
					.Where(x => x.TermId == SourceTerm.TermClassId)
					.Select(price => new ShokouhPardisLevelBookPrice
					{
						BookPrice = price.BookPrice,
						TermId = DestinationTerm.TermClassId,
						LevelId = price.LevelId,
						TuitionAmount = price.TuitionAmount,
						LevelBookPriceGuid = Guid.NewGuid(),
						LevelBookPriceLastModified = DateTime.Now
					})
					.ToList();
			await _dbConntext.AddRangeAsync(list);
			await _dbConntext.SaveChangesAsync();
			await transaction.CommitAsync();
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			await transaction.ReleaseSavepointAsync("BeforeSave");
			return false;
		}

		return true;
	}



}