namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class les_absence
    {
        public int id { get; set; }

        public int? cmp_id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public int? planner_id { get; set; }

        public int? planner_member_id { get; set; }

        public int is_absence { get; set; }

        public string notes { get; set; }

        public int? l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public virtual cmp cmp { get; set; }

        public virtual les_plannedmember les_plannedmember { get; set; }

        public virtual les_planner les_planner { get; set; }

        public virtual rel rel { get; set; }
    }
}
