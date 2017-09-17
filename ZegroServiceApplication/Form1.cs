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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void StartService_Click(object sender, EventArgs e)
		{
			//new ServiceController("").Start();
			ServiceController controller = new ServiceController("ZegroService");
			if (controller != null && controller.Status.ToString() != "Running")
			{
				controller.Start();

			}
		}
	}
}
