using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
	[Table("importedSpecPrice")]
	public class importedSpecPrice
	{
		[Key]
		[StringLength(50)]
		public string SolidisPK { get; set; }
		[StringLength(100)]
		public string Name { get; set; }
		[StringLength(50)]
		public string Action { get; set; }
		[StringLength(50)]
		public string Validation { get; set; }

	
		public virtual List<importedSpecPriceItem> PriceItems { get; set; }
	}
	
}
