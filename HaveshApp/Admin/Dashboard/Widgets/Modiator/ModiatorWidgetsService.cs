using HaveshApp.Admin.Authentication;

namespace HaveshApp.Admin.Dashboard.Widgets.Modiator
{
	public class ModiatorWidgetsService : WidgetServiceBase
	{
		protected ModiatorWidgetsService(
			IClusterClient clusterClient,
			UserSessionService userSession) 
				: base(clusterClient, userSession)
		{
		}
	}
}
