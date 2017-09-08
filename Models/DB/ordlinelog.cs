namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordlinelog")]
    public partial class ordlinelog
    {
        public int id { get; set; }

        [StringLength(100)]
        public string ord_ad { get; set; }

        [StringLength(100)]
        public string itm_ad { get; set; }

        [StringLength(100)]
        public string rel_ad { get; set; }

        [StringLength(100)]
        public string mutAction { get; set; }

        public DateTime dt_log { get; set; }
    }
}
