namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lesson")]
    public partial class lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lesson()
        {
            les_planner = new HashSet<les_planner>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public int? cmp_id { get; set; }

        public int? relusr_id { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public int type_id { get; set; }

        public string notes { get; set; }

        public int max_registred { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        [StringLength(100)]
        public string day { get; set; }

        public int? status_id { get; set; }

        public int reg_req { get; set; }

        public int? l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int interval_id { get; set; }

        public TimeSpan? time_from { get; set; }

        public TimeSpan? time_to { get; set; }

        public virtual cmp cmp { get; set; }

        public virtual les_interval les_interval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_planner> les_planner { get; set; }

        public virtual les_planstatus les_planstatus { get; set; }

        public virtual rel rel { get; set; }

        public virtual lessontype lessontype { get; set; }
    }
}
