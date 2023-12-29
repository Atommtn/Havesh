using Havesh.Domain.Services;
using HaveshApp.Admin.Authentication;

namespace HaveshApp.Admin.Dashboard.Widgets.Admin
{
	public class AdminWidgetsService : WidgetServiceBase
	{
		protected AdminWidgetsService(
			IClusterClient clusterClient,
			UserSessionService userSession,
			DataProviderService dataProviderService) 
				: base(clusterClient, userSession , dataProviderService)
		{
		}
	}
}
