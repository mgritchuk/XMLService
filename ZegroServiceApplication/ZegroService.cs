using BLL.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZegroXMLService;

namespace ZegroServiceApplication
{
    public partial class ZegroService : Form
    {
        public ZegroService()
        {
            InitializeComponent();
			var man = new XMLManager();
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

		private void button1_Click(object sender, EventArgs e)
		{
			

		}
	}
}
