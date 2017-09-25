using BLL.Managers;
using System;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace ZegroServiceApplication
{
	public partial class ZegroService : Form
    {
		private readonly ConfigFileManager confManager;
        public ZegroService()
        {
            InitializeComponent();
			confManager = new ConfigFileManager();

			confManager.ReadConfiguration();
			HostInput.Text = confManager.Host;
			PasswordInput.Text = confManager.Password;
			UserNameInput.Text = confManager.UserName;
			FileLocationInput.Text = confManager.IngoingXMLPath;
			ApiUrlInput.Text = confManager.ApiUrl;
		}

		private void StartService_Click(object sender, EventArgs e)
		{
			//NotifyIcon 
			//new ServiceController("").Start();
			ServiceController controller = new ServiceController("ZegroService");
			if (controller != null && controller.Status != ServiceControllerStatus.Running)
			{
				
				controller.Start();
				StartService.Text = "Stop service";

			}
			else
			{
				controller.Stop();
				StartService.Text = "Start service";
			}
		}

		private void UpdateConfButton_Click(object sender, EventArgs e)
		{
			confManager.UpdateConfiguration(HostInput.Text, UserNameInput.Text, PasswordInput.Text, FileLocationInput.Text, ApiUrlInput.Text);
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			FileLocationInput.Text = folderBrowserDialog1.SelectedPath;

		}
	}
}
