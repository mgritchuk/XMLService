namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class les_access_ip
    {
        public int? cmp_id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        [StringLength(100)]
        public string ip_address { get; set; }

        [StringLength(100)]
        public string host { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public int? l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int id { get; set; }

        public virtual cmp cmp { get; set; }

        public virtual rel rel { get; set; }
    }
}
