using Microsoft.JSInterop;

namespace HaveshApp.Pages.SiteTransaction;

public class MessageUpdateInvokeHelper
{
	Action action;

	public MessageUpdateInvokeHelper(Action action)
	{
		this.action = action;
	}

	[JSInvokable("BlazorSample")]
	public void UpdateMessageCaller()
	{
		action.Invoke();
	}
}