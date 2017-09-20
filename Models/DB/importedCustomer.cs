using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
	[Table("importedCustomer")]
	public class importedCustomer
	{
		[Key]
		[StringLength(50)]
		public string SolidisPK { get; set; }
		[StringLength(50)]
		public string Action { get; set; }
		[StringLength(50)]
		public string Validation { get; set; }
		[StringLength(50)]
		public string Displaycode { get; set; }

		[StringLength(100)]
		public string Name { get; set; }
		[StringLength(100)]
		public string Street { get; set; }
		[StringLength(100)]
		public string StreetNr { get; set; }
		[StringLength(100)]
		public string StreetNrAdd { get; set; }
		[StringLength(100)]
		public string City { get; set; }
		[StringLength(100)]
		public string Zip { get; set; }
		[StringLength(100)]
		public string Country { get; set; }
		[StringLength(100)]
		public string Phone { get; set; }
		[StringLength(100)]
		public string Fax { get; set; }
	}
}
