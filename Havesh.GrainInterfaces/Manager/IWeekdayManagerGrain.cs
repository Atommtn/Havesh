using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface IWeekdayManagerGrain : IGrainWithGuidCompoundKey
{
	Task<List<ShokouhPardisWeekDay>?> GetWeekDays();
	Task<ShokouhPardisWeekDay?> GetTodayWeekDay(int? test_dayofweek = null);

}