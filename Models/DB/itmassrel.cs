namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itmassrel")]
    public partial class itmassrel
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string itmassmst_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string itmassind_ad { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [StringLength(100)]
        public string mod_ad { get; set; }

        public int? l_trigger { get; set; }

        public virtual itmassind itmassind { get; set; }

        public virtual itmassmst itmassmst { get; set; }

        public virtual modmst modmst { get; set; }

        public virtual rel rel { get; set; }
    }
}
