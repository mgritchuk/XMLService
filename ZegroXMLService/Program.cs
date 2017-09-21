using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Reflection;
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













			// ServiceController ctl = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == "Service1");
			//if (ctl != null)
			//	ManagedInstallerClass.InstallHelper(new string[] { "/u", Assembly.GetExecutingAssembly().Location });
			//ctl = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == "Service1");
			//if (ctl == null)
			//	ManagedInstallerClass.InstallHelper(new string[] { Assembly.GetExecutingAssembly().Location });
			//ServiceController controller = new ServiceController("Service1");
			//if (controller.Status.ToString() != "Running")
			//{
			//	controller.Start();
			//	controller.WaitForStatus(ServiceControllerStatus.Running);
			//}

		}
	}
}
