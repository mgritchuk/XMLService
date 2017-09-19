using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Interfaces;
using System.Threading.Tasks;
using Models.DB;
using Models.DTO;

namespace ZegroWebAPI.Controllers
{
    public class ImportedDataController : ApiController
    {
		private readonly IXMLManager manager;
		public ImportedDataController(IXMLManager manager)
		{
			this.manager = manager;
		}

		[HttpGet]
		public IHttpActionResult GetAllAllergens()
		{
			return Json(manager.GetAllItemAllergens());
		}

		[HttpPost]
		public async Task<IHttpActionResult> PostItem(ImportItem item)
		{
			//manager.InsertItem(item);
			return Json(await manager.Add<importedItems, ImportItem>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));
			
		}

    }
}
