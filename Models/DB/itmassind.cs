namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itmassind")]
    public partial class itmassind
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public itmassind()
        {
            itmassrel = new HashSet<itmassrel>();
        }

        [Key]
        [StringLength(100)]
        public string ad { get; set; }

        [Required]
        [StringLength(250)]
        public string description { get; set; }

        public int l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmassrel> itmassrel { get; set; }
    }
}
