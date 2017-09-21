using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Models.DTO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using BLL.Managers;
using System.IO;

namespace ZegroXMLService.Scheduler
{
	public class ImportJob : IJob
	{
		private readonly Uri apiUri = new Uri("http://localhost:54725/");
		private readonly XMLManager manager;

		public ImportJob()
		{
			manager = new XMLManager();
		}

		public async void Execute(IJobExecutionContext context)
		{
			try
			{
				var retrievedInvoices = await manager.GetItems<ImportInvoice>(XMLManager.Types.INVOICE);
				await DoPostsInvoices(retrievedInvoices);

				var retrievedCustomers = await manager.GetItems<ImportCustomer>(XMLManager.Types.CUSTOMERS);
				await DoPostsCustomers(retrievedCustomers);

				var retrievedPrices = await manager.GetItems<ImportSpecPrice>(XMLManager.Types.SPECPRICE);
				await DoPostsImportPrices(retrievedPrices);

				var retrievedItemsList = await manager.GetItems<ImportItem>(XMLManager.Types.ITEMS);
				await DoPostsImportItem(retrievedItemsList);
				//ThreadPool.QueueUserWorkItem(async i => await DoPostsImportItem(retrievedItemsList));

				var retrievedOrders = await manager.GetItems<ImportOrder>(XMLManager.Types.ORDER);
				await DoPostsImportOrders(retrievedOrders);
			}
			catch (Exception ex)
			{
				
				using (StreamWriter writer = new StreamWriter("C:\\templog.txt", true))
				{
					writer.WriteLine(String.Format("exception  {0},{1}",
						DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), ex.ToString()));
					writer.Flush();
				}
			}
		}

		public async Task DoPostsImportItem(IEnumerable<ImportItem> retrievedItemsList)
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = apiUri;
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				foreach (ImportItem item in retrievedItemsList)
				{

					StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
					var response = await client.PostAsync("api/ImportedData/PostItem", content);
					if (response.IsSuccessStatusCode)
					{
						//rm origin
					}
				}
			}
		}

		public async Task DoPostsCustomers(IEnumerable<ImportCustomer> retrievedcustomersList)
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = apiUri;
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				foreach (ImportCustomer item in retrievedcustomersList)
				{

					StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
					var response = await client.PostAsync("api/ImportedData/PostCustomer", content);
					if (response.IsSuccessStatusCode)
					{

					}
				}
			}
		}

		public async Task DoPostsImportOrders(IEnumerable<ImportOrder> retrievedItemsList)
		{

			using (HttpClient client = new HttpClient())
			{
				var ordersLines = new List<ImportOrderLine>();
				client.BaseAddress = apiUri;
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				foreach (ImportOrder item in retrievedItemsList)
				{
					foreach (var l in item.OrderLinesList)
					{
						l.orderSolidisPK = item.SolidisPK;
					}
					ordersLines.AddRange(item.OrderLinesList);
					item.OrderLinesList = new List<ImportOrderLine>();
					StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
					var response = await client.PostAsync("api/ImportedData/PostOrder", content);
					if (response.IsSuccessStatusCode)
					{

					}
				}
				foreach (ImportOrderLine line in ordersLines)
				{
					StringContent orderContent = new StringContent(JsonConvert.SerializeObject(line), Encoding.UTF8, "application/json");
					var resp = await client.PostAsync("api/ImportedData/PostOrderLine", orderContent);
					if (resp.IsSuccessStatusCode)
					{
						//
					}
				}
			}
		}

		public async Task DoPostsImportPrices(IEnumerable<ImportSpecPrice> retrievedPricesList)
		{

			using (HttpClient client = new HttpClient())
			{
				var pricesLines = new List<ImportSpecPriceItem>();
				client.BaseAddress = apiUri;
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				foreach (ImportSpecPrice item in retrievedPricesList)
				{
					foreach (var l in item.PriceItems)
					{
						l.SpecPriceSolidisPK = item.SolidisPK;
					}
					pricesLines.AddRange(item.PriceItems);
					item.PriceItems = new List<ImportSpecPriceItem>();
					StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
					var response = await client.PostAsync("api/ImportedData/PostSpecPrice", content);
					if (response.IsSuccessStatusCode)
					{

					}
				}
				foreach (ImportSpecPriceItem line in pricesLines)
				{
					StringContent orderContent = new StringContent(JsonConvert.SerializeObject(line), Encoding.UTF8, "application/json");
					var resp = await client.PostAsync("api/ImportedData/PostSpecPriceItem", orderContent);
					if (resp.IsSuccessStatusCode)
					{
						//
					}
				}
			}
		}

		public async Task DoPostsInvoices(IEnumerable<ImportInvoice> retrievedInvoicesList)
		{

			using (HttpClient client = new HttpClient())
			{
				var invoicesLines = new List<ImportInvoiceLine>();
				client.BaseAddress = apiUri;
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				foreach (ImportInvoice item in retrievedInvoicesList)
				{
					foreach (var l in item.InvoiceLines)
					{
						l.InvoiceSolidisPK = item.SolidisPK;
					}
					invoicesLines.AddRange(item.InvoiceLines);
					item.InvoiceLines = new List<ImportInvoiceLine>();
					StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
					var response = await client.PostAsync("api/ImportedData/PostInvoice", content);
					if (response.IsSuccessStatusCode)
					{

					}
				}
				foreach (ImportInvoiceLine line in invoicesLines)
				{
					StringContent orderContent = new StringContent(JsonConvert.SerializeObject(line), Encoding.UTF8, "application/json");
					var resp = await client.PostAsync("api/ImportedData/PostInvoiceLine", orderContent);
					if (resp.IsSuccessStatusCode)
					{
						//
					}
				}
			}
		}

	}
}
