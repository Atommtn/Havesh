using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Manager;
using Havesh.Grains.Entity;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Orleans.Concurrency;

namespace Havesh.Grains.Manager;

//[StatelessWorker]
public class TermManagerGrain : HaveshManagerGrain, ITermGrainManager
{
	DataProviderService DataProviderService { get; }

	public TermManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
	}

	public async Task<ShokouhPardisTermClass?> GetTermsInRangeToday(DateTime? overrideDate=null)
	{
		overrideDate ??= DateTime.Today;
		
		var term= await CacheManager.GetOrSet("Term-" + overrideDate.Value.ToShortDateString(), async () =>
			{
				var term = DataProviderService.GetTermsInRangeToday(overrideDate,
					q => q.Include(x => x.Year));
				if (term == null) 
					return null;

				var termGrain = GrainFactory.GetGrain<IHaveshGrain<ShokouhPardisTermClass>>(term.Id);
				await termGrain.Set(term);
				return term;
			}
			, CacheExpireTime);
		
		return term;

	}

}