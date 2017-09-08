namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("relmod")]
    public partial class relmod
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string mod_ad { get; set; }

        public int l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int? syshumres_id { get; set; }

        public int? systerminal_id { get; set; }

        public int? syscompany_id { get; set; }

        public virtual modmst modmst { get; set; }

        public virtual rel rel { get; set; }
    }
}
