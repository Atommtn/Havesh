using Havesh.Domain.Services;
using HaveshApp.Admin.Authentication;

namespace HaveshApp.Admin.Dashboard.Widgets.General
{
	public class GenericWidgetsService : WidgetServiceBase
	{
		protected GenericWidgetsService(
			IClusterClient clusterClient,
			UserSessionService userSession,
			DataProviderService dataProviderService)
			: base(clusterClient, userSession, dataProviderService)
		{
		}
	}
}
