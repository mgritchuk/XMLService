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


		//items
		[HttpPost]
		public async Task<IHttpActionResult> PostItem(ImportItem item)
		{
			var duplicate = await manager.Get<importedItems, ImportItem>(item.SolidisPK);
			if(duplicate == null)
				return Json(await manager.Add<importedItems, ImportItem>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));
			return Json(false);
			
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

		//orders
		[HttpPost]
		public async Task<IHttpActionResult> PostOrder(ImportOrder item)
		{
			var duplicate = await manager.Get<importedOrder, ImportOrder>(item.SolidisPK);
			if (duplicate == null)
				return Json(await manager.Add<importedOrder, ImportOrder>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));
			return Json(false);

		}

		[HttpPost]
		public async Task<IHttpActionResult> PostOrders(IEnumerable<ImportOrder> items)
		{
			List<ImportOrder> res = new List<ImportOrder>();
			foreach (ImportOrder item in items)
			{
				res.Add(await manager.Add<importedOrder, ImportOrder>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));

			}
			return Json(res);
		}

		[HttpPut]
		public async Task<IHttpActionResult> PutOrder(ImportOrder item)
		{
			await manager.Update<importedOrder, ImportOrder>(item, i => i.SolidisPK);
			return Ok();
		}

		[HttpPut]
		public async Task<IHttpActionResult> PutOrders(IEnumerable<ImportOrder> items)
		{
			foreach (ImportOrder item in items)
			{
				await manager.Update<importedOrder, ImportOrder>(item, i => i.SolidisPK);
			}
			return Ok();
		}

		//orderlines
		[HttpPost]
		public async Task<IHttpActionResult> PostOrderLine(ImportOrderLine item)
		{
			var duplicate = await manager.Get<importedOrderLine, ImportOrderLine>(item.SolidisItemPK);
			if (duplicate == null)
				
				return Json(await manager.Add<importedOrderLine, ImportOrderLine>(item, (db, dto) => dto.orderSolidisPK = db.orderSolidisPK));
			return Json(false);
		}

		//specprice
		[HttpPost]
		public async Task<IHttpActionResult> PostSpecPrice(ImportSpecPrice item)
		{
			var duplicate = await manager.Get<importedSpecPrice, ImportSpecPrice>(item.SolidisPK);
			if (duplicate == null)

				return Json(await manager.Add<importedSpecPrice, ImportSpecPrice>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));
			return Json(false);
		}

		//specpriceitem
		[HttpPost]
		public async Task<IHttpActionResult> PostSpecPriceItem(ImportSpecPriceItem item)
		{
			var duplicate = await manager.Get<importedSpecPriceItem, ImportSpecPriceItem>(item.SolidisPK);
			if (duplicate == null)

				return Json(await manager.Add<importedSpecPriceItem, ImportSpecPriceItem>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));
			return Json(false);
		}

		//customer
		[HttpPost]
		public async Task<IHttpActionResult> PostCustomer(ImportCustomer item)
		{
			var duplicate = await manager.Get<importedCustomer, ImportCustomer>(item.SolidisPK);
			if (duplicate == null)

				return Json(await manager.Add<importedCustomer, ImportCustomer>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));
			return Json(false);
		}

		//invoice line
		[HttpPost]
		public async Task<IHttpActionResult> PostInvoiceLine(ImportInvoiceLine item)
		{
			await manager.InsertInvoiceLine(item);
			return Ok();
		}

		//invoice
		[HttpPost]
		public async Task<IHttpActionResult> PostInvoice(ImportInvoice item)
		{
			var duplicate = await manager.Get<importedInvoice, ImportInvoice>(item.SolidisPK);
			if (duplicate == null)

				return Json(await manager.Add<importedInvoice, ImportInvoice>(item, (db, dto) => dto.SolidisPK = db.SolidisPK));
			return Json(false);
		}
	}
}
