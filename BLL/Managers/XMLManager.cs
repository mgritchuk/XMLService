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
using static ImportSpecPriceModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace BLL.Managers
{
	public class XMLManager : BaseManager, IXMLManager
	{
		

		#region FTP credentials
		private const string host = "ftp://90.145.96.196/ERPToPasys";
		private const string userName = @"zegro\pasys";
		private const string pwd = "MGkt8ETL";
		#endregion
		public enum Types { ITEMS, ORDER, SPECPRISE, INVOICE, CUSTOMERS };
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
					//path = "<ImportData>  <Items>  <Item Action=\"InsertOrUpdate\" Validation=\"None\"><Displaycode> 3119.668.97 </Displaycode> <SolidisPK> 678 </SolidisPK> <Description> Le Capllin Filet Geportioneerd </Description>	<DefaultUnitOfMeasure.Code> KILO </DefaultUnitOfMeasure.Code><DefaultTradeUnitOfMeasure.Code/> </Item>   <Item Action=\"InsertOrUpdate\" Validation=\"None\">	  <Displaycode> 3119.668.96 </Displaycode> <SolidisPK> 1740753 </SolidisPK>		<Description> Le Capellin Filet Geportioneerd </Description>  	<DefaultUnitOfMeasure.Code> KG </DefaultUnitOfMeasure.Code>	<DefaultTradeUnitOfMeasure.Code/> </Item ></Items> </ImportData>";

					using (StringReader s = new StringReader(path))
						xml = XDocument.Load(s);


					var docs = xml.Descendants("Items")
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
					List<T> retrievedValues = new List<T>();
					foreach (XDocument doc in docs)
					{
						retrievedValues.Add(AutoMapper.Mapper.Map<XDocument, T>(doc));
					}
					importedItems.AddRange(retrievedValues);
				}
				catch (WebException ex)
				{	}
			}
			return importedItems;
		}
	
	}
}
