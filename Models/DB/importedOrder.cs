using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
	[Table("importedOrder")]
	public class importedOrder
	{
		[Key]
		[StringLength(50)]
		public string SolidisPK { get; set; }

		[StringLength(100)]
		public string Action { get; set; }

		[StringLength(100)]
		public string Validation { get; set; }

		[StringLength(50)]
		public string Displaycode { get; set; }
		
		public virtual List<importedOrderLine> importedOrderLine { get; set; }
		
	}
}
