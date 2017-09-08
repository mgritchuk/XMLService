namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("relcontact")]
    public partial class relcontact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public relcontact()
        {
            relemail = new HashSet<relemail>();
            relusr = new HashSet<relusr>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string fullname { get; set; }

        [Required]
        [StringLength(100)]
        public string relsalutation_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string foreletters { get; set; }

        [Required]
        [StringLength(100)]
        public string firstname { get; set; }

        [Required]
        [StringLength(100)]
        public string lastname { get; set; }

        [Required]
        [StringLength(100)]
        public string searchname { get; set; }

        [Required]
        [StringLength(100)]
        public string tel { get; set; }

        public int l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public int? l_trigger { get; set; }

        public virtual rel rel { get; set; }

        public virtual relsalutation relsalutation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relemail> relemail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relusr> relusr { get; set; }
    }
}
