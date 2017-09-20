using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
	[Table("importedSpecPriceItem")]
	public class importedSpecPriceItem
	{
		[Key]
		[StringLength(50)]
		public string SolidisPK { get; set; }
		[Required]
		[StringLength(50)]
		public string SpecPriceSolidisPK { get; set; }
		[StringLength(50)]
		public string Displaycode { get; set; }
		[StringLength(100)]
		public string Description { get; set; }
		
		public double Price { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		[StringLength(50)]
		public string Type { get; set; }

		[ForeignKey("SpecPriceSolidisPK")]
		public virtual importedSpecPrice importedSpecPrice { get; set; }

	}
}
