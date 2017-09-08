namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class les_planner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public les_planner()
        {
            les_absence = new HashSet<les_absence>();
            les_plannedmember = new HashSet<les_plannedmember>();
        }

        public int id { get; set; }

        public int? cmp_id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public int lesson_id { get; set; }

        public int? l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public DateTime date { get; set; }

        public int? status_id { get; set; }

        public int? l_processed { get; set; }

        public virtual cmp cmp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_absence> les_absence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_plannedmember> les_plannedmember { get; set; }

        public virtual les_planstatus les_planstatus { get; set; }

        public virtual lesson lesson { get; set; }

        public virtual rel rel { get; set; }
    }
}
