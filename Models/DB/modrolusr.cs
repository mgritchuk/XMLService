namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("modrolusr")]
    public partial class modrolusr
    {
        public int id { get; set; }

        public int relusr_id { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [StringLength(100)]
        public string modrolgrp_ad { get; set; }

        public virtual modrolgrp modrolgrp { get; set; }

        public virtual relusr relusr { get; set; }
    }
}
