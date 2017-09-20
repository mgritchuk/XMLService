using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL;
using Models.DTO;
using Models.DB;


namespace BLL.Managers
{
	public class LogImportsManager : BaseManager, ILogImportsManager
	{
		public LogImportsManager(MainContext context) : base(context) { }
		
	

	}
}
