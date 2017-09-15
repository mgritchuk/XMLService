using BLL.Interfaces;
using System;
using System.Collections.Generic;
using Models.DB;
using Models.DTO;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Text;

namespace BLL.Managers
{
	public class XMLManager : BaseManager, IXMLManager
	{


		#region FTP credentials
		
		#endregion
		private readonly Encoding noByteOrderMark = new UTF8Encoding(false);
		public enum Types { ITEMS, ORDER, SPECPRICE, INVOICE, CUSTOMERS };
		public XMLManager(MainContext context) : base(context)
		{
		}

		public async Task<IEnumerable<T>> GetItems<T>(Types type) where T : class
		{
			FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(host);
			request.Credentials = new NetworkCredential(userName, pwd);
			request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
			request.UseBinary = true;
			request.UsePassive = true;
			request.KeepAlive = false;

			string[] listFilesInfo = null;
			List<FtpDirItem> files = new List<FtpDirItem>();

			using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
			using (StreamReader reader = new StreamReader(response.GetResponseStream()))
			{
				listFilesInfo = reader.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
			}



			foreach (string line in listFilesInfo)
			{
				string data = line;
				string date = data.Substring(0, 24);

				data = data.Remove(0, 24);

				string dir = data.Substring(0, 5);
				bool isDirectory = dir.Equals("<dir>", StringComparison.InvariantCultureIgnoreCase);
				data = data.Remove(0, 15);


				if (!isDirectory && data.Contains(type.ToString()))
				{
					files.Add(new FtpDirItem(data));
				}
				//if (!isDirectory && data.Contains("SPECPRICE"))
				//{
				//	files.Add(new FtpDirItem(data));
				//}
			}

			
			return await ImportItems<T>(files);
		}
		

