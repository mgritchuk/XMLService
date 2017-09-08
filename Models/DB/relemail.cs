namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("relemail")]
    public partial class relemail
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public int relcontact_id { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        public int l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public virtual rel rel { get; set; }

        public virtual relcontact relcontact { get; set; }
    }
}
