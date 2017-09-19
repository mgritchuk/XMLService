using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
	[Table("importedItems")]
	public class importedItems
	{
		[StringLength(100)]
		public string Action { get; set; }

		[StringLength(100)]
		public string Validation { get; set; }

		
		[StringLength(50)]
		public string DisplayCode { get; set; }
		[Key]
		[StringLength(100)]
		public string SolidisPK { get; set; }
		[StringLength(100)]
		public string Description { get; set; }
		[StringLength(100)]
		public string DefaultUnitOfMeasure { get; set; }
		[StringLength(100)]
		public string DefaultTradeUnitOfMeasure { get; set; }
	}
}
