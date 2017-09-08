namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syssettings
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string syssection { get; set; }

        [Required]
        [StringLength(100)]
        public string sysfield { get; set; }

        [StringLength(250)]
        public string sysvalue { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [Required]
        [StringLength(100)]
        public string modmst_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public int? relusr_id { get; set; }

        public virtual modmst modmst { get; set; }

        public virtual rel rel { get; set; }

        public virtual relusr relusr { get; set; }
    }
}
