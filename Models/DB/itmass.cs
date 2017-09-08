namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itmass")]
    public partial class itmass
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string itmassmst_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string itm_ad { get; set; }

        [StringLength(100)]
        public string rel_ad { get; set; }

        [StringLength(100)]
        public string seqnr { get; set; }

        public decimal? qty { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public int? l_trigger { get; set; }

        public virtual itm itm { get; set; }

        public virtual itmassmst itmassmst { get; set; }

        public virtual rel rel { get; set; }
    }
}
