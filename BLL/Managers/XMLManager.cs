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
using System.Data.SqlClient;
using System.Data;
using IniParser;
using IniParser.Model;

namespace BLL.Managers
{

	public class XMLManager : IXMLManager
	{


		#region FTP credentials
		//private readonly string host = "";//"ftp://90.145.96.196/ERPToPasys";
		//private readonly string userName = "";// @"zegro\pasys";
		//private readonly string pwd = "";//"MGkt8ETL";
		//private readonly string path = "C:\\ImportedXML";
		#endregion
		//private readonly string connectionString = "Data Source=149.210.200.56; ;Initial Catalog=project_ukr_temp;Network Library=DBMSSOCN;User Id = ahguest_1; Password = ahguest_1;";
		private readonly Encoding noByteOrderMark = new UTF8Encoding(false);
		public enum Types { ITEMS, ORDER, SPECPRICE, INVOICE, CUSTOMERS };
		private readonly ConfigFileManager confManager;
		
		public XMLManager()
		{
			
			confManager = new ConfigFileManager();
			confManager.ReadConfiguration();


		}

		public async Task<IEnumerable<T>> GetItems<T>(Types type) where T : class
		{
			FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(confManager.Host);
			request.Credentials = new NetworkCredential(confManager.UserName, confManager.Password);
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
			webRequest.Credentials = new NetworkCredential(confManager.UserName, confManager.Password);
			foreach (FtpDirItem file in files)
			{


				try
				{

					byte[] newFileData = await webRequest.DownloadDataTaskAsync(new Uri(confManager.Host + '/' + file.Name));

					XDocument xml = new XDocument();
					string path = System.Text.Encoding.UTF8.GetString(newFileData);
					//path = "<ImportData>  <Items>  <Item Action=\"InsertOrUpdate\" Validation=\"None\"><Displaycode> 3119.668.97 </Displaycode> <SolidisPK> 678 </SolidisPK> <Description> Le Capllin Filet Geportioneerd </Description>	<DefaultUnitOfMeasure.Code> KILO </DefaultUnitOfMeasure.Code><DefaultTradeUnitOfMeasure.Code/> </Item>   <Item Action=\"InsertOrUpdate\" Validation=\"None\">	  <Displaycode> 3119.668.96 </Displaycode> <SolidisPK> 1740753 </SolidisPK>		<Description> Le Capellin Filet Geportioneerd </Description>  	<DefaultUnitOfMeasure.Code> KG </DefaultUnitOfMeasure.Code>	<DefaultTradeUnitOfMeasure.Code/> </Item ></Items> </ImportData>";

					using (StringReader s = new StringReader(path))
					{
						try
						{
							xml = XDocument.Load(s);
						}
						catch (Exception ex)
						{
							
							using (StreamWriter writer = new StreamWriter("C:\\templog.txt", true))
							{
								writer.WriteLine(String.Format("exception on parsing xml {0},{1}, {2}",
									DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), ex.ToString()), file.Name);
								writer.Flush();
							}
						}
					}
					SaveImportedXML(xml, file.Name, true);

					List<XDocument> docs = new List<XDocument>();
					List<List<XDocument>> linesDocs = new List<List<XDocument>>();
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
							case "ImportCustomer":
								{
									(retrievedValues[i] as ImportCustomer).fileName = file.Name;
									break;
								}

							case "ImportItem":
								{
									(retrievedValues[i] as ImportItem).fileName = file.Name;
									break;
								}

							case "ImportInvoice":
								{
									(retrievedValues[i] as ImportInvoice).fileName = file.Name;
									(retrievedValues[i] as ImportInvoice).InvoiceLines = new List<ImportInvoiceLine>();
									foreach (XDocument xDoc in linesDocs[i])
									{
										(retrievedValues[i] as ImportInvoice).InvoiceLines.Add(AutoMapper.Mapper.Map<XDocument, ImportInvoiceLine>(xDoc));
										(retrievedValues[i] as ImportInvoice).InvoiceLines.Last().fileName = (retrievedValues[i] as ImportInvoice).fileName;
									}
									break;
								}
							case "ImportSpecPrice":
								{
									(retrievedValues[i] as ImportSpecPrice).fileName = file.Name;
									(retrievedValues[i] as ImportSpecPrice).PriceItems = new List<ImportSpecPriceItem>();
									foreach (XDocument xDoc in linesDocs[i])
									{
										(retrievedValues[i] as ImportSpecPrice).PriceItems.Add(AutoMapper.Mapper.Map<XDocument, ImportSpecPriceItem>(xDoc));
										(retrievedValues[i] as ImportSpecPrice).PriceItems.Last().fileName = (retrievedValues[i] as ImportSpecPrice).fileName;
									}
									break;
								}
							case "ImportOrder":
								{
									(retrievedValues[i] as ImportOrder).fileName = file.Name;
									(retrievedValues[i] as ImportOrder).OrderLinesList = new List<ImportOrderLine>();
									foreach (XDocument xDoc in linesDocs[i])
									{
										(retrievedValues[i] as ImportOrder).OrderLinesList.Add(AutoMapper.Mapper.Map<XDocument, ImportOrderLine>(xDoc));
										(retrievedValues[i] as ImportOrder).OrderLinesList.Last().fileName = (retrievedValues[i] as ImportOrder).fileName;
									}
									break;
								}
						}
						i++;
					}
					importedItems.AddRange(retrievedValues);
				}
				catch (WebException ex)
				{	}
			}
			return importedItems;
		}


		private void SaveImportedXML(XDocument doc, string fileName, bool removeOriginal)
		{
			string now = DateTime.UtcNow.Date.ToShortDateString();
			string path = confManager.IngoingXMLPath + "\\" + now + "\\";
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
		
			XmlWriterSettings settings = new XmlWriterSettings { OmitXmlDeclaration = true, Indent = true, Encoding = noByteOrderMark };
			using (XmlWriter writer = XmlWriter.Create(path + fileName, settings))
			{
				doc.Save(writer);
			}
		}

		public string DeleteOriginFile(string fileName)
		{
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(confManager.Host + "\\" + fileName);
			request.Method = WebRequestMethods.Ftp.DeleteFile;
			request.Credentials = new NetworkCredential(confManager.UserName, confManager.Password);

			using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
			{
				return response.StatusDescription;
			}
		}

		//public void InsertItem(ImportItem item)
		//{
		//	SqlConnection connection = new SqlConnection();
		//	connection.ConnectionString = connectionString;
		//	SqlCommand sql = new SqlCommand();
		//	sql.CommandText = "INSERT INTO importedItems (SolidisPK, Action, Validation, DisplayCode, Description, DefaultUnitOfMeasure, DefaultTradeUnitOfMeasure)" +
		//	"Values (@SolidisPK, @Action, @Validation, @DisplayCode, @Description, @DefaultUnitOfMeasure, @DefaultTradeUnitOfMeasure)";
		//	sql.Connection = connection;

		//	sql.Parameters.AddWithValue("@SolidisPK", item.SolidisPK);
		//	sql.Parameters.AddWithValue("@Action", item.Action);
		//	sql.Parameters.AddWithValue("@Validation", item.Validation);
		//	sql.Parameters.AddWithValue("@DisplayCode", item.DisplayCode);
		//	sql.Parameters.AddWithValue("@Description", item.Description);
		//	sql.Parameters.AddWithValue("@DefaultUnitOfMeasure", item.DefaultUnitOfMeasure);
		//	sql.Parameters.AddWithValue("@DefaultTradeUnitOfMeasure", item.DefaultTradeUnitOfMeasure);
		//	connection.Open();
		//	int rowInserted = sql.ExecuteNonQuery();
		//	connection.Close();


		//}

		//public List<ItmAlbaDTO> GetAllItemAllergens()
		//{
		//	List<ItmAlbaDTO> list =  new List<ItmAlbaDTO>();

		//	string sql = "SELECT [id], [version_ad], [itm_ad] FROM itmalba";

		//	var x = new ItmAlbaDTO();
		//	using (var connection = new SqlConnection(connectionString))
		//	using (var command = new SqlCommand(sql, connection))
		//	{
		//		connection.Open();
		//		using (var reader = command.ExecuteReader())
		//		{
		//			if (reader.HasRows)
		//			{
		//				//return AutoMapper.Mapper.Map<IDataReader, List<ItmAlbaDTO>>(reader);
		//				while(reader.Read())
		//				{
		//					//list.Add(reader[0].ToString());
		//					list.Add( AutoMapper.Mapper.Map<IDataReader, ItmAlbaDTO>(reader));
		//				}
		//			}
		//		}
		//	}


		//	return list;
		//}

	}
}
