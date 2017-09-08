using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DB;

namespace BLL.Managers
{
	public class XMLManager : BaseManager, IXMLManager
	{
		public XMLManager(MainContext context) : base(context)
		{
		}
	}
}
