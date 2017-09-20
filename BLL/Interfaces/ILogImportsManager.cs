using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface ILogImportsManager : IBaseManager
	{
		Task InsertInvoiceLine(ImportInvoiceLine line);


	}
}
