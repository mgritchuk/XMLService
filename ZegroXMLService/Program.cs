using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ZegroXMLService
{
	static class Program
	{
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			//Container container = new Container();
			//container.Options.DefaultScopedLifestyle = new ExecutionContextScopeLifestyle();
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[]
			{
				new XMLService()
			};
			ServiceBase.Run(ServicesToRun);
		}
	}
}
