namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordtype")]
    public partial class ordtype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ordtype()
        {
            ordmain = new HashSet<ordmain>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string description { get; set; }

        public int? l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordmain> ordmain { get; set; }
    }
}
