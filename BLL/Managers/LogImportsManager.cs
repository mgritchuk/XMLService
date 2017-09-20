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
		
		public async Task InsertInvoiceLine(ImportInvoiceLine line)
		{
			var mapped = AutoMapper.Mapper.Map<ImportInvoiceLine, importedInvoiceLine>(line);
			var duplicate = context.importedInvoiceLines.Where(x => x.SolidisItemPK == line.SolidisItemPK && x.SolidisProductPK == line.SolidisProductPK).FirstOrDefault();

			if (duplicate == null)
			{
				Insert(mapped);
				await SaveAsync();
			}
		}

	}
}