		private async Task<IEnumerable<T>> ImportItems<T>(List<FtpDirItem> files) where T : class
		{
			List<T> importedItems = new List<T>();
			WebClient webRequest = new WebClient();
			webRequest.Credentials = new NetworkCredential(userName, pwd);
			foreach (FtpDirItem file in files)
			{

				try
				{

					byte[] newFileData = await webRequest.DownloadDataTaskAsync(new Uri(host + '/' + file.Name));

					XDocument xml = new XDocument();

					string path = System.Text.Encoding.UTF8.GetString(newFileData);

					//var cut = path.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
					//if(cut != path)
					//{

					//}
					//xml = XDocument.Parse(cut);
					
					
					//path = "<ImportData>  <Items>  <Item Action=\"InsertOrUpdate\" Validation=\"None\"><Displaycode> 3119.668.97 </Displaycode> <SolidisPK> 678 </SolidisPK> <Description> Le Capllin Filet Geportioneerd </Description>	<DefaultUnitOfMeasure.Code> KILO </DefaultUnitOfMeasure.Code><DefaultTradeUnitOfMeasure.Code/> </Item>   <Item Action=\"InsertOrUpdate\" Validation=\"None\">	  <Displaycode> 3119.668.96 </Displaycode> <SolidisPK> 1740753 </SolidisPK>		<Description> Le Capellin Filet Geportioneerd </Description>  	<DefaultUnitOfMeasure.Code> KG </DefaultUnitOfMeasure.Code>	<DefaultTradeUnitOfMeasure.Code/> </Item ></Items> </ImportData>";

					using (StringReader s = new StringReader(path))
					{
						xml = XDocument.Load(s);
					}

					SaveImportedXML(xml, file.Name);

					List<XDocument> docs = new List<XDocument>();
					List<List<XDocument>> linesDocs = new List<List<XDocument>>();
					#region parse
					switch (typeof(T).Name.ToString())
					{
						case "ImportItem":
							{
								docs = xml.Descendants("Items")
									.SelectMany(x => x.Elements())
									.Select(s =>
									{
										var tempDoc = new XDocument(xml);
										var elementToDelete = tempDoc.Elements("ImportData").Elements("Items").Elements("Item").ToList();
										foreach (XElement elem in elementToDelete)
										{
											if (s.ToString() != elem.ToString())
												elem.Remove();
										}
								//var x = temp.Elements("ImportData").Elements("Items").Select(e => e.Elements("Item").Where(i => i == s).FirstOrDefault());
								return tempDoc;
									}).ToList();
								break;
							}
						case "ImportCustomer":
							{
								docs = xml.Descendants("Customers")
									.SelectMany(x => x.Elements())
									.Select(s =>
									{
										var tempDoc = new XDocument(xml);
										var elementToDelete = tempDoc.Elements("ImportData").Elements("Customers").Elements("Customer").ToList();
										foreach (XElement elem in elementToDelete)
										{
											if (s.ToString() != elem.ToString())
												elem.Remove();
										}
										return tempDoc;
									}).ToList();
								break;
							}
						case "ImportInvoice":
							{
								//linesDocs = xml.Descendants("Invoice").Elements("Invoicelines")
								//	.SelectMany(x => x.Elements())
								//	.Select(s =>
								//	{
								//		var tempDoc = new XDocument(xml);
								//		var elementsToDelete = tempDoc.Elements("ImportData").Elements("Invoices").Elements("Invoice").Elements("Invoicelines").Elements("InvoiceLine").ToList();
								//		foreach (XElement elem in elementsToDelete)
								//		{
								//			if (s.ToString() != elem.ToString())
								//				elem.Remove();
								//		}
								//		return tempDoc;
								//	}).ToList();

								docs = xml.Descendants("Invoices")
									.SelectMany(x => x.Elements())
									.Select(s =>
									{
										var tempDoc = new XDocument(xml);
										var elementsToDelete = tempDoc.Elements("ImportData").Elements("Invoices").Elements("Invoice").ToList();
										foreach (XElement elem in elementsToDelete)
										{
											if (s.ToString() != elem.ToString())
												elem.Remove();
										}
										/////
										var invoiceLines = tempDoc.Descendants("Invoice").Elements("Invoicelines")
										.SelectMany(x => x.Elements())
										.Select(l =>
										{
											var linesDoc = new XDocument(l);
											//var lineElementsToDelete = linesDoc.Elements("ImportData").Elements("Invoices").Elements("Invoice").Elements("Invoicelines").Elements("InvoiceLine").ToList();
											//foreach (XElement elem in lineElementsToDelete)
											//{
											//	if (l.ToString() != elem.ToString())
											//		elem.Remove();
											//}
											return linesDoc;
										}).ToList();

										///
										linesDocs.Add(invoiceLines);
										return tempDoc;

									}).ToList();

								break;
							}
						case "ImportSpecPrice":
							{
								docs = xml.Descendants("SpecPrices")
									.SelectMany(x => x.Elements())
									.Select(s =>
									{
										var tempDoc = new XDocument(xml);
										var elementsToDelete = tempDoc.Elements("ImportData").Elements("SpecPrices").Elements("SpecPrice").ToList();
										foreach (XElement elem in elementsToDelete)
										{
											if (s.ToString() != elem.ToString())
												elem.Remove();
										}
										/////
										var priceLines = tempDoc.Descendants("SpecPrice").Elements("Items")
										.SelectMany(x => x.Elements())
										.Select(l =>
										{
											var linesDoc = new XDocument(l);
											
											return linesDoc;
										}).ToList();

										///
										linesDocs.Add(priceLines);
										return tempDoc;

									}).ToList();

								break;
							}
						case "ImportOrder":
							{
								docs = xml.Descendants("Orders")
									.SelectMany(x => x.Elements())
									.Select(s =>
									{
										var tempDoc = new XDocument(xml);
										var elementsToDelete = tempDoc.Elements("ImportData").Elements("Orders").Elements("Order").ToList();
										foreach (XElement elem in elementsToDelete)
										{
											if (s.ToString() != elem.ToString())
												elem.Remove();
										}
										/////
										var orderLines = tempDoc.Descendants("Order").Elements("OrderLines")
										.SelectMany(x => x.Elements())
										.Select(l =>
										{
											var linesDoc = new XDocument(l);

											return linesDoc;
										}).ToList();

										///
										linesDocs.Add(orderLines);
										return tempDoc;

									}).ToList();

								break;
							}

					}
					List<T> retrievedValues = new List<T>();
					int i = 0;
					foreach (XDocument doc in docs)
					{
						
						retrievedValues.Add(AutoMapper.Mapper.Map<XDocument, T>(doc));
						
						switch (typeof(T).Name.ToString())
						{
							case "ImportInvoice":
								{
									(retrievedValues[i] as ImportInvoice).InvoiceLines = new List<ImportInvoiceLine>();
									foreach (XDocument xDoc in linesDocs[i])
									{
										(retrievedValues[i] as ImportInvoice).InvoiceLines.Add(AutoMapper.Mapper.Map<XDocument, ImportInvoiceLine>(xDoc));
									}
									break;
								}
							case "ImportSpecPrice":
								{
									(retrievedValues[i] as ImportSpecPrice).PriceItems = new List<ImportSpecPriceItem>();
									foreach (XDocument xDoc in linesDocs[i])
									{
										(retrievedValues[i] as ImportSpecPrice).PriceItems.Add(AutoMapper.Mapper.Map<XDocument, ImportSpecPriceItem>(xDoc));
									}
									break;
								}
							case "ImportOrder":
								{
									(retrievedValues[i] as ImportOrder).OrderLinesList = new List<ImportOrderLine>();
									foreach (XDocument xDoc in linesDocs[i])
									{
										(retrievedValues[i] as ImportOrder).OrderLinesList.Add(AutoMapper.Mapper.Map<XDocument, ImportOrderLine>(xDoc));
									}
									break;
								}
						}
						i++;
					}
					importedItems.AddRange(retrievedValues);
#endregion
				}
				catch (WebException ex)
				{	}
			}
			return importedItems;
		}


		private void SaveImportedXML(XDocument doc, string fileName)
		{
			string now = DateTime.UtcNow.Date.ToShortDateString();
			string path = "C:\\ImportedXML\\" + now + "\\";
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
			XmlWriterSettings settings = new XmlWriterSettings { OmitXmlDeclaration = true, Indent = true, Encoding = noByteOrderMark };
			using (XmlWriter writer = XmlWriter.Create(path + fileName, settings))
			

			doc.Save(writer);
		}
	}
}
