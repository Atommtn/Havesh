using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elsa.Activities.Console;
using Elsa.Builders;

namespace Havesh.Workflow
{
	public class SayHelloWorkflow : IWorkflow
	{
		public void Build(IWorkflowBuilder builder)
			=> builder.WriteLine("Hello World!");
	}
}
