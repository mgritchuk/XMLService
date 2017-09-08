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
			#if DEBUG
			//While debugging this section is used.
			XMLService myService = new XMLService();
			myService.onDebug();
			System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

			#else
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[]
			{
				new XMLService()
			};
			ServiceBase.Run(ServicesToRun);
			#endif
		}
	}
}
