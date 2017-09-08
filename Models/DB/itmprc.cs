namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itmprc")]
    public partial class itmprc
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string itmprcmst_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string itm_ad { get; set; }

        [StringLength(100)]
        public string rel_ad { get; set; }

        public decimal? qty { get; set; }

        [StringLength(100)]
        public string prctype_ad { get; set; }

        public decimal? prc_pce { get; set; }

        public DateTime? dt_start { get; set; }

        public DateTime? dt_end { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public string promo_code { get; set; }

        public virtual itm itm { get; set; }

        public virtual itmprcmst itmprcmst { get; set; }

        public virtual prcetype prcetype { get; set; }

        public virtual rel rel { get; set; }
    }
}
