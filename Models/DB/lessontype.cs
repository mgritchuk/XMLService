namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lessontype")]
    public partial class lessontype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lessontype()
        {
            lesson = new HashSet<lesson>();
        }

        public int? cmp_id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public string description { get; set; }

        public string notes { get; set; }

        public int condition { get; set; }

        public int strength { get; set; }

        public int relaxation { get; set; }

        public int? status_id { get; set; }

        public int? l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int id { get; set; }

        public virtual cmp cmp { get; set; }

        public virtual les_planstatus les_planstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lesson> lesson { get; set; }

        public virtual rel rel { get; set; }
    }
}
