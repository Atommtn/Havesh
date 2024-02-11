using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace Ins.Havesh.ReactiveUI.Blazor.Financial
{
	public class DailyJsRecordListViewModel : ReactiveObject , IActivatableViewModel
	{
		public ViewModelActivator Activator { get; } = new ViewModelActivator();
	}
}
