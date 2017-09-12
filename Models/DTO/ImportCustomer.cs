using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ImportCustomer
	{
		public ImportCustomer() { }
		public string Action { get; set; }
		public string Validation { get; set; }
		public string Displaycode { get; set; }
		public string SolidisPK { get; set; }
		public string Name { get; set; }
		public string Street { get; set; }
		public string StreetNr { get; set; }
		public string StreetNrAdd { get; set; }
		public string City { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
	}
}
