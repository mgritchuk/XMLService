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

		private string _host;
		private string _userName;
		private string _password;
		private string _ingoingXMLPath;

		public ConfigFileManager() { }

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

				IniData data = new IniData(collection);
				parser.WriteFile("C:\\config.ini", data);
				//host = data["FTPPath"]["host"];
				//userName = data["Credentials"]["name"];
				//pwd = data["Credentials"]["pwd"];

				//path = data["IngoingXML"]["path"];
			}
			else
			{
				IniData data = parser.ReadFile("C:\\config.ini");
				_host = data["FTPPath"]["host"];
				_userName = data["Credentials"]["name"];
				_password = data["Credentials"]["pwd"];

				_ingoingXMLPath = data["IngoingXML"]["path"];
			}
		}
	}

}
