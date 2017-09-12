using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.DTO;
using System.Threading.Tasks;
using static BLL.Managers.XMLManager;

namespace BLL.Interfaces
{
	public interface IXMLManager : IBaseManager
	{
		
		Task<IEnumerable<T>> GetItems<T>(Types type) where T : class;
	}
}
