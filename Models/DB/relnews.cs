namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class relnews
    {
        public int id { get; set; }

        public DateTime dt_start { get; set; }

        public DateTime dt_stop { get; set; }

        [Required]
        [StringLength(250)]
        public string headertext { get; set; }

        public string bodytext { get; set; }

        public byte[] relnewsimage { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [StringLength(100)]
        public string rel_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string frmmst_ad { get; set; }

        [StringLength(100)]
        public string relnewsgrpmst_ad { get; set; }

        public virtual frmmst frmmst { get; set; }

        public virtual rel rel { get; set; }

        public virtual relnewsgrpmst relnewsgrpmst { get; set; }
    }
}
