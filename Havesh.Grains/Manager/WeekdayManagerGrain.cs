using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Domain.Services;
using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public class WeekdayManagerGrain : HaveshManagerGrain, IWeekdayManagerGrain
{
	DataProviderService DataProviderService { get; }

	public WeekdayManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
	}

	private List<ShokouhPardisWeekDay>? weekDays;
	private List<ShokouhPardisWeekDay> WeekDays => weekDays ??= DataProviderService.GetWeekDays();

	public async Task<List<ShokouhPardisWeekDay>?> GetWeekDays()
	{
		return WeekDays;
	}

	
	public async Task<ShokouhPardisWeekDay?> GetTodayWeekDay(int? test_dayofweek = null)
	{
		var dayOfWeek = (int)DateTime.Today.DayOfWeek;
		if (test_dayofweek is not null)
		{
			dayOfWeek = test_dayofweek.Value;
		}
		var pwdId = (dayOfWeek + 1) % 7 + 1;

		var weekDay = WeekDays.First(x => x.Id == pwdId);
		return weekDay;
	}
}