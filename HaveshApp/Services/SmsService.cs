using DNTPersianUtils.Core;
using Havesh.Model.Model;
using Olive;
using RestSharp;
using PersianDate.Standard;

namespace Havesh.Domain.Services;

public class SmsService
{
	public bool SendSms(string phoneNumber, string message)
	{
		using var client = new RestClient("https://panel.asanak.com/webservice/v1rest/sendsms");
		var request = new RestRequest("", Method.Post);
		request.AddParameter("application/x-www-form-urlencoded",
			$"username=m.tayefenafar@3824&password=Atomtneda&source=982176283824&" +
			$"destination={phoneNumber}&message={message}", ParameterType.RequestBody);

		var response = client.Execute(request);
		return response.IsSuccessful;
	}

	public string GetSessionCancelText()
	{
		return "";
	}

	public string GetSessionCancelText(TimeTableSession orig, TimeTableSession repl, string? causeItem = null,
		string causeText = null)
	{
		string? x = null;
		if (causeItem.HasValue())
		{
			x = "بعلت " + causeItem;
			if (causeText.HasValue())
				x += "(" + causeText + ")";
		}

		string? y = null;

		if (orig.SessionTime == repl.SessionTime)
			y = "همان ساعت";
		else
			y = "ساعت " + repl.SessionTime.ToString("hh\\:mm");

		return $"جلسه مورخ {orig.SessionDate.ToFa("D")} {x} به تاریخ {repl.SessionDate.ToFa("D")} {y} موکول گردید";
	}

	public string? GetSessionCancelText(DateTime? origSessionDate, TimeSpan? intervalStartTime,
		DateTime? replSessionDate, TimeSpan? replSessionTime, string? causeItem, string? causeText)
	{
		string? x = null;
		if (causeItem.HasValue())
		{
			x = "بعلت " + causeItem;
			if (causeText.HasValue())
				x += "(" + causeText + ")";
		}

		string? y = null;

		if (intervalStartTime is null || intervalStartTime == replSessionTime)
			y = "همان ساعت";
		else
			y = "ساعت " + replSessionTime.ToString("hh\\:mm");

		return $"جلسه مورخ {origSessionDate.ToFa("D")} {x} به تاریخ {replSessionDate.ToFa("D")} {y} موکول گردید";

	}
}