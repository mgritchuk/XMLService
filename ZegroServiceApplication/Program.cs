using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZegroServiceApplication
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AppContext());
		}
	}

	public class AppContext : ApplicationContext
	{
		Form1 configWindow = new Form1();
		public NotifyIcon trayIcon { get; set; }
		//private NotifyIcon trayIcon = new NotifyIcon();

		public AppContext()
        {
            MenuItem confMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

			trayIcon = new NotifyIcon();
			trayIcon.ContextMenu = new ContextMenu(new MenuItem[] { confMenuItem, exitMenuItem });
			trayIcon.Visible = true;
			Bitmap btmp = Properties.Resources.InActive;
			IntPtr hicon = btmp.GetHicon();
			Icon icon = Icon.FromHandle(hicon);
			trayIcon.Icon = icon;
			
		}
		
		void ShowConfig(object sender, EventArgs e)
		{
			if(configWindow.Visible)
			{
				configWindow.Activate();
			}else
			{
				configWindow.ShowDialog();
			}
		}

		void Exit(object sender, EventArgs e)
		{
			trayIcon.Visible = false;
			Application.Exit();
		}
	}


}
