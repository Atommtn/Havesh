using HaveshApp.Admin.Authentication;

namespace HaveshApp.Admin.Dashboard.Widgets.Admin
{
	public class AdminWidgetsService : WidgetServiceBase
	{
		protected AdminWidgetsService(
			IClusterClient clusterClient,
			UserSessionService userSession) 
				: base(clusterClient, userSession)
		{
		}
	}
}
