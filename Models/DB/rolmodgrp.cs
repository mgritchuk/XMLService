namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rolmodgrp")]
    public partial class rolmodgrp
    {
        [StringLength(100)]
        public string modrolgrp_ad { get; set; }

        [StringLength(100)]
        public string modmst_ad { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public int id { get; set; }

        public virtual modmst modmst { get; set; }

        public virtual modrolgrp modrolgrp { get; set; }
    }
}
