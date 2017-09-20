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
		private readonly ILogImportsManager manager;

		public ImportedDataController(ILogImportsManager manager)
		{
			this.manager = manager;
		}



		[HttpPost]
		public async Task<IHttpActionResult> PostItem(ImportItem item)
		{
			
			return Json(await manager.Add<importedItems, ImportItem>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));
			
		}

		[HttpPost]
		public async Task<IHttpActionResult> PostItems(IEnumerable<ImportItem> items)
		{
			List<ImportItem> res = new List<ImportItem>();
			foreach(ImportItem item in items)
			{
				res.Add( await manager.Add<importedItems, ImportItem>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));

			}
			return Json(res);
		}

		[HttpPut]
		public async Task<IHttpActionResult> PutItem(ImportItem item)
		{
			await manager.Update<importedItems, ImportItem>(item, i => i.SolidisPK);
			return Ok();
		}

		[HttpPut]
		public async Task<IHttpActionResult> PutItems(IEnumerable<ImportItem> items)
		{
			foreach (ImportItem item in items)
			{
				await manager.Update<importedItems, ImportItem>(item, i => i.SolidisPK);
			}
			return Ok();
		}
    }
}
