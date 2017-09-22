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
        public ZegroService()
        {
            InitializeComponent();
			//var man = new XMLManager();
			//folderBrowserDialog1.ShowDialog();

			if (!File.Exists("C:\\config.ini"))
			{
				var parser = new FileIniDataParser();

				SectionDataCollection collection = new SectionDataCollection();
				var section1 = new SectionData("FTPPath");
				section1.Keys.AddKey(new KeyData("host"));
				collection.Add(section1);
				collection["FTPPath"]["host"] = "test";

				var section2 = new SectionData("Credentials");
				section1.Keys.AddKey(new KeyData("name"));
				section1.Keys.AddKey(new KeyData("pwd"));
				collection.Add(section2);
				collection["Credentials"]["name"] = "test";
				collection["Credentials"]["pwd"] = "test";

				var section3 = new SectionData("IngoingXML");
				section1.Keys.AddKey(new KeyData("path"));
				
				collection.Add(section3);
				collection["IngoingXML"]["path"] = "test";

				IniData data = new IniData(collection);
				parser.WriteFile("C:\\config.ini", data);
				//host = data["FTPPath"]["host"];
				//userName = data["Credentials"]["name"];
				//pwd = data["Credentials"]["pwd"];

				//path = data["IngoingXML"]["path"];
			}
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

		
	}
}
