using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface IWeekdayManagerGrain : IGrainWithGuidKey
{
	Task<List<ShokouhPardisWeekDay>>? GetWeekDays();
	Task<ShokouhPardisWeekDay>? GetTodayWeekDay(int? test_dayofweek = null);

}