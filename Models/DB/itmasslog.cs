namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itmasslog")]
    public partial class itmasslog
    {
        public int id { get; set; }

        [StringLength(100)]
        public string itmassmst_ad { get; set; }

        [StringLength(100)]
        public string itm_ad { get; set; }

        [StringLength(100)]
        public string mutAction { get; set; }

        public DateTime dt_log { get; set; }
    }
}
