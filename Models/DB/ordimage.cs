namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordimage")]
    public partial class ordimage
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string ord_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string filename { get; set; }

        [Required]
        [StringLength(250)]
        public string description { get; set; }

        public int? l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public int? l_signature { get; set; }

        public byte[] contents { get; set; }

        public virtual ordmain ordmain { get; set; }
    }
}
