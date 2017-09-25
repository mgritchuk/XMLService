using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
	public class ConfigFileManager
	{
		public string Host
		{
			get
			{
				return _host;
			}
		}

		public string UserName
		{
			get
			{
				return _userName;
			}
		}

		public string Password
		{
			get
			{
				return _password;
			}
		}

		public string IngoingXMLPath
		{
			get
			{
				return _ingoingXMLPath;
			}
		}
		public string ApiUrl
		{
			get
			{
				return _apiUrl;
			}
		}

		private string _host;
		private string _userName;
		private string _password;
		private string _ingoingXMLPath;
		private string _apiUrl;

		public ConfigFileManager() { }

		public void UpdateConfiguration(string host, string userName, string password, string writeFilesTo, string apiUrl)
		{
			var parser = new FileIniDataParser();
			SectionDataCollection collection = new SectionDataCollection();
			var section1 = new SectionData("FTPPath");
			section1.Keys.AddKey(new KeyData("host"));
			collection.Add(section1);
			collection["FTPPath"]["host"] = host;

			var section2 = new SectionData("Credentials");
			section2.Keys.AddKey(new KeyData("name"));
			section2.Keys.AddKey(new KeyData("pwd"));
			collection.Add(section2);
			collection["Credentials"]["name"] = userName;
			collection["Credentials"]["pwd"] = password;

			var section3 = new SectionData("IngoingXML");
			section3.Keys.AddKey(new KeyData("path"));

			collection.Add(section3);
			collection["IngoingXML"]["path"] = writeFilesTo;

			var section4 = new SectionData("ApiUrl");
			section4.Keys.AddKey(new KeyData("url"));

			collection.Add(section4);
			collection["ApiUrl"]["url"] = apiUrl;

			IniData data = new IniData(collection);
			parser.WriteFile("C:\\config.ini", data);

			
			_host = host;
			_userName = userName;
			_password = password;
			_apiUrl = apiUrl;
			_ingoingXMLPath = writeFilesTo;
		}

		public void ReadConfiguration()
		{
			var parser = new FileIniDataParser();
			if (!File.Exists("C:\\config.ini"))
			{

				SectionDataCollection collection = new SectionDataCollection();
				var section1 = new SectionData("FTPPath");
				section1.Keys.AddKey(new KeyData("host"));
				collection.Add(section1);
				collection["FTPPath"]["host"] = "test";

				var section2 = new SectionData("Credentials");
				section1.Keys.AddKey(new KeyData("name"));
				section1.Keys.AddKey(new KeyData("pwd"));
				collection.Add(section2);
				collection["Credentials"]["name"] = "test";
				collection["Credentials"]["pwd"] = "test";

				var section3 = new SectionData("IngoingXML");
				section1.Keys.AddKey(new KeyData("path"));

				collection.Add(section3);
				collection["IngoingXML"]["path"] = "test";

				var section4 = new SectionData("ApiUrl");
				section4.Keys.AddKey(new KeyData("url"));

				collection.Add(section4);
				collection["ApiUrl"]["url"] = "http://localhost:54725/";

				IniData data = new IniData(collection);
				parser.WriteFile("C:\\config.ini", data);
				_host = data["FTPPath"]["host"];
				_userName = data["Credentials"]["name"];
				_password = data["Credentials"]["pwd"];
				
				_ingoingXMLPath = data["IngoingXML"]["path"];
				_apiUrl = data["ApiUrl"]["url"];
				
			}
			else
			{
				IniData data = parser.ReadFile("C:\\config.ini");
				_host = data["FTPPath"]["host"];
				_userName = data["Credentials"]["name"];
				_password = data["Credentials"]["pwd"];
				_apiUrl = data["ApiUrl"]["url"];
				_ingoingXMLPath = data["IngoingXML"]["path"];
			}
		}
	}

}
