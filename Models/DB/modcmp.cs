namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("modcmp")]
    public partial class modcmp
    {
        public int id { get; set; }

        public int syscompany_id { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public virtual cmp cmp { get; set; }
    }
}
